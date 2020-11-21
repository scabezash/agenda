namespace accesoMSQL
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
            System.Windows.Forms.Label id_contactosLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidosLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label cpLabel;
            System.Windows.Forms.Label poblacionLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.agendaDataSet = new accesoMSQL.agendaDataSet();
            this.contactosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contactosTableAdapter = new accesoMSQL.agendaDataSetTableAdapters.contactosTableAdapter();
            this.tableAdapterManager = new accesoMSQL.agendaDataSetTableAdapters.TableAdapterManager();
            this.contactosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_contactosTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.telefonoTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.cpTextBox = new System.Windows.Forms.TextBox();
            this.poblacionTextBox = new System.Windows.Forms.TextBox();
            this.insertar = new System.Windows.Forms.Button();
            this.consultar = new System.Windows.Forms.Button();
            this.contactosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.contactosBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contactosBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.contactosBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            id_contactosLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidosLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            cpLabel = new System.Windows.Forms.Label();
            poblacionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // id_contactosLabel
            // 
            id_contactosLabel.AutoSize = true;
            id_contactosLabel.Location = new System.Drawing.Point(787, 28);
            id_contactosLabel.Name = "id_contactosLabel";
            id_contactosLabel.Size = new System.Drawing.Size(68, 13);
            id_contactosLabel.TabIndex = 2;
            id_contactosLabel.Text = "id contactos:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(787, 54);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(45, 13);
            nombreLabel.TabIndex = 4;
            nombreLabel.Text = "nombre:";
            // 
            // apellidosLabel
            // 
            apellidosLabel.AutoSize = true;
            apellidosLabel.Location = new System.Drawing.Point(787, 80);
            apellidosLabel.Name = "apellidosLabel";
            apellidosLabel.Size = new System.Drawing.Size(51, 13);
            apellidosLabel.TabIndex = 6;
            apellidosLabel.Text = "apellidos:";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(787, 106);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(48, 13);
            telefonoLabel.TabIndex = 8;
            telefonoLabel.Text = "telefono:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(787, 132);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(53, 13);
            direccionLabel.TabIndex = 10;
            direccionLabel.Text = "direccion:";
            // 
            // cpLabel
            // 
            cpLabel.AutoSize = true;
            cpLabel.Location = new System.Drawing.Point(787, 158);
            cpLabel.Name = "cpLabel";
            cpLabel.Size = new System.Drawing.Size(22, 13);
            cpLabel.TabIndex = 12;
            cpLabel.Text = "cp:";
            // 
            // poblacionLabel
            // 
            poblacionLabel.AutoSize = true;
            poblacionLabel.Location = new System.Drawing.Point(787, 184);
            poblacionLabel.Name = "poblacionLabel";
            poblacionLabel.Size = new System.Drawing.Size(56, 13);
            poblacionLabel.TabIndex = 14;
            poblacionLabel.Text = "poblacion:";
            // 
            // agendaDataSet
            // 
            this.agendaDataSet.DataSetName = "agendaDataSet";
            this.agendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contactosBindingSource
            // 
            this.contactosBindingSource.DataMember = "contactos";
            this.contactosBindingSource.DataSource = this.agendaDataSet;
            // 
            // contactosTableAdapter
            // 
            this.contactosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.contactosTableAdapter = this.contactosTableAdapter;
            this.tableAdapterManager.UpdateOrder = accesoMSQL.agendaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contactosDataGridView
            // 
            this.contactosDataGridView.AutoGenerateColumns = false;
            this.contactosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.contactosDataGridView.DataSource = this.contactosBindingSource;
            this.contactosDataGridView.Location = new System.Drawing.Point(0, 28);
            this.contactosDataGridView.Name = "contactosDataGridView";
            this.contactosDataGridView.Size = new System.Drawing.Size(744, 251);
            this.contactosDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_contactos";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_contactos";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "apellidos";
            this.dataGridViewTextBoxColumn3.HeaderText = "apellidos";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "telefono";
            this.dataGridViewTextBoxColumn4.HeaderText = "telefono";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "direccion";
            this.dataGridViewTextBoxColumn5.HeaderText = "direccion";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "cp";
            this.dataGridViewTextBoxColumn6.HeaderText = "cp";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "poblacion";
            this.dataGridViewTextBoxColumn7.HeaderText = "poblacion";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // id_contactosTextBox
            // 
            this.id_contactosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "id_contactos", true));
            this.id_contactosTextBox.Location = new System.Drawing.Point(861, 25);
            this.id_contactosTextBox.Name = "id_contactosTextBox";
            this.id_contactosTextBox.Size = new System.Drawing.Size(100, 20);
            this.id_contactosTextBox.TabIndex = 3;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "nombre", true));
            this.nombreTextBox.Location = new System.Drawing.Point(861, 51);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(100, 20);
            this.nombreTextBox.TabIndex = 5;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "apellidos", true));
            this.apellidosTextBox.Location = new System.Drawing.Point(861, 77);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(100, 20);
            this.apellidosTextBox.TabIndex = 7;
            // 
            // telefonoTextBox
            // 
            this.telefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "telefono", true));
            this.telefonoTextBox.Location = new System.Drawing.Point(861, 103);
            this.telefonoTextBox.Name = "telefonoTextBox";
            this.telefonoTextBox.Size = new System.Drawing.Size(100, 20);
            this.telefonoTextBox.TabIndex = 9;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "direccion", true));
            this.direccionTextBox.Location = new System.Drawing.Point(861, 129);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(100, 20);
            this.direccionTextBox.TabIndex = 11;
            // 
            // cpTextBox
            // 
            this.cpTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "cp", true));
            this.cpTextBox.Location = new System.Drawing.Point(861, 155);
            this.cpTextBox.Name = "cpTextBox";
            this.cpTextBox.Size = new System.Drawing.Size(100, 20);
            this.cpTextBox.TabIndex = 13;
            // 
            // poblacionTextBox
            // 
            this.poblacionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.contactosBindingSource, "poblacion", true));
            this.poblacionTextBox.Location = new System.Drawing.Point(861, 181);
            this.poblacionTextBox.Name = "poblacionTextBox";
            this.poblacionTextBox.Size = new System.Drawing.Size(100, 20);
            this.poblacionTextBox.TabIndex = 15;
            // 
            // insertar
            // 
            this.insertar.Location = new System.Drawing.Point(790, 220);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(75, 23);
            this.insertar.TabIndex = 16;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = true;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // consultar
            // 
            this.consultar.Location = new System.Drawing.Point(790, 258);
            this.consultar.Name = "consultar";
            this.consultar.Size = new System.Drawing.Size(75, 23);
            this.consultar.TabIndex = 17;
            this.consultar.Text = "Consultar";
            this.consultar.UseVisualStyleBackColor = true;
            // 
            // contactosBindingSource1
            // 
            this.contactosBindingSource1.DataMember = "contactos";
            this.contactosBindingSource1.DataSource = this.agendaDataSet;
            // 
            // contactosBindingSource2
            // 
            this.contactosBindingSource2.DataMember = "contactos";
            this.contactosBindingSource2.DataSource = this.agendaDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.contactosBindingSource4, "cp", true));
            this.comboBox1.DataSource = this.contactosBindingSource3;
            this.comboBox1.DisplayMember = "cp";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(906, 260);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "cp";
            // 
            // contactosBindingSource3
            // 
            this.contactosBindingSource3.DataMember = "contactos";
            this.contactosBindingSource3.DataSource = this.agendaDataSet;
            // 
            // contactosBindingSource4
            // 
            this.contactosBindingSource4.DataMember = "contactos";
            this.contactosBindingSource4.DataSource = this.agendaDataSet;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 311);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.consultar);
            this.Controls.Add(this.insertar);
            this.Controls.Add(id_contactosLabel);
            this.Controls.Add(this.id_contactosTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(apellidosLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(cpLabel);
            this.Controls.Add(this.cpTextBox);
            this.Controls.Add(poblacionLabel);
            this.Controls.Add(this.poblacionTextBox);
            this.Controls.Add(this.contactosDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Agenda de contactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.agendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contactosBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private agendaDataSet agendaDataSet;
        private System.Windows.Forms.BindingSource contactosBindingSource;
        private agendaDataSetTableAdapters.contactosTableAdapter contactosTableAdapter;
        private agendaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView contactosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox id_contactosTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.TextBox telefonoTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox cpTextBox;
        private System.Windows.Forms.TextBox poblacionTextBox;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.Button consultar;
        private System.Windows.Forms.BindingSource contactosBindingSource2;
        private System.Windows.Forms.BindingSource contactosBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource contactosBindingSource4;
        private System.Windows.Forms.BindingSource contactosBindingSource3;
    }
}

