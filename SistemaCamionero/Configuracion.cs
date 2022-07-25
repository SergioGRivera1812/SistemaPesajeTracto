using SistemaCamionero.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaCamionero
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
            
        }

        public void Configuracion_Load(object sender, EventArgs e)
        {
            CargarConf();
        }
        public void CargarConf()
        {
            textPuerto.Text = Settings.Default.Puerto;
            textBaudio.Text = Settings.Default.Baudio;


        }

        public void RestablecerConfig()
        {
            Settings.Default.Reset();
            CargarConf();
            MessageBox.Show("Se han Restablecido correctamente");
        }

        public void GuardarConfig()
        {
             
            Settings.Default.Puerto = textPuerto.Text;
            Settings.Default.Baudio = textBaudio.Text;
            Settings.Default.Save();
            MessageBox.Show("Se han guardado los cambios correctamente","AVISO");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GuardarConfig();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RestablecerConfig();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            MessageBox.Show("Para efectuar los cambios favor de reiniciar la aplicación", "AVISO");
        }

        private void Configuracion_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Puerto = textPuerto.Text;
            Settings.Default.Baudio = textBaudio.Text;
            Settings.Default.Save();
        }
    }
}
