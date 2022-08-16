namespace sistema_imprenta
{
    partial class Listadeproductos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listadeproductos));
            this.textBoxcliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productosdataGridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.comboBoxproducto = new System.Windows.Forms.ComboBox();
            this.comboBoxtamaño = new System.Windows.Forms.ComboBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.textBoxentrega = new System.Windows.Forms.TextBox();
            this.textBoxprecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Aceptarbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productosdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxcliente
            // 
            this.textBoxcliente.Location = new System.Drawing.Point(269, 15);
            this.textBoxcliente.Name = "textBoxcliente";
            this.textBoxcliente.Size = new System.Drawing.Size(193, 20);
            this.textBoxcliente.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(142, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dias de entrega:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Cantidad:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(191, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 20;
            this.label4.Text = "Tamaño:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(179, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Productos:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Cliente:";
            // 
            // productosdataGridView
            // 
            this.productosdataGridView.BackgroundColor = System.Drawing.Color.MistyRose;
            this.productosdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productosdataGridView.Location = new System.Drawing.Point(12, 268);
            this.productosdataGridView.Name = "productosdataGridView";
            this.productosdataGridView.Size = new System.Drawing.Size(680, 170);
            this.productosdataGridView.TabIndex = 17;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // comboBoxproducto
            // 
            this.comboBoxproducto.FormattingEnabled = true;
            this.comboBoxproducto.Items.AddRange(new object[] {
            "Factura",
            "Factura por Honorarios",
            "Ricibos",
            "Recibos para Rifa",
            "Revistas ",
            "Libros",
            "Libretas",
            "Sobres",
            "Papel membretado ",
            "Afiches "});
            this.comboBoxproducto.Location = new System.Drawing.Point(269, 52);
            this.comboBoxproducto.Name = "comboBoxproducto";
            this.comboBoxproducto.Size = new System.Drawing.Size(192, 21);
            this.comboBoxproducto.TabIndex = 34;
            // 
            // comboBoxtamaño
            // 
            this.comboBoxtamaño.FormattingEnabled = true;
            this.comboBoxtamaño.Items.AddRange(new object[] {
            "Cuarto de carta (4.2 x 5.5) pulgadas",
            "Rifa (2.5 x 11) pulgadas",
            "Media Carta (8.5 x 5.5) pulgadas",
            "Carta (8.5 x 11) pulgadas  ",
            "Oficio (8.5 x 14) pulgadas",
            "Folio (8.5 x 13)  pulgadas",
            "Anchura de oficio (14 x 8.5) pulgadas",
            "Tabloide (11 x 17) Pulgadas",
            "A3 (297 x 420) Milimetros",
            "A4 (210 x 287) Milimetros",
            "A5 (148 x 210) Milimetros",
            ""});
            this.comboBoxtamaño.Location = new System.Drawing.Point(270, 87);
            this.comboBoxtamaño.Name = "comboBoxtamaño";
            this.comboBoxtamaño.Size = new System.Drawing.Size(192, 21);
            this.comboBoxtamaño.TabIndex = 35;
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Location = new System.Drawing.Point(270, 123);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(191, 20);
            this.textBoxcantidad.TabIndex = 38;
            // 
            // textBoxentrega
            // 
            this.textBoxentrega.Location = new System.Drawing.Point(270, 158);
            this.textBoxentrega.Name = "textBoxentrega";
            this.textBoxentrega.Size = new System.Drawing.Size(191, 20);
            this.textBoxentrega.TabIndex = 39;
            // 
            // textBoxprecio
            // 
            this.textBoxprecio.Location = new System.Drawing.Point(270, 192);
            this.textBoxprecio.Name = "textBoxprecio";
            this.textBoxprecio.Size = new System.Drawing.Size(191, 20);
            this.textBoxprecio.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(197, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Precio:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::sistema_imprenta.Properties.Resources._1234;
            this.pictureBox3.Location = new System.Drawing.Point(22, 130);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(109, 87);
            this.pictureBox3.TabIndex = 43;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::sistema_imprenta.Properties.Resources._1231;
            this.pictureBox2.Location = new System.Drawing.Point(22, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 108);
            this.pictureBox2.TabIndex = 42;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = global::sistema_imprenta.Properties.Resources.guardar_el_archivo;
            this.button2.Location = new System.Drawing.Point(406, 223);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(89, 29);
            this.button2.TabIndex = 32;
            this.button2.Text = "Guardar";
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MistyRose;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Image = global::sistema_imprenta.Properties.Resources.eliminar;
            this.button3.Location = new System.Drawing.Point(311, 223);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(89, 29);
            this.button3.TabIndex = 31;
            this.button3.Text = "Eliminar";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MistyRose;
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Image = global::sistema_imprenta.Properties.Resources.deshacer;
            this.button1.Location = new System.Drawing.Point(216, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 29);
            this.button1.TabIndex = 30;
            this.button1.Text = "Modificar";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Aceptarbutton
            // 
            this.Aceptarbutton.BackColor = System.Drawing.Color.MistyRose;
            this.Aceptarbutton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Aceptarbutton.Image = global::sistema_imprenta.Properties.Resources.boton_de_simbolo_mas__1_;
            this.Aceptarbutton.Location = new System.Drawing.Point(121, 223);
            this.Aceptarbutton.Name = "Aceptarbutton";
            this.Aceptarbutton.Size = new System.Drawing.Size(89, 29);
            this.Aceptarbutton.TabIndex = 29;
            this.Aceptarbutton.Text = "Agregar";
            this.Aceptarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Aceptarbutton.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistema_imprenta.Properties.Resources.q21;
            this.pictureBox1.Location = new System.Drawing.Point(501, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 221);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // Listadeproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(705, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBoxprecio);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxentrega);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.comboBoxtamaño);
            this.Controls.Add(this.comboBoxproducto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Aceptarbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxcliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productosdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Listadeproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Lista de Productos";
            this.Load += new System.EventHandler(this.Listadeproductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productosdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Aceptarbutton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxcliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView productosdataGridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox comboBoxproducto;
        private System.Windows.Forms.ComboBox comboBoxtamaño;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.TextBox textBoxentrega;
        private System.Windows.Forms.TextBox textBoxprecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}