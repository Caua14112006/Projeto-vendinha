# Documentação da Vendinha

## Objetivo

A aplicação controla os clientes e as dívidas de compras penduradas de uma
vendinha. Os dados ficam salvos no PostgreSQL e são acessados por telas do
Windows Forms.

## Cadastro e edição de clientes

O cliente possui código, nome, CPF, nascimento e e-mail. O código é gerado
pelo banco. A idade é calculada a partir do nascimento, considerando se o
aniversário já ocorreu no ano, e não é armazenada em uma coluna.

As validações usadas são:

- Nome obrigatório, entre 3 e 100 caracteres, com nome e sobrenome separados por espaço.
- CPF obrigatório com 11 números, sem formatação e com dígitos verificadores válidos.
- Rejeição de CPF com todos os números iguais.
- Apenas um cadastro por CPF.
- Data de nascimento preenchida e não futura.
- Idade mínima de 18 anos completos.
- E-mail opcional. Quando informado, precisa ter formato válido.

O e-mail é convertido para letras minúsculas e tem os espaços das extremidades
retirados. Se ficar vazio, é tratado como não informado.

A idade mínima de 18 anos é exigida tanto no cadastro quanto na edição.
Na edição, o serviço permite manter o CPF do próprio cliente, mas rejeita um
CPF já usado em outro cadastro.

## Consulta de clientes

A busca procura o texto informado dentro do nome, sem diferenciar letras
maiúsculas e minúsculas. Uma busca vazia lista todos os clientes.

A tabela mostra código, nome, CPF, nascimento, e-mail, idade e total em aberto.
O saldo soma somente as dívidas ainda não pagas. Clientes com saldo maior
aparecem primeiro. Quando os saldos são iguais, é mantida a ordem da consulta
por nome.

Cada página apresenta até 10 clientes. A última pode ter menos registros.
Os botões Anterior e Próxima são habilitados conforme a página atual.

## Dívidas e pagamentos

Cada dívida pertence a um cliente e contém código, valor, situação, data de
criação e data de pagamento. Ao cadastrar, a situação é em aberto e a data
de pagamento fica vazia. A criação é registrada automaticamente.

O valor precisa ser maior que zero, ter no máximo duas casas decimais e não
ultrapassar `9.999.999.999,99`. Um cliente pode ter histórico de várias dívidas,
mas apenas uma pode estar em aberto. A aplicação confere essa condição e o
banco também impede uma segunda dívida aberta.

Para pagar, é necessário selecionar a dívida e clicar em Registrar pagamento.
O serviço marca a situação como paga e preenche a data automaticamente.
Uma dívida paga não pode ser paga novamente. Depois do pagamento, o cliente
pode receber uma nova dívida.

O pagamento é integral; a versão atual não tem pagamento parcial. A dívida
paga permanece no histórico, mas deixa de fazer parte do saldo em aberto.
Os horários de criação e pagamento são gravados e exibidos em UTC, conforme
indicado nas colunas da tela.

## Exclusão

Na tela Excluir, o usuário seleciona o cliente, clica em Excluir e confirma
a operação no botão de confirmação. O banco remove também as dívidas desse
cliente, incluindo as já pagas. Essa exclusão é definitiva.

## Organização do código

O código está organizado da seguinte forma:

| Parte | Responsabilidade |
| --- | --- |
| `Vendinha/Model/Cliente.cs` | Dados do cliente, atributos de validação e cálculo da idade |
| `Vendinha/Model/Divida.cs` | Dados da dívida |
| `Vendinha/Contexts/VendinhaDbContext.cs` | Conexão com PostgreSQL e mapeamento de tabelas e colunas |
| `Vendinha/Services/ClienteService.cs` | Consultas, cadastro, edição, exclusão, CPF, idade mínima e saldo |
| `Vendinha/Services/DividaService.cs` | Histórico, criação de dívida e registro do pagamento |
| `Vendinha.Desktop/Form1.cs` | Menu inicial e abertura das telas |
| `Vendinha.Desktop/Screens` | Cadastro, listagem, dívidas e exclusão |

As telas ficam separadas dos arquivos `.Designer.cs`, que definem os controles.
Os eventos dos botões chamam os serviços. Os serviços validam os dados e usam
o contexto para consultar e salvar no banco.

As consultas usam `Where`, `OrderBy`, `ToList` e `FirstOrDefault`. O total é
calculado com `foreach`. A ordenação usa o negativo do saldo no `OrderBy` para
colocar o maior primeiro. A paginação usa um contador para separar as posições
da página dentro da lista.

Essa solução carrega os clientes em memória e faz consultas de saldo por
cliente. Para um volume grande de registros, essas consultas precisariam
ser revistas.

## Tabelas do banco

### clientes

| Coluna | Tipo no PostgreSQL | Uso |
| --- | --- | --- |
| codigo | integer, identidade e chave primária | Identificação gerada pelo banco |
| nome | varchar(100), obrigatório | Nome completo |
| cpf | varchar(11), obrigatório e único | CPF sem formatação |
| email | text, opcional | Contato |
| datanascimento | timestamp with time zone, obrigatório | Nascimento usado no cálculo da idade |

### dividas

| Coluna | Tipo no PostgreSQL | Uso |
| --- | --- | --- |
| codigo | integer, identidade e chave primária | Identificação da dívida |
| clientecodigo | integer, obrigatório e chave estrangeira | Cliente responsável |
| valor | numeric(12,2), obrigatório e positivo | Valor da dívida |
| paga | boolean, obrigatório | Situação de pagamento |
| datacriacao | timestamp with time zone, obrigatório | Momento do cadastro |
| datapagamento | timestamp with time zone, opcional | Momento do pagamento |

O arquivo `banco/schema.sql` cria as duas tabelas. A chave estrangeira usa
`ON DELETE CASCADE` para excluir as dívidas quando o cliente é removido.
O índice `uma_divida_em_aberto` impede dois registros não pagos para o mesmo
cliente. Uma restrição confere se a situação combina com a data de pagamento
e se o pagamento não é anterior à criação.
