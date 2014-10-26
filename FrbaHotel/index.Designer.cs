namespace FrbaHotel
{
    partial class index_window
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_user_abm = new System.Windows.Forms.Button();
            this.label_logged = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Login Window";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_user_abm
            // 
            this.btn_user_abm.Location = new System.Drawing.Point(174, 100);
            this.btn_user_abm.Name = "btn_user_abm";
            this.btn_user_abm.Size = new System.Drawing.Size(140, 23);
            this.btn_user_abm.TabIndex = 1;
            this.btn_user_abm.Text = "ABM User";
            this.btn_user_abm.UseVisualStyleBackColor = true;
            this.btn_user_abm.Click += new System.EventHandler(this.btn_user_abm_Click);
            // 
            // label_logged
            // 
            this.label_logged.AutoSize = true;
            this.label_logged.Location = new System.Drawing.Point(416, 13);
            this.label_logged.Name = "label_logged";
            this.label_logged.Size = new System.Drawing.Size(66, 13);
            this.label_logged.TabIndex = 2;
            this.label_logged.Text = "Logged user";
            // 
            // index_window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 372);
            this.Controls.Add(this.label_logged);
            this.Controls.Add(this.btn_user_abm);
            this.Controls.Add(this.button1);
            this.Location = new System.Drawing.Point(200, 200);
            this.Name = "index_window";
            this.Text = "Index";
            this.Load += new System.EventHandler(this.index_window_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_user_abm;
        private System.Windows.Forms.Label label_logged;

    }
}

