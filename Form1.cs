using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accesoMSQL
{
    public partial class Form1 : Form
    {
        static MySqlConnection Conex = new MySqlConnection();
        static string serv = "Server=localhost;";
        static string db = "Database=agenda;";
        static string usuario = "UID=root;";
        static string pwd = "pwd=admin";
        string CadenaDeConexion = serv + db + usuario + pwd;
        public void Conectar()
        {
            try
            {
                Conex.ConnectionString = CadenaDeConexion;
                Conex.Open();
                MessageBox.Show("La BD está ahora conectada");

            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al conectar a la BD");
                throw;
            }
        }
        public static void Desconectar()
        {
            Conex.Close();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void contactosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.contactosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.contactos' Puede moverla o quitarla según sea necesario.
            this.contactosTableAdapter.Fill(this.agendaDataSet.contactos);

        }

        private void insertar_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO contactos VALUES (@id_contactos, @nombre, @apellidos, @telefono, @direccion, @cp, @poblacion)" , Conex);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@id_contactos", id_contactosTextBox.Text);
                cmd.Parameters.AddWithValue("@nombre", nombreTextBox.Text);
                cmd.Parameters.AddWithValue("@apellidos", apellidosTextBox.Text);
                cmd.Parameters.AddWithValue("@telefono", telefonoTextBox.Text);
                cmd.Parameters.AddWithValue("@direccion", direccionTextBox.Text);
                cmd.Parameters.AddWithValue("@cp", cpTextBox.Text);
                cmd.Parameters.AddWithValue("@poblacion", poblacionTextBox.Text);

                //Conex.Open();
                Conectar();
                cmd.ExecuteNonQuery();
                Desconectar();
            }
        }

        private bool IsValid()
        {
            bool apto = true;
            if (id_contactosTextBox.Text == string.Empty 
                || nombreTextBox.Text == string.Empty
                || cpTextBox.Text == string.Empty
                || apellidosTextBox.Text == string.Empty
                || telefonoTextBox.Text == string.Empty
                || direccionTextBox.Text == string.Empty
                || poblacionTextBox.Text == string.Empty)
            {
                apto = false;
                MessageBox.Show("Faltan campos por completar");
            }
            return apto;
        }
    }
}
