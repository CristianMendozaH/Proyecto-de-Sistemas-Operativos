namespace Proyectodesustemas
{
    partial class RedesActivas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RedesActivas));
            this.datos = new System.Windows.Forms.DataGridView();
            this.servicioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puertoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procesoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.protocoloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classConeccionesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mainTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classConeccionesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // datos
            // 
            this.datos.AutoGenerateColumns = false;
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.servicioDataGridViewTextBoxColumn,
            this.puertoDataGridViewTextBoxColumn,
            this.procesoDataGridViewTextBoxColumn,
            this.protocoloDataGridViewTextBoxColumn});
            this.datos.DataSource = this.classConeccionesBindingSource;
            this.datos.Location = new System.Drawing.Point(23, 127);
            this.datos.Name = "datos";
            this.datos.RowHeadersWidth = 51;
            this.datos.RowTemplate.Height = 24;
            this.datos.Size = new System.Drawing.Size(1049, 489);
            this.datos.TabIndex = 0;
            // 
            // servicioDataGridViewTextBoxColumn
            // 
            this.servicioDataGridViewTextBoxColumn.DataPropertyName = "Servicio";
            this.servicioDataGridViewTextBoxColumn.HeaderText = "Servicio";
            this.servicioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.servicioDataGridViewTextBoxColumn.Name = "servicioDataGridViewTextBoxColumn";
            this.servicioDataGridViewTextBoxColumn.Width = 175;
            // 
            // puertoDataGridViewTextBoxColumn
            // 
            this.puertoDataGridViewTextBoxColumn.DataPropertyName = "Puerto";
            this.puertoDataGridViewTextBoxColumn.HeaderText = "Puerto";
            this.puertoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.puertoDataGridViewTextBoxColumn.Name = "puertoDataGridViewTextBoxColumn";
            this.puertoDataGridViewTextBoxColumn.Width = 175;
            // 
            // procesoDataGridViewTextBoxColumn
            // 
            this.procesoDataGridViewTextBoxColumn.DataPropertyName = "Proceso";
            this.procesoDataGridViewTextBoxColumn.HeaderText = "Proceso";
            this.procesoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.procesoDataGridViewTextBoxColumn.Name = "procesoDataGridViewTextBoxColumn";
            this.procesoDataGridViewTextBoxColumn.Width = 175;
            // 
            // protocoloDataGridViewTextBoxColumn
            // 
            this.protocoloDataGridViewTextBoxColumn.DataPropertyName = "Protocolo";
            this.protocoloDataGridViewTextBoxColumn.HeaderText = "Protocolo";
            this.protocoloDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.protocoloDataGridViewTextBoxColumn.Name = "protocoloDataGridViewTextBoxColumn";
            this.protocoloDataGridViewTextBoxColumn.Width = 175;
            // 
            // classConeccionesBindingSource
            // 
            this.classConeccionesBindingSource.DataSource = typeof(Proyectodesustemas.ClassConecciones);
            // 
            // mainTitle
            // 
            this.mainTitle.AutoSize = true;
            this.mainTitle.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitle.ForeColor = System.Drawing.Color.White;
            this.mainTitle.Location = new System.Drawing.Point(401, 31);
            this.mainTitle.Name = "mainTitle";
            this.mainTitle.Size = new System.Drawing.Size(284, 65);
            this.mainTitle.TabIndex = 1;
            this.mainTitle.Text = "Redes Activas";
            // 
            // RedesActivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1093, 642);
            this.Controls.Add(this.mainTitle);
            this.Controls.Add(this.datos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RedesActivas";
            this.Load += new System.EventHandler(this.RedesActivas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classConeccionesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datos;
        private System.Windows.Forms.Label mainTitle;
        private System.Windows.Forms.BindingSource classConeccionesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn puertoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn procesoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn protocoloDataGridViewTextBoxColumn;
    }
}