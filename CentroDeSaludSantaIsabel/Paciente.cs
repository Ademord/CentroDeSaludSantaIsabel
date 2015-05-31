using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace CentroDeSaludSantaIsabel
{
    public partial class Paciente : Form
    {
        public Paciente()
        {
            InitializeComponent();
        }

        private void Paciente_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var conn = new NpgsqlConnection("Host=localhost; User=centrosalud; Password=cisco");
            conn.Open();

            var nombre = textBox_Nombre.Text;
            var apellidoP = textBox_ApellidoPat.Text;
            var apellidoM = textBox_ApellidoMat.Text;
            
            //agregar
            //try {
                var cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO paciente (nombre, apellido_p, apellido_m) VALUES (@nombre, @apellidoP, @apellidoM);";
                cmd.Parameters.AddWithValue("nombre", nombre);
                cmd.Parameters.AddWithValue("apellidoP", apellidoP);
                cmd.Parameters.AddWithValue("apellidoM", apellidoM);
                var reader = cmd.ExecuteReader();
                reader.Read();

                MessageBox.Show("Paciente agregado exitosamente!");
            /**
            } 
            catch (Exception _error) {
                System.Console.Write(_error.ToString());
                MessageBox.Show("Paciente ya existe.");
            }
             **/
        }

        
    }
}
