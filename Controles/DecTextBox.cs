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
    public partial class DecTextBox : TextBox
    {
        public DecTextBox()
        {
            InitializeComponent();
        }

        private void DecTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (e.KeyChar.ToString().Equals(",") && !ExiteComa(sender) && (sender as TextBox).Text != string.Empty)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private bool ExiteComa(object sender)
        {
            bool ret = false;
            string Cadena = (sender as TextBox).Text;
            foreach (char letra in Cadena)
            {
                if (letra == ',')
                {
                    ret = true;
                }
            }
            return ret;
        }


    }
}
