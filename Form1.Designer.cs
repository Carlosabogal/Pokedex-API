namespace FormPokedex
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNamePokemon = new System.Windows.Forms.TextBox();
            this.btnIngresarPokemon = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cbBTipos = new System.Windows.Forms.ComboBox();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblLife = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcPokemonImage = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lblTipos2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnterior = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lableSiguiente = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPokemonImage)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(171)))), ((int)(((byte)(98)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(805, 542);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtNamePokemon
            // 
            this.txtNamePokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(171)))), ((int)(((byte)(98)))));
            this.txtNamePokemon.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNamePokemon.Location = new System.Drawing.Point(94, 477);
            this.txtNamePokemon.Name = "txtNamePokemon";
            this.txtNamePokemon.Size = new System.Drawing.Size(123, 15);
            this.txtNamePokemon.TabIndex = 1;
            this.txtNamePokemon.TextChanged += new System.EventHandler(this.txtNamePokemon_TextChanged);
            // 
            // btnIngresarPokemon
            // 
            this.btnIngresarPokemon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btnIngresarPokemon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIngresarPokemon.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnIngresarPokemon.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIngresarPokemon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarPokemon.ForeColor = System.Drawing.Color.Yellow;
            this.btnIngresarPokemon.Location = new System.Drawing.Point(52, 391);
            this.btnIngresarPokemon.Name = "btnIngresarPokemon";
            this.btnIngresarPokemon.Size = new System.Drawing.Size(30, 29);
            this.btnIngresarPokemon.TabIndex = 2;
            this.btnIngresarPokemon.Text = "o";
            this.btnIngresarPokemon.UseCompatibleTextRendering = true;
            this.btnIngresarPokemon.UseVisualStyleBackColor = false;
            this.btnIngresarPokemon.Click += new System.EventHandler(this.btnIngresarPokemon_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(82, 268);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(11, 16);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "-";
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.BackColor = System.Drawing.Color.White;
            this.lblNumero.Location = new System.Drawing.Point(82, 310);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(11, 16);
            this.lblNumero.TabIndex = 4;
            this.lblNumero.Text = "-";
            this.lblNumero.Click += new System.EventHandler(this.lblNumero_Click);
            // 
            // cbBTipos
            // 
            this.cbBTipos.FormattingEnabled = true;
            this.cbBTipos.Location = new System.Drawing.Point(476, 331);
            this.cbBTipos.Name = "cbBTipos";
            this.cbBTipos.Size = new System.Drawing.Size(121, 24);
            this.cbBTipos.TabIndex = 5;
            this.cbBTipos.SelectedIndexChanged += new System.EventHandler(this.cbBTipos_SelectedIndexChanged);
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.BackColor = System.Drawing.Color.White;
            this.lblPeso.Location = new System.Drawing.Point(266, 152);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(11, 16);
            this.lblPeso.TabIndex = 7;
            this.lblPeso.Text = "-";
            this.lblPeso.Click += new System.EventHandler(this.lblPeso_Click);
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.BackColor = System.Drawing.Color.White;
            this.lblAltura.Location = new System.Drawing.Point(266, 200);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(11, 16);
            this.lblAltura.TabIndex = 8;
            this.lblAltura.Text = "-";
            // 
            // lblLife
            // 
            this.lblLife.AutoSize = true;
            this.lblLife.BackColor = System.Drawing.Color.White;
            this.lblLife.Location = new System.Drawing.Point(266, 241);
            this.lblLife.Name = "lblLife";
            this.lblLife.Size = new System.Drawing.Size(11, 16);
            this.lblLife.TabIndex = 9;
            this.lblLife.Text = "-";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.BackColor = System.Drawing.Color.White;
            this.lblTipo.Location = new System.Drawing.Point(235, 295);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(11, 16);
            this.lblTipo.TabIndex = 10;
            this.lblTipo.Text = "-";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcPokemonImage
            // 
            this.pcPokemonImage.BackColor = System.Drawing.Color.White;
            this.pcPokemonImage.Location = new System.Drawing.Point(52, 141);
            this.pcPokemonImage.Name = "pcPokemonImage";
            this.pcPokemonImage.Size = new System.Drawing.Size(156, 124);
            this.pcPokemonImage.TabIndex = 11;
            this.pcPokemonImage.TabStop = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(476, 175);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(265, 132);
            this.listBox1.TabIndex = 12;
            // 
            // lblTipos2
            // 
            this.lblTipos2.AutoSize = true;
            this.lblTipos2.BackColor = System.Drawing.Color.White;
            this.lblTipos2.Location = new System.Drawing.Point(235, 331);
            this.lblTipos2.Name = "lblTipos2";
            this.lblTipos2.Size = new System.Drawing.Size(11, 16);
            this.lblTipos2.TabIndex = 13;
            this.lblTipos2.Text = "-";
            this.lblTipos2.Click += new System.EventHandler(this.lblTipos2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(235, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tipos";
            // 
            // lblAnterior
            // 
            this.lblAnterior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lblAnterior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lblAnterior.FlatAppearance.BorderSize = 0;
            this.lblAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblAnterior.ForeColor = System.Drawing.Color.Yellow;
            this.lblAnterior.Location = new System.Drawing.Point(258, 427);
            this.lblAnterior.Name = "lblAnterior";
            this.lblAnterior.Size = new System.Drawing.Size(19, 25);
            this.lblAnterior.TabIndex = 15;
            this.lblAnterior.Text = "<";
            this.lblAnterior.UseVisualStyleBackColor = false;
            this.lblAnterior.Click += new System.EventHandler(this.lblAnterior_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(216, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "HP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(216, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(216, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Peso";
            // 
            // lableSiguiente
            // 
            this.lableSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.lableSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lableSiguiente.FlatAppearance.BorderSize = 0;
            this.lableSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lableSiguiente.ForeColor = System.Drawing.Color.Yellow;
            this.lableSiguiente.Location = new System.Drawing.Point(327, 427);
            this.lableSiguiente.Name = "lableSiguiente";
            this.lableSiguiente.Size = new System.Drawing.Size(19, 25);
            this.lableSiguiente.TabIndex = 20;
            this.lableSiguiente.Text = ">";
            this.lableSiguiente.UseVisualStyleBackColor = false;
            this.lableSiguiente.Click += new System.EventHandler(this.lableSiguiente_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(473, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ataques";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(473, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Movimientos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 570);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lableSiguiente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAnterior);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTipos2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pcPokemonImage);
            this.Controls.Add(this.lblTipo);
            this.Controls.Add(this.lblLife);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.cbBTipos);
            this.Controls.Add(this.lblNumero);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnIngresarPokemon);
            this.Controls.Add(this.txtNamePokemon);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcPokemonImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNamePokemon;
        private System.Windows.Forms.Button btnIngresarPokemon;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cbBTipos;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblLife;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pcPokemonImage;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblTipos2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lblAnterior;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button lableSiguiente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

