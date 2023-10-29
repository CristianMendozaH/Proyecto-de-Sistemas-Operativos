namespace Proyectodesustemas
{
    partial class VersionW
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionW));
            this.lblWindows = new System.Windows.Forms.Label();
            this.lblVWindows = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpwindows = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.grpwindows.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWindows
            // 
            this.lblWindows.AutoSize = true;
            this.lblWindows.Font = new System.Drawing.Font("Poppins SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindows.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lblWindows.Location = new System.Drawing.Point(38, 150);
            this.lblWindows.Name = "lblWindows";
            this.lblWindows.Size = new System.Drawing.Size(109, 53);
            this.lblWindows.TabIndex = 0;
            this.lblWindows.Text = "label1";
            // 
            // lblVWindows
            // 
            this.lblVWindows.AutoSize = true;
            this.lblVWindows.ForeColor = System.Drawing.Color.Black;
            this.lblVWindows.Location = new System.Drawing.Point(44, 309);
            this.lblVWindows.Name = "lblVWindows";
            this.lblVWindows.Size = new System.Drawing.Size(44, 16);
            this.lblVWindows.TabIndex = 1;
            this.lblVWindows.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(44, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(502, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(260, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // grpwindows
            // 
            this.grpwindows.Controls.Add(this.pictureBox1);
            this.grpwindows.Controls.Add(this.button1);
            this.grpwindows.Controls.Add(this.label3);
            this.grpwindows.Controls.Add(this.lblVWindows);
            this.grpwindows.Controls.Add(this.lblWindows);
            this.grpwindows.Location = new System.Drawing.Point(12, 12);
            this.grpwindows.Name = "grpwindows";
            this.grpwindows.Size = new System.Drawing.Size(643, 442);
            this.grpwindows.TabIndex = 0;
            this.grpwindows.TabStop = false;
            // 
            // VersionW
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(667, 467);
            this.Controls.Add(this.grpwindows);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VersionW";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acerca de Windows";
            this.Load += new System.EventHandler(this.VersionW_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.grpwindows.ResumeLayout(false);
            this.grpwindows.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblWindows;
        private System.Windows.Forms.Label lblVWindows;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox grpwindows;
    }
}