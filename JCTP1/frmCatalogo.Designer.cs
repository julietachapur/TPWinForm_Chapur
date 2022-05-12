namespace JCTP1
{
    partial class frmCatalogo
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
            this.dgvArchivo = new System.Windows.Forms.DataGridView();
            this.dgvBuscar = new System.Windows.Forms.Button();
            this.filtro = new System.Windows.Forms.TextBox();
            this.pbxArchivo = new System.Windows.Forms.PictureBox();
            this.campoBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.criterioBox = new System.Windows.Forms.ComboBox();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.busquedaAvanzada = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArchivo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArchivo
            // 
            this.dgvArchivo.AccessibleName = "dgvArchivo";
            this.dgvArchivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArchivo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArchivo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArchivo.Location = new System.Drawing.Point(12, 12);
            this.dgvArchivo.Name = "dgvArchivo";
            this.dgvArchivo.Size = new System.Drawing.Size(501, 260);
            this.dgvArchivo.TabIndex = 0;
            this.dgvArchivo.SelectionChanged += new System.EventHandler(this.dgvArchivo_SelectionChanged);
            // 
            // dgvBuscar
            // 
            this.dgvBuscar.Location = new System.Drawing.Point(186, 278);
            this.dgvBuscar.Name = "dgvBuscar";
            this.dgvBuscar.Size = new System.Drawing.Size(129, 22);
            this.dgvBuscar.TabIndex = 1;
            this.dgvBuscar.Text = "Buscar Nombre";
            this.dgvBuscar.UseVisualStyleBackColor = true;
            this.dgvBuscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // filtro
            // 
            this.filtro.Location = new System.Drawing.Point(50, 278);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(121, 20);
            this.filtro.TabIndex = 2;
            // 
            // pbxArchivo
            // 
            this.pbxArchivo.Location = new System.Drawing.Point(530, 12);
            this.pbxArchivo.Name = "pbxArchivo";
            this.pbxArchivo.Size = new System.Drawing.Size(256, 259);
            this.pbxArchivo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArchivo.TabIndex = 4;
            this.pbxArchivo.TabStop = false;
            // 
            // campoBox
            // 
            this.campoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campoBox.FormattingEnabled = true;
            this.campoBox.Location = new System.Drawing.Point(50, 306);
            this.campoBox.Name = "campoBox";
            this.campoBox.Size = new System.Drawing.Size(121, 21);
            this.campoBox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Campo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Criterio";
            // 
            // criterioBox
            // 
            this.criterioBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.criterioBox.FormattingEnabled = true;
            this.criterioBox.Location = new System.Drawing.Point(228, 306);
            this.criterioBox.Name = "criterioBox";
            this.criterioBox.Size = new System.Drawing.Size(121, 21);
            this.criterioBox.TabIndex = 8;
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(368, 307);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.txtFiltroAvanzado.TabIndex = 9;
            // 
            // busquedaAvanzada
            // 
            this.busquedaAvanzada.Location = new System.Drawing.Point(474, 306);
            this.busquedaAvanzada.Name = "busquedaAvanzada";
            this.busquedaAvanzada.Size = new System.Drawing.Size(129, 23);
            this.busquedaAvanzada.TabIndex = 10;
            this.busquedaAvanzada.Text = "Busqueda avanzada";
            this.busquedaAvanzada.UseVisualStyleBackColor = true;
            this.busquedaAvanzada.Click += new System.EventHandler(this.busquedaAvanzada_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(321, 278);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(129, 22);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(456, 277);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(129, 23);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(591, 277);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(129, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.busquedaAvanzada);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.criterioBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.campoBox);
            this.Controls.Add(this.pbxArchivo);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.dgvBuscar);
            this.Controls.Add(this.dgvArchivo);
            this.Name = "frmCatalogo";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCatalogo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArchivo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivo;
        private System.Windows.Forms.Button dgvBuscar;
        private System.Windows.Forms.TextBox filtro;
        private System.Windows.Forms.PictureBox pbxArchivo;
        private System.Windows.Forms.ComboBox campoBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox criterioBox;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button busquedaAvanzada;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

