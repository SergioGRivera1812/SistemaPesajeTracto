using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCamionero
{
    public partial class ReImpresion : Form
    {
        SqlConnection conexion = new SqlConnection("Data Source=.;Initial Catalog=Camionera;Integrated Security=True");
        public ReImpresion()
        {
            InitializeComponent();
        }

        private void ReImpresion_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'camioneraDataSetFinal.RegistroC' Puede moverla o quitarla según sea necesario.
            this.registroCTableAdapter1.Fill(this.camioneraDataSetFinal.RegistroC);
            // TODO: esta línea de código carga datos en la tabla 'camioneraDataSet.RegistroC' Puede moverla o quitarla según sea necesario.
            this.registroCTableAdapter.Fill(this.camioneraDataSet.RegistroC);
            

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
                Placas.Text = Pl;
                Tara.Text = PT;
                textFecha.Text = Fech;
                textHE.Text = HoraE;
                textHS.Text = HoraS;
                Neto.Text = PN;
                Bruto.Text = PB;


            }
            catch (System.ArgumentOutOfRangeException)
            {

                MessageBox.Show("Favor de seleccionar la primera columna para continuar", "AVISO");
            }

        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (dataGridView1.Rows.Count > 0) 
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
                conexion.Close();


            }
            else if(dataGridView1.Rows.Count <= 0)
            {
                MessageBox.Show("ID no encontrado", "ADVERTENCIA");
                textFiltrar.Text = "";

                conexion.Open();

                SqlCommand cmd = conexion.CreateCommand();

                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM RegistroC where ID like ('" + textFiltrar.Text + "%')";
                cmd.ExecuteNonQuery();

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);

                dataGridView1.DataSource = dt;
                conexion.Close();


            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Favor de llenar los campos para poder continuar", "AVISO");
            }
            else
            {
                printDocument1 = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printDocument1.PrinterSettings = ps;
                printDocument1.PrintPage += Imprimir;
                printDocument1.Print();
            }
        }
        private void Imprimir(object sender, PrintPageEventArgs e)
        {
            Form1 f = new Form1();
            string Fech = textFecha.Text, HE = textHE.Text, HS = textHS.Text;

            string i = ID.Text, P = Placas.Text, T = Tara.Text, B = Bruto.Text, N = Neto.Text;
            Font font = new Font("Arial", 12, FontStyle.Regular, GraphicsUnit.Point);
            int width = 600;

            e.Graphics.DrawString("Sistema de Pesaje Tracto", font, Brushes.Black, new RectangleF(10, 20, width, 20));
            e.Graphics.DrawString("Fecha:  " + Fech, font, Brushes.Black, new RectangleF(10, 60, width, 20));
            e.Graphics.DrawString("Hora Entrada:  " + HE, font, Brushes.Black, new RectangleF(10, 80, width, 20));
            e.Graphics.DrawString("ID Camion  " + i, font, Brushes.Black, new RectangleF(10, 100, width, 20));
            e.Graphics.DrawString("Placas:  " + P, font, Brushes.Black, new RectangleF(10, 120, width, 20));
            e.Graphics.DrawString("Peso de Entrada:  " + T + "Kg", font, Brushes.Black, new RectangleF(10, 140, width, 20));
            e.Graphics.DrawString("-----------------------------------------", font, Brushes.Black, new RectangleF(10, 180, width, 20));
            e.Graphics.DrawString("Fecha:  " + Fech, font, Brushes.Black, new RectangleF(10, 200, width, 20));
            e.Graphics.DrawString("Hora Salida:  " + HS, font, Brushes.Black, new RectangleF(10, 220, width, 20));
            e.Graphics.DrawString("Peso Bruto:  " + B +"Kg", font, Brushes.Black, new RectangleF(10, 240, width, 20));
            e.Graphics.DrawString("Peso de Salida:  " + N +"Kg", font, Brushes.Black, new RectangleF(10, 260, width, 20));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
