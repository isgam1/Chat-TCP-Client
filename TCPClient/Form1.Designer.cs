namespace TCPClient
{
    partial class Form1
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
            this.txtsend = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.BtnEnviar = new System.Windows.Forms.Button();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.TxtIPServer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.LblEstado = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtPuerto = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerBuscarMensajes = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtsend
            // 
            this.txtsend.Location = new System.Drawing.Point(13, 108);
            this.txtsend.Multiline = true;
            this.txtsend.Name = "txtsend";
            this.txtsend.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtsend.Size = new System.Drawing.Size(336, 90);
            this.txtsend.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 272);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox2.Size = new System.Drawing.Size(254, 119);
            this.textBox2.TabIndex = 1;
            // 
            // BtnEnviar
            // 
            this.BtnEnviar.Location = new System.Drawing.Point(364, 108);
            this.BtnEnviar.Name = "BtnEnviar";
            this.BtnEnviar.Size = new System.Drawing.Size(75, 23);
            this.BtnEnviar.TabIndex = 3;
            this.BtnEnviar.Text = "Send";
            this.BtnEnviar.UseVisualStyleBackColor = true;
            this.BtnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // BtnConectar
            // 
            this.BtnConectar.Location = new System.Drawing.Point(297, 40);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(75, 23);
            this.BtnConectar.TabIndex = 5;
            this.BtnConectar.Text = "Connect";
            this.BtnConectar.UseVisualStyleBackColor = true;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // TxtIPServer
            // 
            this.TxtIPServer.Location = new System.Drawing.Point(16, 40);
            this.TxtIPServer.Name = "TxtIPServer";
            this.TxtIPServer.Size = new System.Drawing.Size(147, 20);
            this.TxtIPServer.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "IP del Servidor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Escriba Mensaje:";
            // 
            // LblEstado
            // 
            this.LblEstado.AutoSize = true;
            this.LblEstado.Location = new System.Drawing.Point(393, 46);
            this.LblEstado.Name = "LblEstado";
            this.LblEstado.Size = new System.Drawing.Size(75, 13);
            this.LblEstado.TabIndex = 13;
            this.LblEstado.Text = "No conectado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(396, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Estado:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 253);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(100, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Mensajes recibidos:";
            // 
            // TxtPuerto
            // 
            this.TxtPuerto.Location = new System.Drawing.Point(188, 40);
            this.TxtPuerto.Name = "TxtPuerto";
            this.TxtPuerto.Size = new System.Drawing.Size(78, 20);
            this.TxtPuerto.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(185, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Puerto del Servidor";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBox1.Location = new System.Drawing.Point(290, 269);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 122);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerBuscarMensajes
            // 
            this.timerBuscarMensajes.Enabled = true;
            this.timerBuscarMensajes.Interval = 1000;
            this.timerBuscarMensajes.Tick += new System.EventHandler(this.timerBuscarMensajes_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "select archive";
            this.openFileDialog1.Filter = "Files|*.jpg;*.jpeg;*.png;*.pdf;*.xls;*.mp4;*.mp3;";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 419);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.TxtPuerto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.LblEstado);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TxtIPServer);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.BtnEnviar);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtsend);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsend;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button BtnEnviar;
        private System.Windows.Forms.Button BtnConectar;
        private System.Windows.Forms.TextBox TxtIPServer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label LblEstado;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtPuerto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timerBuscarMensajes;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

