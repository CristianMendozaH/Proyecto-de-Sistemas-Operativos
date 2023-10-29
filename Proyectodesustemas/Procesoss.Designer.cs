namespace Proyectodesustemas
{
    partial class Procesoss
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
            this.grpProcesos = new System.Windows.Forms.GroupBox();
            this.BtnAceptarProcesos = new System.Windows.Forms.Button();
            this.btnMaatarTodos = new System.Windows.Forms.Button();
            this.btnMatar = new System.Windows.Forms.Button();
            this.btnPausar = new System.Windows.Forms.Button();
            this.lbxProcesos = new System.Windows.Forms.ListBox();
            this.grpProcesos.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpProcesos
            // 
            this.grpProcesos.Controls.Add(this.BtnAceptarProcesos);
            this.grpProcesos.Controls.Add(this.btnMaatarTodos);
            this.grpProcesos.Controls.Add(this.btnMatar);
            this.grpProcesos.Controls.Add(this.btnPausar);
            this.grpProcesos.Controls.Add(this.lbxProcesos);
            this.grpProcesos.Location = new System.Drawing.Point(38, 149);
            this.grpProcesos.Name = "grpProcesos";
            this.grpProcesos.Size = new System.Drawing.Size(741, 443);
            this.grpProcesos.TabIndex = 0;
            this.grpProcesos.TabStop = false;
            // 
            // BtnAceptarProcesos
            // 
            this.BtnAceptarProcesos.Location = new System.Drawing.Point(521, 289);
            this.BtnAceptarProcesos.Name = "BtnAceptarProcesos";
            this.BtnAceptarProcesos.Size = new System.Drawing.Size(143, 53);
            this.BtnAceptarProcesos.TabIndex = 4;
            this.BtnAceptarProcesos.Text = "Aceptar";
            this.BtnAceptarProcesos.UseVisualStyleBackColor = true;
            this.BtnAceptarProcesos.Click += new System.EventHandler(this.BtnAceptarProcesos_Click);
            // 
            // btnMaatarTodos
            // 
            this.btnMaatarTodos.Location = new System.Drawing.Point(521, 219);
            this.btnMaatarTodos.Name = "btnMaatarTodos";
            this.btnMaatarTodos.Size = new System.Drawing.Size(143, 53);
            this.btnMaatarTodos.TabIndex = 3;
            this.btnMaatarTodos.Text = "Matar todos";
            this.btnMaatarTodos.UseVisualStyleBackColor = true;
            this.btnMaatarTodos.Click += new System.EventHandler(this.btnMaatarTodos_Click);
            // 
            // btnMatar
            // 
            this.btnMatar.Location = new System.Drawing.Point(521, 155);
            this.btnMatar.Name = "btnMatar";
            this.btnMatar.Size = new System.Drawing.Size(143, 53);
            this.btnMatar.TabIndex = 2;
            this.btnMatar.Text = "Matar";
            this.btnMatar.UseVisualStyleBackColor = true;
            this.btnMatar.Click += new System.EventHandler(this.btnMatar_Click);
            // 
            // btnPausar
            // 
            this.btnPausar.Location = new System.Drawing.Point(521, 81);
            this.btnPausar.Name = "btnPausar";
            this.btnPausar.Size = new System.Drawing.Size(143, 53);
            this.btnPausar.TabIndex = 1;
            this.btnPausar.Text = "Pausa";
            this.btnPausar.UseVisualStyleBackColor = true;
            this.btnPausar.Click += new System.EventHandler(this.btnPausar_Click);
            // 
            // lbxProcesos
            // 
            this.lbxProcesos.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbxProcesos.FormattingEnabled = true;
            this.lbxProcesos.ItemHeight = 23;
            this.lbxProcesos.Location = new System.Drawing.Point(27, 41);
            this.lbxProcesos.Name = "lbxProcesos";
            this.lbxProcesos.Size = new System.Drawing.Size(403, 372);
            this.lbxProcesos.TabIndex = 0;
            // 
            // Procesoss
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 628);
            this.Controls.Add(this.grpProcesos);
            this.Name = "Procesoss";
            this.Text = "Procesoss";
            this.Load += new System.EventHandler(this.Procesoss_Load);
            this.grpProcesos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpProcesos;
        private System.Windows.Forms.Button BtnAceptarProcesos;
        private System.Windows.Forms.Button btnMaatarTodos;
        private System.Windows.Forms.Button btnMatar;
        private System.Windows.Forms.Button btnPausar;
        private System.Windows.Forms.ListBox lbxProcesos;
    }
}