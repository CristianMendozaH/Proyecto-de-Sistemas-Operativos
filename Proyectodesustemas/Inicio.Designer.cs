namespace Proyectodesustemas
{
    partial class Inicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btninterblock = new FontAwesome.Sharp.IconButton();
            this.btnConcurrencia = new FontAwesome.Sharp.IconButton();
            this.btnred = new FontAwesome.Sharp.IconButton();
            this.btnMonitoreo = new FontAwesome.Sharp.IconButton();
            this.btnTareas = new FontAwesome.Sharp.IconButton();
            this.btnProgramas = new FontAwesome.Sharp.IconButton();
            this.btnhardware = new FontAwesome.Sharp.IconButton();
            this.btnAcerca = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.White;
            this.iconButton1.Font = new System.Drawing.Font("Poppins", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.Black;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(726, 432);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(166, 64);
            this.iconButton1.TabIndex = 11;
            this.iconButton1.Text = "Regresar";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // btninterblock
            // 
            this.btninterblock.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btninterblock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btninterblock.ForeColor = System.Drawing.Color.Black;
            this.btninterblock.IconChar = FontAwesome.Sharp.IconChar.BridgeLock;
            this.btninterblock.IconColor = System.Drawing.Color.Black;
            this.btninterblock.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btninterblock.IconSize = 70;
            this.btninterblock.Location = new System.Drawing.Point(552, 337);
            this.btninterblock.Name = "btninterblock";
            this.btninterblock.Size = new System.Drawing.Size(168, 159);
            this.btninterblock.TabIndex = 9;
            this.btninterblock.Text = "Interbloqueos Explicacion";
            this.btninterblock.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btninterblock.UseVisualStyleBackColor = false;
            this.btninterblock.Click += new System.EventHandler(this.btninterblock_Click);
            // 
            // btnConcurrencia
            // 
            this.btnConcurrencia.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnConcurrencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcurrencia.ForeColor = System.Drawing.Color.Black;
            this.btnConcurrencia.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnConcurrencia.IconColor = System.Drawing.Color.Black;
            this.btnConcurrencia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConcurrencia.IconSize = 70;
            this.btnConcurrencia.Location = new System.Drawing.Point(379, 337);
            this.btnConcurrencia.Name = "btnConcurrencia";
            this.btnConcurrencia.Size = new System.Drawing.Size(168, 159);
            this.btnConcurrencia.TabIndex = 8;
            this.btnConcurrencia.Text = "Concurrencia Explicacion";
            this.btnConcurrencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnConcurrencia.UseVisualStyleBackColor = false;
            this.btnConcurrencia.Click += new System.EventHandler(this.btnConcurrencia_Click);
            // 
            // btnred
            // 
            this.btnred.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnred.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnred.ForeColor = System.Drawing.Color.Black;
            this.btnred.IconChar = FontAwesome.Sharp.IconChar.Ethernet;
            this.btnred.IconColor = System.Drawing.Color.Black;
            this.btnred.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnred.IconSize = 70;
            this.btnred.Location = new System.Drawing.Point(206, 337);
            this.btnred.Name = "btnred";
            this.btnred.Size = new System.Drawing.Size(168, 159);
            this.btnred.TabIndex = 7;
            this.btnred.Text = "Redes Activas";
            this.btnred.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnred.UseVisualStyleBackColor = false;
            this.btnred.Click += new System.EventHandler(this.btnred_Click);
            // 
            // btnMonitoreo
            // 
            this.btnMonitoreo.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnMonitoreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMonitoreo.ForeColor = System.Drawing.Color.Black;
            this.btnMonitoreo.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnMonitoreo.IconColor = System.Drawing.Color.Black;
            this.btnMonitoreo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMonitoreo.IconSize = 70;
            this.btnMonitoreo.Location = new System.Drawing.Point(724, 172);
            this.btnMonitoreo.Name = "btnMonitoreo";
            this.btnMonitoreo.Size = new System.Drawing.Size(168, 159);
            this.btnMonitoreo.TabIndex = 4;
            this.btnMonitoreo.Text = "Monitoreo";
            this.btnMonitoreo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnMonitoreo.UseVisualStyleBackColor = false;
            this.btnMonitoreo.Click += new System.EventHandler(this.btnMonitoreo_Click);
            // 
            // btnTareas
            // 
            this.btnTareas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTareas.ForeColor = System.Drawing.Color.Black;
            this.btnTareas.IconChar = FontAwesome.Sharp.IconChar.ListCheck;
            this.btnTareas.IconColor = System.Drawing.Color.Black;
            this.btnTareas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTareas.IconSize = 70;
            this.btnTareas.Location = new System.Drawing.Point(552, 172);
            this.btnTareas.Name = "btnTareas";
            this.btnTareas.Size = new System.Drawing.Size(168, 159);
            this.btnTareas.TabIndex = 3;
            this.btnTareas.Text = "Administrador de Procesos";
            this.btnTareas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTareas.UseMnemonic = false;
            this.btnTareas.UseVisualStyleBackColor = false;
            this.btnTareas.Click += new System.EventHandler(this.btnTareas_Click);
            // 
            // btnProgramas
            // 
            this.btnProgramas.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnProgramas.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProgramas.ForeColor = System.Drawing.Color.Black;
            this.btnProgramas.IconChar = FontAwesome.Sharp.IconChar.Uncharted;
            this.btnProgramas.IconColor = System.Drawing.Color.Black;
            this.btnProgramas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProgramas.IconSize = 70;
            this.btnProgramas.Location = new System.Drawing.Point(379, 172);
            this.btnProgramas.Name = "btnProgramas";
            this.btnProgramas.Size = new System.Drawing.Size(168, 159);
            this.btnProgramas.TabIndex = 2;
            this.btnProgramas.Text = "Programas";
            this.btnProgramas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProgramas.UseVisualStyleBackColor = false;
            this.btnProgramas.Click += new System.EventHandler(this.btnProgramas_Click);
            // 
            // btnhardware
            // 
            this.btnhardware.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnhardware.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnhardware.ForeColor = System.Drawing.Color.Black;
            this.btnhardware.IconChar = FontAwesome.Sharp.IconChar.Computer;
            this.btnhardware.IconColor = System.Drawing.Color.Black;
            this.btnhardware.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnhardware.IconSize = 70;
            this.btnhardware.Location = new System.Drawing.Point(206, 172);
            this.btnhardware.Name = "btnhardware";
            this.btnhardware.Size = new System.Drawing.Size(168, 159);
            this.btnhardware.TabIndex = 1;
            this.btnhardware.Text = "Hardware";
            this.btnhardware.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnhardware.UseVisualStyleBackColor = false;
            this.btnhardware.Click += new System.EventHandler(this.btnhardware_Click);
            // 
            // btnAcerca
            // 
            this.btnAcerca.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAcerca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAcerca.ForeColor = System.Drawing.Color.Black;
            this.btnAcerca.IconChar = FontAwesome.Sharp.IconChar.Windows;
            this.btnAcerca.IconColor = System.Drawing.Color.Black;
            this.btnAcerca.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAcerca.IconSize = 70;
            this.btnAcerca.Location = new System.Drawing.Point(32, 172);
            this.btnAcerca.Name = "btnAcerca";
            this.btnAcerca.Size = new System.Drawing.Size(168, 159);
            this.btnAcerca.TabIndex = 0;
            this.btnAcerca.Text = "Acerca de ";
            this.btnAcerca.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAcerca.UseVisualStyleBackColor = false;
            this.btnAcerca.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 65);
            this.label1.TabIndex = 12;
            this.label1.Text = "Administración del equipo \r\n";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(935, 552);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btninterblock);
            this.Controls.Add(this.btnConcurrencia);
            this.Controls.Add(this.btnred);
            this.Controls.Add(this.btnMonitoreo);
            this.Controls.Add(this.btnTareas);
            this.Controls.Add(this.btnProgramas);
            this.Controls.Add(this.btnhardware);
            this.Controls.Add(this.btnAcerca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Inicio";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cristian Daniel Mendoza Hernández, Carnet: 2090-21-20201";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnAcerca;
        private FontAwesome.Sharp.IconButton btnhardware;
        private FontAwesome.Sharp.IconButton btnProgramas;
        private FontAwesome.Sharp.IconButton btnTareas;
        private FontAwesome.Sharp.IconButton btnMonitoreo;
        private FontAwesome.Sharp.IconButton btnred;
        private FontAwesome.Sharp.IconButton btnConcurrencia;
        private FontAwesome.Sharp.IconButton btninterblock;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
    }
}

