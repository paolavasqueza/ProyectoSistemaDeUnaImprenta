namespace sistema_imprenta
{
    partial class login
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.CodigotextBox = new System.Windows.Forms.TextBox();
            this.ClavetextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.Cancelarbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CodigotextBox
            // 
            this.CodigotextBox.Location = new System.Drawing.Point(70, 28);
            this.CodigotextBox.Name = "CodigotextBox";
            this.CodigotextBox.Size = new System.Drawing.Size(177, 20);
            this.CodigotextBox.TabIndex = 1;
            // 
            // ClavetextBox
            // 
            this.ClavetextBox.Location = new System.Drawing.Point(70, 77);
            this.ClavetextBox.Name = "ClavetextBox";
            this.ClavetextBox.PasswordChar = '*';
            this.ClavetextBox.Size = new System.Drawing.Size(177, 20);
            this.ClavetextBox.TabIndex = 2;
            this.ClavetextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.BackColor = System.Drawing.Color.MistyRose;
            this.Aceptarbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptarbutton.Image = global::sistema_imprenta.Properties.Resources.comprobar__1_;
            this.Aceptarbutton.Location = new System.Drawing.Point(58, 122);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(89, 29);
            this.Aceptarbutton.TabIndex = 7;
            this.Aceptarbutton.Text = "Aceptar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptarbutton.UseVisualStyleBackColor = false;
            this.Aceptarbutton.Click += new System.EventHandler(this.Aceptarbutton_Click);
            // 
            // Cancelarbutton
            // 
            this.Cancelarbutton.BackColor = System.Drawing.Color.MistyRose;
            this.Cancelarbutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Cancelarbutton.Image = global::sistema_imprenta.Properties.Resources.cerrar__1_;
            this.Cancelarbutton.Location = new System.Drawing.Point(160, 122);
            this.Cancelarbutton.Name = "Cancelarbutton";
            this.Cancelarbutton.Size = new System.Drawing.Size(88, 29);
            this.Cancelarbutton.TabIndex = 6;
            this.Cancelarbutton.Text = "Cancelar";
            this.Cancelarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Cancelarbutton.UseVisualStyleBackColor = false;
            this.Cancelarbutton.Click += new System.EventHandler(this.Cancelarbutton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_imprenta.Properties.Resources.login__1_;
            this.pictureBox1.Location = new System.Drawing.Point(265, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 116);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AcceptButton = this.Aceptarbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.CancelButton = this.Cancelarbutton;
            this.ClientSize = new System.Drawing.Size(399, 170);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.Cancelarbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClavetextBox);
            this.Controls.Add(this.CodigotextBox);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Iniciar Sesión ";
            this.Load += new System.EventHandler(this.login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox CodigotextBox;
        private System.Windows.Forms.TextBox ClavetextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.Button Cancelarbutton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

