﻿namespace FrbaHotel.ABM_de_Habitacion
{
    partial class ABMHabitacion_Alta
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Nro = new System.Windows.Forms.TextBox();
            this.textBox_Piso = new System.Windows.Forms.TextBox();
            this.textBox_desc = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Número:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hotel:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(481, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Piso:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Ubicación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tipo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(451, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Descripción:";
            // 
            // textBox_Nro
            // 
            this.textBox_Nro.Location = new System.Drawing.Point(324, 25);
            this.textBox_Nro.Name = "textBox_Nro";
            this.textBox_Nro.Size = new System.Drawing.Size(100, 20);
            this.textBox_Nro.TabIndex = 7;
            this.textBox_Nro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Nro_TextChanged);
            // 
            // textBox_Piso
            // 
            this.textBox_Piso.Location = new System.Drawing.Point(517, 29);
            this.textBox_Piso.Name = "textBox_Piso";
            this.textBox_Piso.Size = new System.Drawing.Size(100, 20);
            this.textBox_Piso.TabIndex = 8;
            this.textBox_Piso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_Piso_TextChanged);
            // 
            // textBox_desc
            // 
            this.textBox_desc.Location = new System.Drawing.Point(517, 90);
            this.textBox_desc.Name = "textBox_desc";
            this.textBox_desc.Size = new System.Drawing.Size(100, 20);
            this.textBox_desc.TabIndex = 10;
            this.textBox_desc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_desc_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 31);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(104, 32);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 13;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(105, 92);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(51, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Norte";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(162, 93);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(41, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Sur";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(324, 92);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 16;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // ABMHabitacion_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 262);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_desc);
            this.Controls.Add(this.textBox_Piso);
            this.Controls.Add(this.textBox_Nro);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ABMHabitacion_Alta";
            this.Text = "Habitaciones";
            this.Load += new System.EventHandler(this.ABMHabitacion_Listado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Nro;
        private System.Windows.Forms.TextBox textBox_Piso;
        private System.Windows.Forms.TextBox textBox_desc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}