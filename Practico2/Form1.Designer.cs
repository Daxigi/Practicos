
namespace Practico2
{
    partial class Form1
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
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TDni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LMod = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TTel = new System.Windows.Forms.TextBox();
            this.CNaranja = new System.Windows.Forms.CheckBox();
            this.CVisa = new System.Windows.Forms.CheckBox();
            this.CMC = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.BSalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BEliminar = new System.Windows.Forms.Button();
            this.BGuardar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TNombre.Location = new System.Drawing.Point(209, 181);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 0;
            this.TNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TNombre_KeyPress);
            // 
            // TApellido
            // 
            this.TApellido.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TApellido.Location = new System.Drawing.Point(209, 146);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 1;
            this.TApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TApellido_KeyPress);
            // 
            // TDni
            // 
            this.TDni.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TDni.Location = new System.Drawing.Point(209, 110);
            this.TDni.Name = "TDni";
            this.TDni.Size = new System.Drawing.Size(100, 20);
            this.TDni.TabIndex = 2;
            this.TDni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TDni_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(79, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nombre y Apellido:";
            // 
            // LMod
            // 
            this.LMod.AutoSize = true;
            this.LMod.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LMod.ForeColor = System.Drawing.Color.Red;
            this.LMod.Location = new System.Drawing.Point(231, 58);
            this.LMod.Name = "LMod";
            this.LMod.Size = new System.Drawing.Size(49, 13);
            this.LMod.TabIndex = 4;
            this.LMod.Text = "modificar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(79, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "DNI*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Location = new System.Drawing.Point(79, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellido*";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.Location = new System.Drawing.Point(79, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(79, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Telefono";
            // 
            // TTel
            // 
            this.TTel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.TTel.Location = new System.Drawing.Point(209, 218);
            this.TTel.Name = "TTel";
            this.TTel.Size = new System.Drawing.Size(100, 20);
            this.TTel.TabIndex = 10;
            // 
            // CNaranja
            // 
            this.CNaranja.AutoSize = true;
            this.CNaranja.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CNaranja.Location = new System.Drawing.Point(234, 262);
            this.CNaranja.Name = "CNaranja";
            this.CNaranja.Size = new System.Drawing.Size(63, 17);
            this.CNaranja.TabIndex = 12;
            this.CNaranja.Text = "Naranja";
            this.CNaranja.UseVisualStyleBackColor = false;
            // 
            // CVisa
            // 
            this.CVisa.AutoSize = true;
            this.CVisa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CVisa.Location = new System.Drawing.Point(234, 285);
            this.CVisa.Name = "CVisa";
            this.CVisa.Size = new System.Drawing.Size(46, 17);
            this.CVisa.TabIndex = 13;
            this.CVisa.Text = "Visa";
            this.CVisa.UseVisualStyleBackColor = false;
            // 
            // CMC
            // 
            this.CMC.AutoSize = true;
            this.CMC.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CMC.Location = new System.Drawing.Point(234, 308);
            this.CMC.Name = "CMC";
            this.CMC.Size = new System.Drawing.Size(78, 17);
            this.CMC.TabIndex = 14;
            this.CMC.Text = "MarterCard";
            this.CMC.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label6.Location = new System.Drawing.Point(82, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Tarjeta de credito:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(434, 322);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hombre";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(540, 322);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(51, 17);
            this.radioButton2.TabIndex = 18;
            this.radioButton2.Text = "Mujer";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton2_Click);
            // 
            // BSalir
            // 
            this.BSalir.Image = global::Practico2.Properties.Resources.salir;
            this.BSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BSalir.Location = new System.Drawing.Point(488, 358);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(103, 55);
            this.BSalir.TabIndex = 19;
            this.BSalir.Text = "Salir";
            this.BSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BSalir.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Practico2.Properties.Resources.hombre;
            this.pictureBox1.Location = new System.Drawing.Point(422, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(193, 208);
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // BEliminar
            // 
            this.BEliminar.Image = global::Practico2.Properties.Resources.eliminar;
            this.BEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BEliminar.Location = new System.Drawing.Point(292, 357);
            this.BEliminar.Name = "BEliminar";
            this.BEliminar.Size = new System.Drawing.Size(106, 56);
            this.BEliminar.TabIndex = 9;
            this.BEliminar.Text = "Eliminar";
            this.BEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BEliminar.UseVisualStyleBackColor = true;
            this.BEliminar.Click += new System.EventHandler(this.BEliminar_Click);
            // 
            // BGuardar
            // 
            this.BGuardar.Image = global::Practico2.Properties.Resources.guardar;
            this.BGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BGuardar.Location = new System.Drawing.Point(99, 354);
            this.BGuardar.Name = "BGuardar";
            this.BGuardar.Size = new System.Drawing.Size(113, 59);
            this.BGuardar.TabIndex = 8;
            this.BGuardar.Text = "Guardar";
            this.BGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BGuardar.UseVisualStyleBackColor = true;
            this.BGuardar.Click += new System.EventHandler(this.BGuardar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(59, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 299);
            this.panel1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label7.Location = new System.Drawing.Point(289, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(185, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "NUEVO CLIENTE";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CMC);
            this.Controls.Add(this.CVisa);
            this.Controls.Add(this.CNaranja);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TTel);
            this.Controls.Add(this.BEliminar);
            this.Controls.Add(this.BGuardar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LMod);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TDni);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TDni;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LMod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BGuardar;
        private System.Windows.Forms.Button BEliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TTel;
        private System.Windows.Forms.CheckBox CNaranja;
        private System.Windows.Forms.CheckBox CVisa;
        private System.Windows.Forms.CheckBox CMC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button BSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
    }
}

