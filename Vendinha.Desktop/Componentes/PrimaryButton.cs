using System;
using System.Collections.Generic;
using System.Text;
using Vendinha.Desktop.Screens;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Vendinha.Desktop.Componentes
{
    public partial class PrimaryButton : Button
    {
        public override Color BackColor
        {
            get => base.BackColor; set => base.BackColor = value;
        }
        public PrimaryButton()
        {
            BackColor = Color.DarkBlue;
            Font = new Font("Arial", 12);
            Size = new Size(250, 60);
            ForeColor = Color.White;

        }
    }

}



