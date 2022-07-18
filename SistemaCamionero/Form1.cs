using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.SqlClient;

namespace SistemaCamionero
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Camionera;Integrated Security=True");
        private delegate void DelegadoAcceso(string accion);
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'camioneraDataSet.RegistroC' Puede moverla o quitarla según sea necesario.
            this.registroCTableAdapter.Fill(this.camioneraDataSet.RegistroC);
            Fecha.Text = DateTime.Now.ToString("d");
            ID.Text = "";
            Placas.Text = "";
            Neto.Text = "";
            Tara.Text = "";
            Bruto.Text = "";

            try
            {
                serialPort1 = new SerialPort("COM5", 9600, Parity.None, 8, StopBits.One);
                serialPort1.Handshake = Handshake.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
                serialPort1.Write("0P");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERROR");
            }
        }
        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (this.Enabled == false)
            {
                MessageBox.Show("Error de comunicación", "ERROR");
            }
            else {
                try
                {


                    //Thread.Sleep(500);
                    string data = serialPort1.ReadLine();

                    data = data.Replace("KG", "");
                    data = data.Replace("M", "");
                    string cadenaLimpia = data.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("", "").Replace(" ", "");


                    this.BeginInvoke(new DelegadoAcceso(si_DataReceived), new object[] { data });





                }
                catch (Exception)
                {

                    MessageBox.Show("El indicador no envia datos", "ERROR");
                }

            }
            
        }
        private void si_DataReceived(string accion)
        {
            Indicador.Text = accion;
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string v = DateTime.Now.ToString("T");
            Hora.Text = v;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ID.Text == String.Empty || Placas.Text == String.Empty)
            {
                MessageBox.Show("El campo ID  o Placas esta vacio", "Advertencia");
            }
            else
            {
                try
                {
                    string cadena = Indicador.Text;
                    String cadena2;
                    cadena = cadena.Replace("KG", "");
                    cadena2 = cadena.Replace("M", "");
                    string cadenaLimpia = cadena2.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("", "").Replace(" ", "");
                    int tara = Int32.Parse(cadenaLimpia);
                    registroCTableAdapter.Entrada(ID.Text, Placas.Text, tara);
                    this.registroCTableAdapter.Fill(this.camioneraDataSet.RegistroC);
                }
                catch (System.Data.SqlClient.SqlException)
                {

                    MessageBox.Show("ID duplicado", "ERROR");
                }
            }

                        
        }

        private void Salida_Click(object sender, EventArgs e)
        {
            if (ID.Text == String.Empty)
            {
                MessageBox.Show("Campo ID vacio, favor de llenar el campo para realizar la salida", "Advertencia");
            }
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
            string cadena = Indicador.Text;
            String cadena2;
            cadena = cadena.Replace("KG", "");
            cadena2 = cadena.Replace("M", "");
            string cadenaLimpia = cadena2.Replace("\n", string.Empty).Replace("\t", string.Empty).Replace("", "").Replace(" ", "");
            int B = Int32.Parse(cadenaLimpia);
            int T = Int32.Parse(Tara.Text);
            int N = B - T;
            Bruto.Text = B.ToString();
            Neto.Text = N.ToString();
            registroCTableAdapter.Salida(N, B, ID.Text, ID.Text);
            this.registroCTableAdapter.Fill(this.camioneraDataSet.RegistroC);


            

        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        { }

        private void button1_Click_1(object sender, EventArgs e)
        {

            SqlCommand comando = new SqlCommand("SELECT * FROM RegistroC WHERE ID = @ID", conexion);
            comando.Parameters.AddWithValue("@ID", ID.Text);
            conexion.Open();
            SqlDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                Tara.Text = registro["PTara"].ToString();
                Bruto.Text = registro["PBruto"].ToString();
                Neto.Text = registro["PNeto"].ToString();
            }
            else 
            {
                MessageBox.Show("ID no encontrado", "Advertencia");
            }
            conexion.Close();
            Placas.Text = "";
         }
        }
    }


