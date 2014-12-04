namespace FrbaHotel.ABM_de_Hotel
{
    partial class ABMHotel_Alta
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
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_ciudad = new System.Windows.Forms.TextBox();
            this.textBox_pais = new System.Windows.Forms.TextBox();
            this.textBox_mail = new System.Windows.Forms.TextBox();
            this.textBox_telefono = new System.Windows.Forms.TextBox();
            this.textBox_regimenes = new System.Windows.Forms.TextBox();
            this.textBox_direccion = new System.Windows.Forms.TextBox();
            this.textBox_fecha = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.estrellas = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.estrellas)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(148, 28);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(146, 20);
            this.textBox_nombre.TabIndex = 0;
            this.textBox_nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_nombre_TextChanged);
            // 
            // textBox_ciudad
            // 
            this.textBox_ciudad.Location = new System.Drawing.Point(450, 28);
            this.textBox_ciudad.Name = "textBox_ciudad";
            this.textBox_ciudad.Size = new System.Drawing.Size(143, 20);
            this.textBox_ciudad.TabIndex = 1;
            //this.textBox_ciudad.TextChanged += new System.EventHandler(this.textBox_ciudad_TextChanged);
            this.textBox_ciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pais_TextChanged);
            // 
            // textBox_pais
            // 
            this.textBox_pais.Location = new System.Drawing.Point(450, 67);
            this.textBox_pais.Name = "textBox_pais";
            this.textBox_pais.Size = new System.Drawing.Size(143, 20);
            this.textBox_pais.TabIndex = 2;
            //this.textBox_pais.TextChanged += new System.EventHandler(this.textBox_pais_TextChanged);
            this.textBox_pais.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_pais_TextChanged);
            // 
            // textBox_mail
            // 
            this.textBox_mail.Location = new System.Drawing.Point(148, 67);
            this.textBox_mail.Name = "textBox_mail";
            this.textBox_mail.Size = new System.Drawing.Size(146, 20);
            this.textBox_mail.TabIndex = 3;
            this.textBox_mail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_mail_TextChanged);
            // 
            // textBox_telefono
            // 
            this.textBox_telefono.Location = new System.Drawing.Point(149, 109);
            this.textBox_telefono.Name = "textBox_telefono";
            this.textBox_telefono.Size = new System.Drawing.Size(145, 20);
            this.textBox_telefono.TabIndex = 4;
            this.textBox_telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_telefono_TextChanged);
            // 
            // textBox_regimenes
            // 
            this.textBox_regimenes.Location = new System.Drawing.Point(451, 109);
            this.textBox_regimenes.Name = "textBox_regimenes";
            this.textBox_regimenes.Size = new System.Drawing.Size(142, 20);
            this.textBox_regimenes.TabIndex = 5;
            // 
            // textBox_direccion
            // 
            this.textBox_direccion.Location = new System.Drawing.Point(150, 156);
            this.textBox_direccion.Name = "textBox_direccion";
            this.textBox_direccion.Size = new System.Drawing.Size(144, 20);
            this.textBox_direccion.TabIndex = 6;
            this.textBox_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_direccion_TextChanged);
            // 
            // textBox_fecha
            // 
            this.textBox_fecha.Location = new System.Drawing.Point(452, 156);
            this.textBox_fecha.Name = "textBox_fecha";
            this.textBox_fecha.Size = new System.Drawing.Size(141, 20);
            this.textBox_fecha.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(452, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(113, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Mail:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(91, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Teléfono:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Dirección:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Cantidad de estrellas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Ciudad:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "País:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(380, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Regímenes:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(347, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Fecha de creación:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(229, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(169, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Todos los campos son obligatorios";
            // 
            // estrellas
            // 
            this.estrellas.Location = new System.Drawing.Point(149, 200);
            this.estrellas.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.estrellas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.estrellas.Name = "estrellas";
            this.estrellas.Size = new System.Drawing.Size(144, 20);
            this.estrellas.TabIndex = 20;
            this.estrellas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ABMHotel_Alta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 262);
            this.Controls.Add(this.estrellas);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_fecha);
            this.Controls.Add(this.textBox_direccion);
            this.Controls.Add(this.textBox_regimenes);
            this.Controls.Add(this.textBox_telefono);
            this.Controls.Add(this.textBox_mail);
            this.Controls.Add(this.textBox_pais);
            this.Controls.Add(this.textBox_ciudad);
            this.Controls.Add(this.textBox_nombre);
            this.Name = "ABMHotel_Alta";
            this.Text = "Alta";
            ((System.ComponentModel.ISupportInitialize)(this.estrellas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_ciudad;
        private System.Windows.Forms.TextBox textBox_pais;
        private System.Windows.Forms.TextBox textBox_mail;
        private System.Windows.Forms.TextBox textBox_telefono;
        private System.Windows.Forms.TextBox textBox_regimenes;
        private System.Windows.Forms.TextBox textBox_direccion;
        private System.Windows.Forms.TextBox textBox_fecha;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown estrellas;
    }
}