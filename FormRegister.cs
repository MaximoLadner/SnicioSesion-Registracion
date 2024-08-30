using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DealerMasterCaculator
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void FormRegister_Load(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;
            string fechaNacimiento = txtfechanacimiento.Text;
            string correo = txtcorreo.Text;
            string contrasenia = txtcontrasena.Text;

            if (nombre == "" || correo == "" || fechaNacimiento == "" || fechaNacimiento == "")
            {
                MessageBox.Show("Debe completar todos los campos");
            }
            else
            {
                usuarioNuevo nuevoContacto = new usuarioNuevo(0, nombre, correo, fechaNacimiento, contrasenia);
                int fila = nuevoContacto.AgregarContacto();
                if (fila == 1)
                {
                    MessageBox.Show("El registro se agrego correctamente",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtnombre.Text = "";
                    txtcorreo.Text = "";
                    txtfechanacimiento.Text = "";
                    txtcontrasena.Text = "";
                    this.Close();
                    Form1 inicio = new Form1();
                    inicio.ShowDialog();
                    
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al agregar el registro",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }


        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Form1 inicio = new Form1();

            inicio.ShowDialog();

            this.Close();
        }

        
    }
    
}
