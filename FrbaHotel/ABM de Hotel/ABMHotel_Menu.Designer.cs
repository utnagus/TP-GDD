namespace FrbaHotel.ABM_de_Hotel
{
    partial class ABMHotel_Menu
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
            this.button_Alta = new System.Windows.Forms.Button();
            this.button_Baja = new System.Windows.Forms.Button();
            this.button_Modificacion = new System.Windows.Forms.Button();
            this.button_Listado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_Alta
            // 
            this.button_Alta.Location = new System.Drawing.Point(20, 28);
            this.button_Alta.Name = "button_Alta";
            this.button_Alta.Size = new System.Drawing.Size(120, 28);
            this.button_Alta.TabIndex = 0;
            this.button_Alta.Text = "Alta";
            this.button_Alta.UseVisualStyleBackColor = true;
            this.button_Alta.Click += new System.EventHandler(this.button_Alta_Click);
            // 
            // button_Baja
            // 
            this.button_Baja.Location = new System.Drawing.Point(180, 29);
            this.button_Baja.Name = "button_Baja";
            this.button_Baja.Size = new System.Drawing.Size(120, 27);
            this.button_Baja.TabIndex = 1;
            this.button_Baja.Text = "Baja";
            this.button_Baja.UseVisualStyleBackColor = true;
            // 
            // button_Modificacion
            // 
            this.button_Modificacion.Location = new System.Drawing.Point(20, 76);
            this.button_Modificacion.Name = "button_Modificacion";
            this.button_Modificacion.Size = new System.Drawing.Size(119, 27);
            this.button_Modificacion.TabIndex = 2;
            this.button_Modificacion.Text = "Modificación";
            this.button_Modificacion.UseVisualStyleBackColor = true;
            this.button_Modificacion.Click += new System.EventHandler(this.button_Modificacion_Click);
            // 
            // button_Listado
            // 
            this.button_Listado.Location = new System.Drawing.Point(180, 76);
            this.button_Listado.Name = "button_Listado";
            this.button_Listado.Size = new System.Drawing.Size(120, 27);
            this.button_Listado.TabIndex = 3;
            this.button_Listado.Text = "Listado";
            this.button_Listado.UseVisualStyleBackColor = true;
            this.button_Listado.Click += new System.EventHandler(this.button_Listado_Click);
            // 
            // ABMHotel_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 126);
            this.Controls.Add(this.button_Listado);
            this.Controls.Add(this.button_Modificacion);
            this.Controls.Add(this.button_Baja);
            this.Controls.Add(this.button_Alta);
            this.Name = "ABMHotel_Menu";
            this.Text = "ABM Hotel";
            this.Load += new System.EventHandler(this.ABMHotel_Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Alta;
        private System.Windows.Forms.Button button_Baja;
        private System.Windows.Forms.Button button_Modificacion;
        private System.Windows.Forms.Button button_Listado;
    }
}