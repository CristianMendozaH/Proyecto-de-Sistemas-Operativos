namespace Proyectodesustemas
{
    partial class ProgramasXD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgramasXD));
            this.lvMonitoreo = new System.Windows.Forms.ListView();
            this.grpMonitoreo = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpMonitoreo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvMonitoreo
            // 
            this.lvMonitoreo.HideSelection = false;
            this.lvMonitoreo.Location = new System.Drawing.Point(45, 150);
            this.lvMonitoreo.Name = "lvMonitoreo";
            this.lvMonitoreo.Size = new System.Drawing.Size(709, 251);
            this.lvMonitoreo.TabIndex = 0;
            this.lvMonitoreo.UseCompatibleStateImageBehavior = false;
            this.lvMonitoreo.View = System.Windows.Forms.View.Tile;
            // 
            // grpMonitoreo
            // 
            this.grpMonitoreo.Controls.Add(this.label1);
            this.grpMonitoreo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpMonitoreo.Location = new System.Drawing.Point(0, 0);
            this.grpMonitoreo.Name = "grpMonitoreo";
            this.grpMonitoreo.Size = new System.Drawing.Size(800, 450);
            this.grpMonitoreo.TabIndex = 1;
            this.grpMonitoreo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(101, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(442, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Monitoreo de recursos";
            // 
            // ProgramasXD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvMonitoreo);
            this.Controls.Add(this.grpMonitoreo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProgramasXD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoreo del sistema";
            this.Load += new System.EventHandler(this.ProgramasXD_Load);
            this.grpMonitoreo.ResumeLayout(false);
            this.grpMonitoreo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvMonitoreo;
        private System.Windows.Forms.GroupBox grpMonitoreo;
        private System.Windows.Forms.Label label1;
    }
}