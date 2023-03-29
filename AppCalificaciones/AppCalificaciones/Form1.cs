using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_calificacion;

namespace AppCalificaciones
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double N1, N2, N3, N4;
            string Nombre, Identificacion;
            Nombre = txtNombre.Text;
            Identificacion = txtIdentificacion.Text;
            try
            {
                N1 = Convert.ToDouble(txtN1.Text);
                N2 = Convert.ToDouble(txtN2.Text);
                N3 = Convert.ToDouble(txtN3.Text);
                N4 = Convert.ToDouble(txtN4.Text);

                Calificacion ObjCalificacion = new Calificacion();
                ObjCalificacion.SETN1 = N1;
                ObjCalificacion.SETN2 = N2;
                ObjCalificacion.SETN3 = N3;
                ObjCalificacion.SETN4 = N4;
                ObjCalificacion.SETNombre = Nombre;
                ObjCalificacion.SETIdentificacion = Identificacion;
                if (ObjCalificacion.Calcular())
                {
                    txtPromedio.Text = ObjCalificacion.GETPromedio.ToString();
                    return;
                }
                else
                {
                    MessageBox.Show(ObjCalificacion.GETError);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ingresado un caracter inválido");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

