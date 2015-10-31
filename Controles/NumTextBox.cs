using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class NumTextBox : TextBox
    {
        public NumTextBox()
        {
            InitializeComponent();
        }

        private void NumTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
            }
            else if (char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }


    }
}
