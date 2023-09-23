namespace Login_Form_Application
{
    partial class Menuform
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
            this.eliminar = new System.Windows.Forms.Button();
            this.borrar = new System.Windows.Forms.Button();
            this.insertar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_Naciminto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direcciontext = new System.Windows.Forms.TextBox();
            this.telfonotext = new System.Windows.Forms.TextBox();
            this.apellidotext = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idtext = new System.Windows.Forms.TextBox();
            this.nombretext = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.fechatext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // eliminar
            // 
            this.eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.eliminar.Location = new System.Drawing.Point(500, 365);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 28;
            this.eliminar.Text = "Salir";
            this.eliminar.UseVisualStyleBackColor = false;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // borrar
            // 
            this.borrar.BackColor = System.Drawing.Color.Gray;
            this.borrar.Location = new System.Drawing.Point(383, 365);
            this.borrar.Name = "borrar";
            this.borrar.Size = new System.Drawing.Size(75, 23);
            this.borrar.TabIndex = 27;
            this.borrar.Text = "Borrar";
            this.borrar.UseVisualStyleBackColor = false;
            this.borrar.Click += new System.EventHandler(this.borrar_Click);
            // 
            // insertar
            // 
            this.insertar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.insertar.Location = new System.Drawing.Point(256, 365);
            this.insertar.Name = "insertar";
            this.insertar.Size = new System.Drawing.Size(75, 23);
            this.insertar.TabIndex = 26;
            this.insertar.Text = "Insertar";
            this.insertar.UseVisualStyleBackColor = false;
            this.insertar.Click += new System.EventHandler(this.insertar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.OldLace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Nombres,
            this.Apellidos,
            this.Telefono,
            this.Direccion,
            this.Fecha_Naciminto});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(122, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(644, 150);
            this.dataGridView1.TabIndex = 25;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            // 
            // Nombres
            // 
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            // 
            // Apellidos
            // 
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            // 
            // Telefono
            // 
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            // 
            // Fecha_Naciminto
            // 
            this.Fecha_Naciminto.HeaderText = "Fecha_Naciminto";
            this.Fecha_Naciminto.Name = "Fecha_Naciminto";
            // 
            // direcciontext
            // 
            this.direcciontext.Location = new System.Drawing.Point(383, 269);
            this.direcciontext.Name = "direcciontext";
            this.direcciontext.Size = new System.Drawing.Size(100, 20);
            this.direcciontext.TabIndex = 23;
            // 
            // telfonotext
            // 
            this.telfonotext.Location = new System.Drawing.Point(122, 273);
            this.telfonotext.Name = "telfonotext";
            this.telfonotext.Size = new System.Drawing.Size(100, 20);
            this.telfonotext.TabIndex = 22;
            // 
            // apellidotext
            // 
            this.apellidotext.Location = new System.Drawing.Point(634, 211);
            this.apellidotext.Name = "apellidotext";
            this.apellidotext.Size = new System.Drawing.Size(100, 20);
            this.apellidotext.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 276);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefono";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(539, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Apellidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(279, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Nombres";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "ID";
            // 
            // idtext
            // 
            this.idtext.Location = new System.Drawing.Point(122, 215);
            this.idtext.Name = "idtext";
            this.idtext.Size = new System.Drawing.Size(100, 20);
            this.idtext.TabIndex = 15;
            this.idtext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombretext
            // 
            this.nombretext.Location = new System.Drawing.Point(383, 211);
            this.nombretext.Name = "nombretext";
            this.nombretext.Size = new System.Drawing.Size(100, 20);
            this.nombretext.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(530, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fecha Naciminto";
            // 
            // fechatext
            // 
            this.fechatext.Location = new System.Drawing.Point(634, 269);
            this.fechatext.Name = "fechatext";
            this.fechatext.Size = new System.Drawing.Size(100, 20);
            this.fechatext.TabIndex = 31;
            // 
            // Menuform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(855, 450);
            this.Controls.Add(this.fechatext);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nombretext);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.borrar);
            this.Controls.Add(this.insertar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.direcciontext);
            this.Controls.Add(this.telfonotext);
            this.Controls.Add(this.apellidotext);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idtext);
            this.Name = "Menuform";
            this.Text = "Registro de alumnos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button eliminar;
        private System.Windows.Forms.Button borrar;
        private System.Windows.Forms.Button insertar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox direcciontext;
        private System.Windows.Forms.TextBox telfonotext;
        private System.Windows.Forms.TextBox apellidotext;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idtext;
        private System.Windows.Forms.TextBox nombretext;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_Naciminto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox fechatext;
    }
}