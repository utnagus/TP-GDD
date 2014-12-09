namespace FrbaHotel.ABM_de_Cliente
{
    partial class Avaible_Users
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
            this.lb_unavaible = new System.Windows.Forms.ListBox();
            this.lb_avaible = new System.Windows.Forms.ListBox();
            this.btn_avaible = new System.Windows.Forms.Button();
            this.btn_unavaible = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lb_unavaible
            // 
            this.lb_unavaible.FormattingEnabled = true;
            this.lb_unavaible.Location = new System.Drawing.Point(30, 12);
            this.lb_unavaible.Name = "lb_unavaible";
            this.lb_unavaible.Size = new System.Drawing.Size(120, 238);
            this.lb_unavaible.TabIndex = 0;
            // 
            // lb_avaible
            // 
            this.lb_avaible.FormattingEnabled = true;
            this.lb_avaible.Location = new System.Drawing.Point(204, 12);
            this.lb_avaible.Name = "lb_avaible";
            this.lb_avaible.Size = new System.Drawing.Size(120, 238);
            this.lb_avaible.TabIndex = 1;
            // 
            // btn_avaible
            // 
            this.btn_avaible.Location = new System.Drawing.Point(355, 12);
            this.btn_avaible.Name = "btn_avaible";
            this.btn_avaible.Size = new System.Drawing.Size(75, 23);
            this.btn_avaible.TabIndex = 2;
            this.btn_avaible.Text = "Habilitar";
            this.btn_avaible.UseVisualStyleBackColor = true;
            this.btn_avaible.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_unavaible
            // 
            this.btn_unavaible.Location = new System.Drawing.Point(355, 52);
            this.btn_unavaible.Name = "btn_unavaible";
            this.btn_unavaible.Size = new System.Drawing.Size(75, 23);
            this.btn_unavaible.TabIndex = 3;
            this.btn_unavaible.Text = "Deshabilitar";
            this.btn_unavaible.UseVisualStyleBackColor = true;
            this.btn_unavaible.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(355, 227);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Cerrar";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(355, 188);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 5;
            this.btn_confirm.Text = "Confirmar";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Avaible_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 266);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_unavaible);
            this.Controls.Add(this.btn_avaible);
            this.Controls.Add(this.lb_avaible);
            this.Controls.Add(this.lb_unavaible);
            this.Name = "Avaible_Users";
            this.Text = "Avaible_Users";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lb_unavaible;
        private System.Windows.Forms.ListBox lb_avaible;
        private System.Windows.Forms.Button btn_avaible;
        private System.Windows.Forms.Button btn_unavaible;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_confirm;
    }
}