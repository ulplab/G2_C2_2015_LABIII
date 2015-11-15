using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Controles
{
    public partial class usPie : UserControl
    {
        public usPie()
        {
            InitializeComponent();
            lblFecha.Text = Convert.ToString(DateTime.Now.ToShortDateString());
            lblHora.Text = Convert.ToString(DateTime.Now.ToShortTimeString());
        }

        string usuario;

        public string Usuario
        {
            get { return usuario; }
            set 
            { 
                usuario = value;
                lblUsuario.Text = usuario;
            }
        }

        Color fontColor;

        public Color FontColor
        {
            get { return fontColor; }
            set 
            {
                fontColor = value;
                lblTituloFecha.ForeColor = fontColor;
                lblTituloHora.ForeColor = fontColor;
                lblTituloUsuario.ForeColor = fontColor;
                lblTituloTiempo.ForeColor = fontColor;
                lblFecha.ForeColor = fontColor;
                lblHora.ForeColor = fontColor;
                lblHoras.ForeColor = fontColor;
                lblMinutos.ForeColor = fontColor;
                lblSegundos.ForeColor = fontColor;
                lblSeparadorHoras.ForeColor = fontColor;
                lblSeparadorMinutos.ForeColor = fontColor;
                lblUsuario.ForeColor = fontColor;
                lblMinutos.ForeColor = fontColor;
            }
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblSegundos.Text) >= 0 && Convert.ToInt32(lblSegundos.Text) < 9)
            {
                lblSegundos.Text = "0" + Convert.ToString(Convert.ToInt32(lblSegundos.Text) + 1);
            }
            else if (Convert.ToInt32(lblSegundos.Text) == 59)
            {
                lblSegundos.Text = "00";
                if (Convert.ToInt32(lblMinutos.Text) >= 0 && Convert.ToInt32(lblMinutos.Text) <= 9)
                {
                    lblMinutos.Text = "0" + Convert.ToString(Convert.ToInt32(lblMinutos.Text) + 1);
                }
                else if (Convert.ToInt32(lblMinutos.Text) == 59)
                {
                    lblMinutos.Text = "00";
                    if (Convert.ToInt32(lblHoras.Text) >= 0 && Convert.ToInt32(lblHoras.Text) <= 9)
                    {
                        lblHoras.Text = "0" + Convert.ToString(Convert.ToInt32(lblHoras.Text) + 1);
                    }
                    else if (Convert.ToInt32(lblHoras.Text) == 59)
                    {
                        lblHoras.Text = "00";
                    }
                    else
                    {
                        lblHoras.Text = Convert.ToString(Convert.ToInt32(lblHoras.Text) + 1);
                    }
                }
                else
                {
                    lblMinutos.Text = Convert.ToString(Convert.ToInt32(lblMinutos.Text) + 1);
                }
            }
            else
            {
                lblSegundos.Text = Convert.ToString(Convert.ToInt32(lblSegundos.Text) + 1);
            }
        }


    }
}
