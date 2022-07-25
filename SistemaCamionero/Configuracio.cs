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
    public partial class Configuracio : Form1
    {
        public Configuracio()
        {
            InitializeComponent();
        }

        private void Configuracio_Load(object sender, EventArgs e)
        {

        }
        private void CargarConf()
        {
            textPuerto.Text = Settings.Default.Puerto;
            textBaudio.Text = Settings.Default.Baudio;


        }

        private void RestablecerConfig()
        {
            Settings.Default.Reset();
            CargarConf();
            MessageBox.Show("Se han Restablecido correctamente");
        }

        private void GuardarConfig()
        {
            Settings.Default.Puerto = textPuerto.Text;
            textBaudio.Text = Settings.Default.Baudio;
            Settings.Default.Save();
            MessageBox.Show("Se han guardado los cambios correctamente");
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            GuardarConfig();
        }
    }
}
