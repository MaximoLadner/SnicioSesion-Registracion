namespace DealerMasterCaculator
{
    partial class FormRegister
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtfechanacimiento = new System.Windows.Forms.TextBox();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.txtcontrasena = new System.Windows.Forms.TextBox();
            this.btningresar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(68, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de nacimiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(68, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 30);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 30);
            this.label4.TabIndex = 3;
            this.label4.Text = "Correo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MingLiU_HKSCS-ExtB", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(222, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 37);
            this.label6.TabIndex = 6;
            this.label6.Text = "Registro";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(311, 119);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(205, 22);
            this.txtnombre.TabIndex = 7;
            // 
            // txtfechanacimiento
            // 
            this.txtfechanacimiento.Location = new System.Drawing.Point(311, 163);
            this.txtfechanacimiento.Name = "txtfechanacimiento";
            this.txtfechanacimiento.Size = new System.Drawing.Size(205, 22);
            this.txtfechanacimiento.TabIndex = 8;
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(311, 214);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.Size = new System.Drawing.Size(205, 22);
            this.txtcorreo.TabIndex = 9;
            // 
            // txtcontrasena
            // 
            this.txtcontrasena.Location = new System.Drawing.Point(311, 261);
            this.txtcontrasena.Name = "txtcontrasena";
            this.txtcontrasena.PasswordChar = '*';
            this.txtcontrasena.Size = new System.Drawing.Size(205, 22);
            this.txtcontrasena.TabIndex = 10;
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(137, 344);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(155, 49);
            this.btningresar.TabIndex = 11;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(376, 344);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(155, 49);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(651, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btningresar);
            this.Controls.Add(this.txtcontrasena);
            this.Controls.Add(this.txtcorreo);
            this.Controls.Add(this.txtfechanacimiento);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtfechanacimiento;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.TextBox txtcontrasena;
        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}