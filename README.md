# Vendinha

Sistema de cadastro de clientes e controle de dívidas de uma vendinha. Permite
registrar compras penduradas, consultar o saldo de cada cliente e marcar o pagamento.

## Tecnologias

- C# e .NET 10.
- Windows Forms para as telas.
- Entity Framework Core para acesso aos dados.
- PostgreSQL para armazenar os cadastros e as dívidas.

## O que é necessário

- Windows.
- Visual Studio com suporte ao .NET 10 e a opção de desenvolvimento para desktop
  com .NET instalada.
- SDK do .NET 10.
- PostgreSQL instalado e em execução. A configuração usada no trabalho é a versão 18.
- pgAdmin para criar o banco e executar o script.
- Internet na primeira restauração dos pacotes NuGet.

## Preparar o banco

1. Abra o pgAdmin e conecte ao PostgreSQL.
2. Clique com o botão direito em **Databases > Create > Database**.
3. Crie o banco com o nome `vendinha` e proprietário `postgres`.
4. Clique com o botão direito no banco `vendinha` e abra **Query Tool**.
5. Abra o arquivo `banco/schema.sql` e execute o script inteiro.

O script deve ser executado uma vez, em um banco vazio. Ele cria as tabelas
`clientes` e `dividas`, com as regras de CPF único e uma dívida em aberto por cliente.
Se as tabelas já foram criadas, não é necessário executar novamente.

## Configurar a conexão

No projeto `Vendinha`, abra `Services/ClienteService.cs` e localize a constante
`ConnectionString`:

```csharp
public const string ConnectionString =
    "Server=localhost;Port=5432;Database=vendinha;User Id=postgres;Password=SUA_SENHA;";
```

Substitua `SUA_SENHA` pela senha definida na instalação do PostgreSQL. Ajuste
servidor, porta, banco e usuário se a sua instalação usar outros valores.
Os dois serviços usam essa conexão. Antes de publicar o código, retire a senha real.

## Executar no Visual Studio

1. Abra o arquivo `Vendinha.slnx`.
2. Clique com o botão direito na solução e escolha **Restaurar Pacotes NuGet**.
3. Defina `Vendinha.Desktop` como projeto de inicialização.
4. Com o banco configurado, execute com **F5**.

Os pacotes já estão declarados em `Vendinha/Vendinha.csproj`:

| Pacote | Versão |
| --- | --- |
| Microsoft.EntityFrameworkCore | 10.0.13 |
| Npgsql | 10.0.3 |
| Npgsql.EntityFrameworkCore.PostgreSQL | 10.0.3 |

## Usar o sistema

- **Cadastrar:** informe CPF, nome completo e nascimento. O e-mail é opcional.
  O cliente deve ter pelo menos 18 anos.
- **Listar:** consulte os clientes, pesquise por parte do nome e use os botões
  Anterior e Próxima para mudar de página.
- **Editar cliente:** selecione uma linha na listagem para alterar os dados.
- **Dívidas:** selecione um cliente na listagem para consultar seu histórico
  ou cadastrar uma dívida.
- **Registrar pagamento:** selecione a dívida para marcar o pagamento integral.
- **Excluir:** selecione o cliente na tela de exclusão e confirme a operação.
  O cadastro e todas as suas dívidas serão apagados.

O CPF deve ter 11 números, sem pontos ou traço. Para valores, use o formato
numérico do Windows; em português, por exemplo, `25,50`.

## Documentação

As regras, as tabelas e a organização do código estão em
[DOCUMENTACAO.md](DOCUMENTACAO.md).
