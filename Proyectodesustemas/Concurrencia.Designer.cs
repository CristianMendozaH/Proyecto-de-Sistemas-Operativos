namespace Proyectodesustemas
{
    partial class Concurrencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Concurrencia));
            this.cbxMenu = new System.Windows.Forms.ComboBox();
            this.cbxBebida = new System.Windows.Forms.ComboBox();
            this.txtCantidadPlatillo = new System.Windows.Forms.TextBox();
            this.txtCantidadBebida = new System.Windows.Forms.TextBox();
            this.btnNuevaOrden = new System.Windows.Forms.Button();
            this.lvOrdenes = new System.Windows.Forms.ListView();
            this.btnAceptarConcurrencia = new System.Windows.Forms.Button();
            this.lblNotificationOrden = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbxMenu
            // 
            this.cbxMenu.FormattingEnabled = true;
            this.cbxMenu.Items.AddRange(new object[] {
            "HAMBURGUESA",
            "TORTA MEXICANA",
            "PIZZA"});
            this.cbxMenu.Location = new System.Drawing.Point(85, 154);
            this.cbxMenu.Name = "cbxMenu";
            this.cbxMenu.Size = new System.Drawing.Size(143, 24);
            this.cbxMenu.TabIndex = 0;
            // 
            // cbxBebida
            // 
            this.cbxBebida.FormattingEnabled = true;
            this.cbxBebida.Items.AddRange(new object[] {
            "COCA-COLA DE 12ONZ",
            "PEPSI_COLA DE 2ONZ"});
            this.cbxBebida.Location = new System.Drawing.Point(85, 277);
            this.cbxBebida.Name = "cbxBebida";
            this.cbxBebida.Size = new System.Drawing.Size(143, 24);
            this.cbxBebida.TabIndex = 1;
            // 
            // txtCantidadPlatillo
            // 
            this.txtCantidadPlatillo.Location = new System.Drawing.Point(315, 155);
            this.txtCantidadPlatillo.Name = "txtCantidadPlatillo";
            this.txtCantidadPlatillo.Size = new System.Drawing.Size(122, 22);
            this.txtCantidadPlatillo.TabIndex = 2;
            // 
            // txtCantidadBebida
            // 
            this.txtCantidadBebida.Location = new System.Drawing.Point(315, 279);
            this.txtCantidadBebida.Name = "txtCantidadBebida";
            this.txtCantidadBebida.Size = new System.Drawing.Size(122, 22);
            this.txtCantidadBebida.TabIndex = 3;
            // 
            // btnNuevaOrden
            // 
            this.btnNuevaOrden.Location = new System.Drawing.Point(175, 351);
            this.btnNuevaOrden.Name = "btnNuevaOrden";
            this.btnNuevaOrden.Size = new System.Drawing.Size(167, 53);
            this.btnNuevaOrden.TabIndex = 4;
            this.btnNuevaOrden.Text = "Ordenar";
            this.btnNuevaOrden.UseVisualStyleBackColor = true;
            this.btnNuevaOrden.Click += new System.EventHandler(this.btnNuevaOrden_Click);
            // 
            // lvOrdenes
            // 
            this.lvOrdenes.HideSelection = false;
            this.lvOrdenes.Location = new System.Drawing.Point(512, 154);
            this.lvOrdenes.Name = "lvOrdenes";
            this.lvOrdenes.Size = new System.Drawing.Size(394, 248);
            this.lvOrdenes.TabIndex = 5;
            this.lvOrdenes.UseCompatibleStateImageBehavior = false;
            this.lvOrdenes.View = System.Windows.Forms.View.List;
            // 
            // btnAceptarConcurrencia
            // 
            this.btnAceptarConcurrencia.Location = new System.Drawing.Point(797, 463);
            this.btnAceptarConcurrencia.Name = "btnAceptarConcurrencia";
            this.btnAceptarConcurrencia.Size = new System.Drawing.Size(109, 70);
            this.btnAceptarConcurrencia.TabIndex = 6;
            this.btnAceptarConcurrencia.Text = "Regresar";
            this.btnAceptarConcurrencia.UseVisualStyleBackColor = true;
            this.btnAceptarConcurrencia.Click += new System.EventHandler(this.btnAceptarConcurrencia_Click);
            // 
            // lblNotificationOrden
            // 
            this.lblNotificationOrden.AutoSize = true;
            this.lblNotificationOrden.Location = new System.Drawing.Point(238, 500);
            this.lblNotificationOrden.Name = "lblNotificationOrden";
            this.lblNotificationOrden.Size = new System.Drawing.Size(0, 16);
            this.lblNotificationOrden.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(248, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 65);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ejemplo de Concurrencia";
            // 
            // Concurrencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(965, 568);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblNotificationOrden);
            this.Controls.Add(this.btnAceptarConcurrencia);
            this.Controls.Add(this.lvOrdenes);
            this.Controls.Add(this.btnNuevaOrden);
            this.Controls.Add(this.txtCantidadBebida);
            this.Controls.Add(this.txtCantidadPlatillo);
            this.Controls.Add(this.cbxBebida);
            this.Controls.Add(this.cbxMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Concurrencia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Concurrencia";
            this.Load += new System.EventHandler(this.Concurrencia_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxMenu;
        private System.Windows.Forms.ComboBox cbxBebida;
        private System.Windows.Forms.TextBox txtCantidadPlatillo;
        private System.Windows.Forms.TextBox txtCantidadBebida;
        private System.Windows.Forms.Button btnNuevaOrden;
        private System.Windows.Forms.ListView lvOrdenes;
        private System.Windows.Forms.Button btnAceptarConcurrencia;
        private System.Windows.Forms.Label lblNotificationOrden;
        private System.Windows.Forms.Label label1;
    }
}