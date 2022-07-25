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
using System.Drawing.Printing;
using SistemaCamionero.Properties;

namespace SistemaCamionero
{
    public partial class Form1 : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Camionera;Integrated Security=True");
        private delegate void DelegadoAcceso(string accion);
        public Form1()
        {
            InitializeComponent();
            // dataGridView1.Columns["ID"].SortMode = DataGridViewColumnSortMode.NotSortable;
            
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'camioneraDataSetFinal.RegistroC' Puede moverla o quitarla según sea necesario.
            this.registroCTableAdapter1.Fill(this.camioneraDataSetFinal.RegistroC);
            // TODO: esta línea de código carga datos en la tabla 'camioneraDataSet.RegistroC' Puede moverla o quitarla según sea necesario.
            this.registroCTableAdapter.Fill(this.camioneraDataSet.RegistroC);
            Fecha.Text = DateTime.Now.ToString("d");
            ID.Text = "";
            Placas.Text = "";
            Neto.Text = "";
            Tara.Text = "";
            Bruto.Text = "";
            Configuracion c = new Configuracion();
            c.Configuracion_Load(sender, e);
            string P = c.textPuerto.Text;
            Settings.Default.Puerto = P;
            string B = c.textBaudio.Text;
            Settings.Default.Baudio = B;
            int Bau = Int32.Parse(B);

            

            try
            {
                serialPort1 = new SerialPort(P, Bau, Parity.None, 8, StopBits.One);
                serialPort1.Handshake = Handshake.None;
                serialPort1.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                serialPort1.ReadTimeout = 500;
                serialPort1.WriteTimeout = 500;
                serialPort1.Open();
                serialPort1.Write("P");
                
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
            string v = DateTime.Now.ToString("t");
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
                    registroCTableAdapter1.Entrada(ID.Text, Placas.Text, tara, Fecha.Text, Hora.Text);
                    this.registroCTableAdapter1.Fill(this.camioneraDataSetFinal.RegistroC);
                    Placas.Text = "";
                    ID.Text = "";
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
            registroCTableAdapter1.Salida(Hora.Text, B, N, textFiltrar.Text, textFiltrar.Text);
            //checkTicket.Checked = false;
            //textFiltrar.Text = string.Empty;
            this.registroCTableAdapter1.Fill(this.camioneraDataSetFinal.RegistroC);
            //this.textFiltrar.Text = "";
            
            
            printDocument1 = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += Imprimir;
            printDocument1.Print();
            


        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            string i = ID.Text, P = Placas.Text, T = Tara.Text, B = Bruto.Text, N = Neto.Text, f = Fecha.Text, h = Hora.Text;
            Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            int width = 600;
            
            e.Graphics.DrawString("Sistema de Pesaje Tracto", font, Brushes.Black, new RectangleF(10, 20, width, 20));
            e.Graphics.DrawString("ID Camion  " + i, font, Brushes.Black, new RectangleF(10, 60, width, 20));
            e.Graphics.DrawString("Fecha:  " + f, font, Brushes.Black, new RectangleF(10, 80, width, 20));
            e.Graphics.DrawString("Hora Entrada:  " + h, font, Brushes.Black, new RectangleF(170, 80, width, 20));
            e.Graphics.DrawString("Peso de Entrada:  " + T + "Kg", font, Brushes.Black, new RectangleF(10, 100, width, 20));
            e.Graphics.DrawString("Placas:  " + P, font, Brushes.Black, new RectangleF(10, 120, width, 20));
            e.Graphics.DrawString("-----------------------------------------", font, Brushes.Black, new RectangleF(10, 160, width, 20));
            e.Graphics.DrawString("Hora Salida:  "+ h, font, Brushes.Black, new RectangleF(10, 200, width, 20));
            e.Graphics.DrawString("Peso Salida:  " + N, font, Brushes.Black, new RectangleF(10, 220, width, 20));
            e.Graphics.DrawString("Peso Gross:  " + B +"Kg", font, Brushes.Black, new RectangleF(190, 220, width, 20));
            

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
            //Placas.Text = "";
            this.Placas.Text = "";
            this.Tara.Text = "";
            this.Neto.Text = "";
            this.Bruto.Text = "";

        }

        private void checkTicket_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTicket.Checked)
            {
                textFiltrar.Visible = true;
            }else
            {
                textFiltrar.Visible = false;
                ID.Text = "";


            }
        }

        private void textFiltrar_KeyUp(object sender, KeyEventArgs e)
        {
            conexion.Open();

            SqlCommand cmd = conexion.CreateCommand();

            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM RegistroC where ID like ('" + textFiltrar.Text + "%')";
            cmd.ExecuteNonQuery();

             DataTable dt = new DataTable();
             SqlDataAdapter da = new SqlDataAdapter(cmd);

             da.Fill(dt);

             dataGridView1.DataSource = dt;
            //SqlDataReader registro = cmd.ExecuteReader();
            //this.registroCTableAdapter1.Fill(this.camioneraDataSetFinal.RegistroC);




            conexion.Close();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string Pl = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string PT = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string Fech = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string HoraE = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                string HoraS = this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                string PB = this.dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
                string PN = this.dataGridView1.SelectedRows[0].Cells[7].Value.ToString();

                ID.Text = id;
                textFiltrar.Text = id;
                Placas.Text = Pl;
                Tara.Text = PT;
                Neto.Text = PN;
                Bruto.Text = PB;


            }
            catch (System.ArgumentOutOfRangeException)
            {

                MessageBox.Show("Favor de seleccionar la primera columna para continuar", "AVISO");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void reImpresiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReImpresion R = new ReImpresion();
            R.Show();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            ID.Text = "";
            Placas.Text = "";
            Tara.Text = "";
            Bruto.Text = "";
            Neto.Text = "";
            textFiltrar.Text = "";
        }

        private void configuraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Configuracion c = new Configuracion();
            c.Show();
        }
    }
    }


