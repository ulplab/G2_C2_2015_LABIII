﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class usHeader : UserControl
    {
        public usHeader(Form formu)
        {
            InitializeComponent();
            formulario = formu;
        }

        private Point Coordenadas;
        private bool EventoMouseDown = false;
        public delegate void delHeader();
        public event delHeader evCerrar;

        Form formulario;

        public Form Formulario
        {
            get { return formulario; }
            set { formulario = value; }
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            formulario.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            if (formulario.WindowState == FormWindowState.Maximized)
            {
                formulario.WindowState = FormWindowState.Normal;
            }
            else
            {
                formulario.WindowState = FormWindowState.Maximized;
            }
        }

        private void pnlTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            int Horizontal, Vertical;

            if (e.Button == MouseButtons.Left)
            {
                if (sender is Label)
                {
                    Horizontal = -e.X - SystemInformation.FrameBorderSize.Width - 24;
                    Vertical = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height + 6;
                    Coordenadas = new Point(Horizontal, Vertical);
                    EventoMouseDown = true;
                }
                else
                {
                    Horizontal = -e.X - SystemInformation.FrameBorderSize.Width + 7;
                    Vertical = -e.Y - SystemInformation.CaptionHeight - SystemInformation.FrameBorderSize.Height + 31;
                    Coordenadas = new Point(Horizontal, Vertical);
                    EventoMouseDown = true;
                }
            }
        }

        private void pnlTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            if (EventoMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(Coordenadas.X, Coordenadas.Y);
                Location = mousePos;
            }
        }

        private void pnlTitulo_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                EventoMouseDown = false;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (evCerrar != null)
            {
                evCerrar();
            }
        }

        private void btnMinimizar_MouseEnter(object sender, EventArgs e)
        {
            try
            {

                if ((sender as Button).Name == "btnMinimizar")
                {
                    btnMinimizar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Minimizar-48x48.png");
                }
                else if ((sender as Button).Name == "btnMaximizar")
                {
                    btnMaximizar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Maximizar-48x48.png");
                }
                else
                {
                    btnCerrar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Cerrar-48x48.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }

        private void btnMinimizar_MouseLeave(object sender, EventArgs e)
        {
            try
            {
                if ((sender as Button).Name == "btnMinimizar")
                {
                    btnMinimizar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Minimizar-32x32.png");
                }
                else if ((sender as Button).Name == "btnMaximizar")
                {
                    btnMaximizar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Maximizar-32x32.png");
                }
                else
                {
                    btnCerrar.Image = Image.FromFile(@"..\\..\\Imagenes\Iconos\Cerrar-32x32.png");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Iconos no encontrados");
            }
        }
    }
}