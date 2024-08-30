using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DealerMasterCaculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conexion = new SqlConnection("server = MAXIMO;database=DealerLogin; integrated security=true");
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e) 
        {
            conexion.Open();
            string consulta = "SELECT * FROM inicio WHERE usuario= '" + txtusuario.Text + "' AND  contraseña= '" + txtcontrasena.Text + "'";
            SqlCommand comando = new SqlCommand(consulta,conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();
            if(lector.HasRows == true)
            {
                MessageBox.Show("Bienvenido señor "+ txtusuario.Text + "!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormRegister registro = new FormRegister();

            registro.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        
    }
}
