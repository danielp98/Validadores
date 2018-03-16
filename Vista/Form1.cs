using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string mensajev = "";
            string mensajenv = "";
            Datos.Validador o = new Datos.Validador();
            if (txtEntero.Text.Equals("")) {
                mensajenv += "\nEntero";
            }
            else if (o.esEntero(txtEntero.Text))
            {
                mensajev += "\nEntero";
            }
            else
            {
                mensajenv += "\nEntero";
            }

            if (txtDecimal.Text.Equals(""))
            {
                mensajenv += "\nDecimal";
            }
            else if (o.esDecimal(txtDecimal.Text)){
                mensajev += "\nDecimal";
            }
            else
            {
                mensajenv += "\nDecimal";
            }

            if (txtEdad.Text.Equals(""))
            {
                mensajenv += "\nEdad";
            }
            else if (o.esEdad(txtEdad.Text))
            {
                mensajev += "\nEdad";
            }
            else
            {
                mensajenv += "\nEdad";
            }

            MessageBox.Show("Validos:\n" + mensajev + "\nInvalidos:\n" + mensajenv);
            
        }
    }
}
