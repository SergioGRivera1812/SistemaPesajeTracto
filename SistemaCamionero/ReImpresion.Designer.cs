namespace SistemaCamionero
{
    partial class ReImpresion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReImpresion));
            this.registroCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camioneraDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.camioneraDataSet = new SistemaCamionero.CamioneraDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.textFiltrar = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.registroCTableAdapter = new SistemaCamionero.CamioneraDataSetTableAdapters.RegistroCTableAdapter();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textHS = new System.Windows.Forms.TextBox();
            this.textHE = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Neto = new System.Windows.Forms.TextBox();
            this.Bruto = new System.Windows.Forms.TextBox();
            this.Tara = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Placas = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.registroCBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placasCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTaraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaSDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pBrutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pNetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroCBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.camioneraDataSetFinal = new SistemaCamionero.CamioneraDataSetFinal();
            this.registroCTableAdapter1 = new SistemaCamionero.CamioneraDataSetFinalTableAdapters.RegistroCTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSetFinal)).BeginInit();
            this.SuspendLayout();
            // 
            // registroCBindingSource
            // 
            this.registroCBindingSource.DataMember = "RegistroC";
            this.registroCBindingSource.DataSource = this.camioneraDataSetBindingSource;
            // 
            // camioneraDataSetBindingSource
            // 
            this.camioneraDataSetBindingSource.DataSource = this.camioneraDataSet;
            this.camioneraDataSetBindingSource.Position = 0;
            // 
            // camioneraDataSet
            // 
            this.camioneraDataSet.DataSetName = "CamioneraDataSet";
            this.camioneraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar";
            // 
            // textFiltrar
            // 
            this.textFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFiltrar.Location = new System.Drawing.Point(88, 11);
            this.textFiltrar.Name = "textFiltrar";
            this.textFiltrar.Size = new System.Drawing.Size(100, 29);
            this.textFiltrar.TabIndex = 2;
            this.textFiltrar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.textFiltrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(17, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(199, 54);
            this.panel1.TabIndex = 3;
            // 
            // registroCTableAdapter
            // 
            this.registroCTableAdapter.ClearBeforeFill = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.textHS);
            this.panel2.Controls.Add(this.textHE);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.textFecha);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.Neto);
            this.panel2.Controls.Add(this.Bruto);
            this.panel2.Controls.Add(this.Tara);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.Placas);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ID);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(14, 111);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 417);
            this.panel2.TabIndex = 4;
            // 
            // textHS
            // 
            this.textHS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHS.Location = new System.Drawing.Point(120, 250);
            this.textHS.Name = "textHS";
            this.textHS.ReadOnly = true;
            this.textHS.Size = new System.Drawing.Size(100, 29);
            this.textHS.TabIndex = 16;
            // 
            // textHE
            // 
            this.textHE.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textHE.Location = new System.Drawing.Point(120, 203);
            this.textHE.Name = "textHE";
            this.textHE.ReadOnly = true;
            this.textHE.Size = new System.Drawing.Size(100, 29);
            this.textHE.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 24);
            this.label9.TabIndex = 15;
            this.label9.Text = "Hora Salida";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 24);
            this.label8.TabIndex = 15;
            this.label8.Text = "Hora Entrada";
            // 
            // textFecha
            // 
            this.textFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textFecha.Location = new System.Drawing.Point(120, 157);
            this.textFecha.Name = "textFecha";
            this.textFecha.ReadOnly = true;
            this.textFecha.Size = new System.Drawing.Size(100, 29);
            this.textFecha.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 13;
            this.label7.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "Neto";
            // 
            // Neto
            // 
            this.Neto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Neto.Location = new System.Drawing.Point(119, 347);
            this.Neto.Name = "Neto";
            this.Neto.ReadOnly = true;
            this.Neto.Size = new System.Drawing.Size(100, 29);
            this.Neto.TabIndex = 10;
            // 
            // Bruto
            // 
            this.Bruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bruto.Location = new System.Drawing.Point(119, 298);
            this.Bruto.Name = "Bruto";
            this.Bruto.ReadOnly = true;
            this.Bruto.Size = new System.Drawing.Size(100, 29);
            this.Bruto.TabIndex = 12;
            // 
            // Tara
            // 
            this.Tara.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tara.Location = new System.Drawing.Point(119, 112);
            this.Tara.Name = "Tara";
            this.Tara.ReadOnly = true;
            this.Tara.Size = new System.Drawing.Size(100, 29);
            this.Tara.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tara";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 24);
            this.label6.TabIndex = 11;
            this.label6.Text = "Bruto";
            // 
            // Placas
            // 
            this.Placas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Placas.Location = new System.Drawing.Point(119, 68);
            this.Placas.Name = "Placas";
            this.Placas.ReadOnly = true;
            this.Placas.Size = new System.Drawing.Size(100, 29);
            this.Placas.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Placas";
            // 
            // ID
            // 
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(119, 20);
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Size = new System.Drawing.Size(100, 29);
            this.ID.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "ID";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(76, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Imprimir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registroCBindingSource1
            // 
            this.registroCBindingSource1.DataMember = "RegistroC";
            this.registroCBindingSource1.DataSource = this.camioneraDataSetBindingSource;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.placasCDataGridViewTextBoxColumn,
            this.pTaraDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn,
            this.horaEDataGridViewTextBoxColumn,
            this.horaSDataGridViewTextBoxColumn,
            this.pBrutoDataGridViewTextBoxColumn,
            this.pNetoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.registroCBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(269, 111);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(663, 417);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            // 
            // horaEDataGridViewTextBoxColumn
            // 
            this.horaEDataGridViewTextBoxColumn.DataPropertyName = "HoraE";
            this.horaEDataGridViewTextBoxColumn.HeaderText = "HoraE";
            this.horaEDataGridViewTextBoxColumn.Name = "horaEDataGridViewTextBoxColumn";
            // 
            // horaSDataGridViewTextBoxColumn
            // 
            this.horaSDataGridViewTextBoxColumn.DataPropertyName = "HoraS";
            this.horaSDataGridViewTextBoxColumn.HeaderText = "HoraS";
            this.horaSDataGridViewTextBoxColumn.Name = "horaSDataGridViewTextBoxColumn";
            // 
            // pBrutoDataGridViewTextBoxColumn
            // 
            this.pBrutoDataGridViewTextBoxColumn.DataPropertyName = "PBruto";
            this.pBrutoDataGridViewTextBoxColumn.HeaderText = "PBruto";
            this.pBrutoDataGridViewTextBoxColumn.Name = "pBrutoDataGridViewTextBoxColumn";
            // 
            // pNetoDataGridViewTextBoxColumn
            // 
            this.pNetoDataGridViewTextBoxColumn.DataPropertyName = "PNeto";
            this.pNetoDataGridViewTextBoxColumn.HeaderText = "PNeto";
            this.pNetoDataGridViewTextBoxColumn.Name = "pNetoDataGridViewTextBoxColumn";
            // 
            // registroCBindingSource2
            // 
            this.registroCBindingSource2.DataMember = "RegistroC";
            this.registroCBindingSource2.DataSource = this.camioneraDataSetFinal;
            // 
            // camioneraDataSetFinal
            // 
            this.camioneraDataSetFinal.DataSetName = "CamioneraDataSetFinal";
            this.camioneraDataSetFinal.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // registroCTableAdapter1
            // 
            this.registroCTableAdapter1.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(830, 539);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 37);
            this.button2.TabIndex = 9;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ReImpresion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 588);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReImpresion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reimpresion";
            this.Load += new System.EventHandler(this.ReImpresion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSet)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registroCBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camioneraDataSetFinal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource camioneraDataSetBindingSource;
        private CamioneraDataSet camioneraDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textFiltrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource registroCBindingSource;
        private CamioneraDataSetTableAdapters.RegistroCTableAdapter registroCTableAdapter;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox Bruto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Neto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Tara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Placas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.BindingSource registroCBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CamioneraDataSetFinal camioneraDataSetFinal;
        private System.Windows.Forms.BindingSource registroCBindingSource2;
        private CamioneraDataSetFinalTableAdapters.RegistroCTableAdapter registroCTableAdapter1;
        private System.Windows.Forms.TextBox textHE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn placasCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pTaraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaSDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pBrutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textHS;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
    }
}