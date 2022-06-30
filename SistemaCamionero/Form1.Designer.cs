namespace SistemaCamionero
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Placas = new System.Windows.Forms.TextBox();
            this.registroCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camioneraDataSet = new SistemaCamionero.CamioneraDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.Salida = new System.Windows.Forms.Button();
            this.Entrada = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placasCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.Bruto = new System.Windows.Forms.TextBox();
            this.Tara = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Neto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Hora = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.registroCTableAdapter = new SistemaCamionero.CamioneraDataSetTableAdapters.RegistroCTableAdapter();
            this.Indicador = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(122, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Gestionado de Peso Tracto";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(433, 55);
            this.label3.TabIndex = 3;
            this.label3.Text = "Registro Camiones";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Placas);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Salida);
            this.panel1.Controls.Add(this.Entrada);
            this.panel1.Controls.Add(this.ID);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(49, 201);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(574, 160);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Placas
            // 
            this.Placas.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroCBindingSource, "PlacasC", true));
            this.Placas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placas.Location = new System.Drawing.Point(106, 77);
            this.Placas.Name = "Placas";
            this.Placas.Size = new System.Drawing.Size(100, 31);
            this.Placas.TabIndex = 5;
            // 
            // registroCBindingSource
            // 
            this.registroCBindingSource.DataMember = "RegistroC";
            this.registroCBindingSource.DataSource = this.camioneraDataSet;
            // 
            // camioneraDataSet
            // 
            this.camioneraDataSet.DataSetName = "CamioneraDataSet";
            this.camioneraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Placas ";
            // 
            // Salida
            // 
            this.Salida.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salida.Location = new System.Drawing.Point(367, 22);
            this.Salida.Name = "Salida";
            this.Salida.Size = new System.Drawing.Size(101, 36);
            this.Salida.TabIndex = 3;
            this.Salida.Text = "Salida";
            this.Salida.UseVisualStyleBackColor = true;
            this.Salida.Click += new System.EventHandler(this.Salida_Click);
            // 
            // Entrada
            // 
            this.Entrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Entrada.Location = new System.Drawing.Point(248, 22);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(101, 36);
            this.Entrada.TabIndex = 2;
            this.Entrada.Text = "Entrada";
            this.Entrada.UseVisualStyleBackColor = true;
            this.Entrada.Click += new System.EventHandler(this.button1_Click);
            // 
            // ID
            // 
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroCBindingSource, "ID", true));
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(108, 25);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(100, 31);
            this.ID.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "ID";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaCamionero.Properties.Resources.istockphoto_1127759852_170667a_modified;
            this.pictureBox1.Location = new System.Drawing.Point(990, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.placasCDataGridViewTextBoxColumn,
            this.pTaraDataGridViewTextBoxColumn,
            this.pNetoDataGridViewTextBoxColumn,
            this.pBrutoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registroCBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(62, 400);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1092, 248);
            this.dataGridView1.TabIndex = 5;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // placasCDataGridViewTextBoxColumn
            // 
            this.placasCDataGridViewTextBoxColumn.DataPropertyName = "PlacasC";
            this.placasCDataGridViewTextBoxColumn.HeaderText = "PlacasC";
            this.placasCDataGridViewTextBoxColumn.Name = "placasCDataGridViewTextBoxColumn";
            // 
            // pTaraDataGridViewTextBoxColumn
            // 
            this.pTaraDataGridViewTextBoxColumn.DataPropertyName = "PTara";
            this.pTaraDataGridViewTextBoxColumn.HeaderText = "PTara";
            this.pTaraDataGridViewTextBoxColumn.Name = "pTaraDataGridViewTextBoxColumn";
            // 
            // pNetoDataGridViewTextBoxColumn
            // 
            this.pNetoDataGridViewTextBoxColumn.DataPropertyName = "PNeto";
            this.pNetoDataGridViewTextBoxColumn.HeaderText = "PNeto";
            this.pNetoDataGridViewTextBoxColumn.Name = "pNetoDataGridViewTextBoxColumn";
            // 
            // pBrutoDataGridViewTextBoxColumn
            // 
            this.pBrutoDataGridViewTextBoxColumn.DataPropertyName = "PBruto";
            this.pBrutoDataGridViewTextBoxColumn.HeaderText = "PBruto";
            this.pBrutoDataGridViewTextBoxColumn.Name = "pBrutoDataGridViewTextBoxColumn";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1226, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "BRUTO";
            // 
            // Bruto
            // 
            this.Bruto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroCBindingSource, "PBruto", true));
            this.Bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bruto.Location = new System.Drawing.Point(1208, 207);
            this.Bruto.Name = "Bruto";
            this.Bruto.Size = new System.Drawing.Size(125, 31);
            this.Bruto.TabIndex = 7;
            // 
            // Tara
            // 
            this.Tara.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroCBindingSource, "PTara", true));
            this.Tara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tara.Location = new System.Drawing.Point(1208, 285);
            this.Tara.Name = "Tara";
            this.Tara.Size = new System.Drawing.Size(125, 31);
            this.Tara.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1233, 250);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "TARA";
            // 
            // Neto
            // 
            this.Neto.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.registroCBindingSource, "PNeto", true));
            this.Neto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neto.Location = new System.Drawing.Point(1208, 370);
            this.Neto.Name = "Neto";
            this.Neto.Size = new System.Drawing.Size(125, 31);
            this.Neto.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1231, 335);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 25);
            this.label8.TabIndex = 10;
            this.label8.Text = "NETO";
            // 
            // Hora
            // 
            this.Hora.AutoSize = true;
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(1203, 61);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(84, 25);
            this.Hora.TabIndex = 13;
            this.Hora.Text = "HH:MM";
            // 
            // Fecha
            // 
            this.Fecha.AutoSize = true;
            this.Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fecha.Location = new System.Drawing.Point(1203, 31);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(118, 25);
            this.Fecha.TabIndex = 14;
            this.Fecha.Text = "DD/MM/AA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // registroCTableAdapter
            // 
            this.registroCTableAdapter.ClearBeforeFill = true;
            // 
            // Indicador
            // 
            this.Indicador.AutoSize = true;
            this.Indicador.Font = new System.Drawing.Font("digital display tfb", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Indicador.Location = new System.Drawing.Point(652, 207);
            this.Indicador.Name = "Indicador";
            this.Indicador.Size = new System.Drawing.Size(323, 125);
            this.Indicador.TabIndex = 15;
            this.Indicador.Text = "000000";
            this.Indicador.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(367, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("digital display tfb", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1008, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 125);
            this.label2.TabIndex = 16;
            this.label2.Text = "KG";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1350, 749);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Indicador);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Neto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Tara);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Bruto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Camionero";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Entrada;
        private System.Windows.Forms.Button Salida;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox Placas;
        private System.Windows.Forms.Label label5;
        private CamioneraDataSet camioneraDataSet;
        private System.Windows.Forms.BindingSource registroCBindingSource;
        private CamioneraDataSetTableAdapters.RegistroCTableAdapter registroCTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placasCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBrutoDataGridViewTextBoxColumn;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Bruto;
        private System.Windows.Forms.TextBox Tara;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Neto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.Label Fecha;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Indicador;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}

