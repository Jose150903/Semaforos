namespace Simulacion_Semaforo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ptbVerde = new System.Windows.Forms.PictureBox();
            this.ptbAmarillo = new System.Windows.Forms.PictureBox();
            this.ptbRojo = new System.Windows.Forms.PictureBox();
            this.ptbRojo1 = new System.Windows.Forms.PictureBox();
            this.ptbAmarillo1 = new System.Windows.Forms.PictureBox();
            this.ptbVerde1 = new System.Windows.Forms.PictureBox();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnDetener = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.txtVerde = new System.Windows.Forms.TextBox();
            this.txtAmarillo = new System.Windows.Forms.TextBox();
            this.txtRojo = new System.Windows.Forms.TextBox();
            this.lblVerde = new System.Windows.Forms.Label();
            this.lblAmarillo = new System.Windows.Forms.Label();
            this.lblRojo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVerde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmarillo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRojo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRojo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmarillo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVerde1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbVerde
            // 
            this.ptbVerde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbVerde.Location = new System.Drawing.Point(400, 338);
            this.ptbVerde.Name = "ptbVerde";
            this.ptbVerde.Size = new System.Drawing.Size(33, 33);
            this.ptbVerde.TabIndex = 0;
            this.ptbVerde.TabStop = false;
            // 
            // ptbAmarillo
            // 
            this.ptbAmarillo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbAmarillo.Location = new System.Drawing.Point(400, 301);
            this.ptbAmarillo.Name = "ptbAmarillo";
            this.ptbAmarillo.Size = new System.Drawing.Size(33, 33);
            this.ptbAmarillo.TabIndex = 1;
            this.ptbAmarillo.TabStop = false;
            // 
            // ptbRojo
            // 
            this.ptbRojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbRojo.Location = new System.Drawing.Point(400, 264);
            this.ptbRojo.Name = "ptbRojo";
            this.ptbRojo.Size = new System.Drawing.Size(33, 33);
            this.ptbRojo.TabIndex = 2;
            this.ptbRojo.TabStop = false;
            // 
            // ptbRojo1
            // 
            this.ptbRojo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbRojo1.Location = new System.Drawing.Point(243, 336);
            this.ptbRojo1.Name = "ptbRojo1";
            this.ptbRojo1.Size = new System.Drawing.Size(33, 33);
            this.ptbRojo1.TabIndex = 3;
            this.ptbRojo1.TabStop = false;
            this.ptbRojo1.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // ptbAmarillo1
            // 
            this.ptbAmarillo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbAmarillo1.Location = new System.Drawing.Point(205, 336);
            this.ptbAmarillo1.Name = "ptbAmarillo1";
            this.ptbAmarillo1.Size = new System.Drawing.Size(33, 33);
            this.ptbAmarillo1.TabIndex = 4;
            this.ptbAmarillo1.TabStop = false;
            // 
            // ptbVerde1
            // 
            this.ptbVerde1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ptbVerde1.Location = new System.Drawing.Point(167, 336);
            this.ptbVerde1.Name = "ptbVerde1";
            this.ptbVerde1.Size = new System.Drawing.Size(33, 33);
            this.ptbVerde1.TabIndex = 5;
            this.ptbVerde1.TabStop = false;
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(101, 459);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 34);
            this.btnIniciar.TabIndex = 6;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // btnDetener
            // 
            this.btnDetener.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDetener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetener.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetener.Location = new System.Drawing.Point(258, 459);
            this.btnDetener.Name = "btnDetener";
            this.btnDetener.Size = new System.Drawing.Size(75, 34);
            this.btnDetener.TabIndex = 7;
            this.btnDetener.Text = "Detener";
            this.btnDetener.UseVisualStyleBackColor = false;
            this.btnDetener.Click += new System.EventHandler(this.BtnDetener_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApagar.Location = new System.Drawing.Point(447, 459);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(75, 34);
            this.btnApagar.TabIndex = 8;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = false;
            this.btnApagar.Click += new System.EventHandler(this.BtnApagar_Click);
            // 
            // txtVerde
            // 
            this.txtVerde.Location = new System.Drawing.Point(108, 424);
            this.txtVerde.Name = "txtVerde";
            this.txtVerde.Size = new System.Drawing.Size(63, 20);
            this.txtVerde.TabIndex = 9;
            this.txtVerde.Text = "4";
            // 
            // txtAmarillo
            // 
            this.txtAmarillo.Location = new System.Drawing.Point(264, 424);
            this.txtAmarillo.Name = "txtAmarillo";
            this.txtAmarillo.Size = new System.Drawing.Size(63, 20);
            this.txtAmarillo.TabIndex = 10;
            this.txtAmarillo.Text = "4";
            // 
            // txtRojo
            // 
            this.txtRojo.Location = new System.Drawing.Point(456, 424);
            this.txtRojo.Name = "txtRojo";
            this.txtRojo.Size = new System.Drawing.Size(63, 20);
            this.txtRojo.TabIndex = 11;
            this.txtRojo.Text = "4";
            // 
            // lblVerde
            // 
            this.lblVerde.AutoSize = true;
            this.lblVerde.BackColor = System.Drawing.Color.Transparent;
            this.lblVerde.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerde.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblVerde.Location = new System.Drawing.Point(100, 399);
            this.lblVerde.Name = "lblVerde";
            this.lblVerde.Size = new System.Drawing.Size(85, 13);
            this.lblVerde.TabIndex = 12;
            this.lblVerde.Text = "Tiempo Verde";
            // 
            // lblAmarillo
            // 
            this.lblAmarillo.AutoSize = true;
            this.lblAmarillo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmarillo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmarillo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAmarillo.Location = new System.Drawing.Point(249, 399);
            this.lblAmarillo.Name = "lblAmarillo";
            this.lblAmarillo.Size = new System.Drawing.Size(96, 13);
            this.lblAmarillo.TabIndex = 13;
            this.lblAmarillo.Text = "Tiempo Amarillo";
            // 
            // lblRojo
            // 
            this.lblRojo.AutoSize = true;
            this.lblRojo.BackColor = System.Drawing.Color.Transparent;
            this.lblRojo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRojo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblRojo.Location = new System.Drawing.Point(448, 399);
            this.lblRojo.Name = "lblRojo";
            this.lblRojo.Size = new System.Drawing.Size(78, 13);
            this.lblRojo.TabIndex = 14;
            this.lblRojo.Text = "Tiempo Rojo";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(397, 261);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 113);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(163, 334);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(116, 37);
            this.pictureBox2.TabIndex = 16;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simulacion_Semaforo.Properties.Resources.cruce_vial2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(626, 544);
            this.Controls.Add(this.ptbVerde1);
            this.Controls.Add(this.ptbAmarillo1);
            this.Controls.Add(this.ptbRojo1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.ptbRojo);
            this.Controls.Add(this.ptbAmarillo);
            this.Controls.Add(this.ptbVerde);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblRojo);
            this.Controls.Add(this.lblAmarillo);
            this.Controls.Add(this.lblVerde);
            this.Controls.Add(this.txtRojo);
            this.Controls.Add(this.txtAmarillo);
            this.Controls.Add(this.txtVerde);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnDetener);
            this.Controls.Add(this.btnIniciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbVerde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmarillo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRojo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbRojo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAmarillo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbVerde1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbVerde;
        private System.Windows.Forms.PictureBox ptbAmarillo;
        private System.Windows.Forms.PictureBox ptbRojo;
        private System.Windows.Forms.PictureBox ptbRojo1;
        private System.Windows.Forms.PictureBox ptbAmarillo1;
        private System.Windows.Forms.PictureBox ptbVerde1;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnDetener;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.TextBox txtVerde;
        private System.Windows.Forms.TextBox txtAmarillo;
        private System.Windows.Forms.TextBox txtRojo;
        private System.Windows.Forms.Label lblVerde;
        private System.Windows.Forms.Label lblAmarillo;
        private System.Windows.Forms.Label lblRojo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

