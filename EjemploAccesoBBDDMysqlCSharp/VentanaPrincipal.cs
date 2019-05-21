using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EjemploAccesoBBDDMysqlCSharp
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
            rellenaComboPelis();
            rellenaComboUsuario();
            CenterToScreen();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            Application.Exit();

        }

        //Método que rellena el comboBox de los títulos de las pelis
        // Basado en un trabajo de Jose Ignacio Navas Sanz  (J)
        private void rellenaComboPelis()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM movies ORDER BY name ;", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();

            //Mientras vaya leyendo resultados, va metiéndolos al comboBox
            //Además, separa los valores por medio de guiones
            while (resultado.Read())
            {
                String id = resultado.GetString(0);
                String name = resultado.GetString("name");
                String year = resultado.GetString(2);
                String rank = "";
                if (!resultado.IsDBNull(3)) { rank = resultado.GetString(3); }
                desplegableTitulos.Items.Add(id + "-" + name + "-" + year + "-" + rank);
            }
            conexion.Close();
        }

        private void rellenaComboUsuario()
        {
            MySqlConnection conexion = new ConexionBBDD().conecta();
            MySqlCommand comando = new MySqlCommand("SELECT * FROM usuario ORDER BY DNI ;", conexion);
            MySqlDataReader resultado = comando.ExecuteReader();

            //Mientras vaya leyendo resultados, va metiéndolos al comboBox
            //Además, separa los valores por medio de guiones
            while (resultado.Read())
            {

                desplegableDNIs.Items.Add(    resultado.GetString("DNI") + "-" 
                                            + resultado.GetString("Nombre") + "-" 
                                            + resultado.GetString("Apellido")  );
            }
            conexion.Close();
        }

        private void desplegableDNIs_SelectedIndexChanged(object sender, EventArgs e)
        {
            String aux = desplegableDNIs.SelectedItem.ToString();
            String dniSeleccionado = aux.Substring(0, aux.IndexOf("-"));
            //Console.WriteLine(dniSeleccionado);
            
            try
            {
                pictureBox1.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\imagenes\" + dniSeleccionado + ".jpg");
            }
            catch 
            {
                pictureBox1.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + @"\Resources\imagenes\noimage.jpg");

            }

        }
    }
}
