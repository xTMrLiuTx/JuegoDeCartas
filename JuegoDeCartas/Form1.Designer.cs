namespace JuegoDeCartas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnJugar = new Button();
            listBoxJugador1 = new ListBox();
            listBoxJugador2 = new ListBox();
            listBoxJugador3 = new ListBox();
            lblGanadorFinal = new Label();
            label2 = new Label();
            btnBarajear = new Button();
            btnRepartir = new Button();
            btnCalcularGanador = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSalir = new Button();
            label5 = new Label();
            listBoxPozo = new ListBox();
            label6 = new Label();
            btnNuevoJuego = new Button();
            SuspendLayout();
            // 
            // btnJugar
            // 
            btnJugar.BackColor = Color.Red;
            btnJugar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnJugar.Location = new Point(274, 25);
            btnJugar.Name = "btnJugar";
            btnJugar.Size = new Size(98, 38);
            btnJugar.TabIndex = 0;
            btnJugar.Text = "JUGAR";
            btnJugar.UseVisualStyleBackColor = false;
            btnJugar.Click += btnJugar_Click;
            // 
            // listBoxJugador1
            // 
            listBoxJugador1.BackColor = Color.FromArgb(192, 255, 192);
            listBoxJugador1.FormattingEnabled = true;
            listBoxJugador1.ItemHeight = 15;
            listBoxJugador1.Location = new Point(51, 121);
            listBoxJugador1.Name = "listBoxJugador1";
            listBoxJugador1.Size = new Size(120, 124);
            listBoxJugador1.TabIndex = 1;
            // 
            // listBoxJugador2
            // 
            listBoxJugador2.BackColor = Color.FromArgb(192, 255, 192);
            listBoxJugador2.FormattingEnabled = true;
            listBoxJugador2.ItemHeight = 15;
            listBoxJugador2.Location = new Point(212, 121);
            listBoxJugador2.Name = "listBoxJugador2";
            listBoxJugador2.Size = new Size(120, 124);
            listBoxJugador2.TabIndex = 2;
            // 
            // listBoxJugador3
            // 
            listBoxJugador3.BackColor = Color.FromArgb(192, 255, 192);
            listBoxJugador3.FormattingEnabled = true;
            listBoxJugador3.ItemHeight = 15;
            listBoxJugador3.Location = new Point(372, 121);
            listBoxJugador3.Name = "listBoxJugador3";
            listBoxJugador3.Size = new Size(120, 124);
            listBoxJugador3.TabIndex = 3;
            // 
            // lblGanadorFinal
            // 
            lblGanadorFinal.AutoSize = true;
            lblGanadorFinal.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblGanadorFinal.Location = new Point(85, 272);
            lblGanadorFinal.Name = "lblGanadorFinal";
            lblGanadorFinal.Size = new Size(0, 25);
            lblGanadorFinal.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(372, 267);
            label2.Name = "label2";
            label2.Size = new Size(0, 30);
            label2.TabIndex = 5;
            // 
            // btnBarajear
            // 
            btnBarajear.BackColor = Color.Yellow;
            btnBarajear.Font = new Font("Arial Black", 15.75F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point);
            btnBarajear.ForeColor = Color.Black;
            btnBarajear.Image = (Image)resources.GetObject("btnBarajear.Image");
            btnBarajear.Location = new Point(5, 12);
            btnBarajear.Name = "btnBarajear";
            btnBarajear.Size = new Size(146, 80);
            btnBarajear.TabIndex = 6;
            btnBarajear.Text = "BARAJEAR";
            btnBarajear.UseVisualStyleBackColor = false;
            btnBarajear.Click += btnBarajear_Click;
            // 
            // btnRepartir
            // 
            btnRepartir.BackColor = Color.LightSteelBlue;
            btnRepartir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnRepartir.ForeColor = Color.Black;
            btnRepartir.Location = new Point(168, 25);
            btnRepartir.Name = "btnRepartir";
            btnRepartir.Size = new Size(100, 38);
            btnRepartir.TabIndex = 7;
            btnRepartir.Text = "REPARTIR";
            btnRepartir.UseVisualStyleBackColor = false;
            btnRepartir.Click += btnRepartir_Click;
            // 
            // btnCalcularGanador
            // 
            btnCalcularGanador.BackColor = Color.Lime;
            btnCalcularGanador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCalcularGanador.Location = new Point(372, 25);
            btnCalcularGanador.Name = "btnCalcularGanador";
            btnCalcularGanador.Size = new Size(192, 38);
            btnCalcularGanador.TabIndex = 8;
            btnCalcularGanador.Text = "CALCULAR GANADOR";
            btnCalcularGanador.UseVisualStyleBackColor = false;
            btnCalcularGanador.Click += btnCalcularGanador_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(51, 95);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 9;
            label1.Text = "JUGADOR 1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(212, 95);
            label3.Name = "label3";
            label3.Size = new Size(100, 23);
            label3.TabIndex = 10;
            label3.Text = "JUGADOR 2";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(372, 95);
            label4.Name = "label4";
            label4.Size = new Size(100, 23);
            label4.TabIndex = 11;
            label4.Text = "JUGADOR 3";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Lime;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalir.Image = Properties.Resources.SALIR;
            btnSalir.Location = new Point(536, 267);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(80, 75);
            btnSalir.TabIndex = 12;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(544, 241);
            label5.Name = "label5";
            label5.Size = new Size(56, 23);
            label5.TabIndex = 13;
            label5.Text = "SALIR";
            // 
            // listBoxPozo
            // 
            listBoxPozo.BackColor = Color.FromArgb(192, 255, 192);
            listBoxPozo.FormattingEnabled = true;
            listBoxPozo.ItemHeight = 15;
            listBoxPozo.Location = new Point(560, 114);
            listBoxPozo.Name = "listBoxPozo";
            listBoxPozo.Size = new Size(120, 124);
            listBoxPozo.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Narrow", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(560, 88);
            label6.Name = "label6";
            label6.Size = new Size(54, 23);
            label6.TabIndex = 15;
            label6.Text = "POZO";
            // 
            // btnNuevoJuego
            // 
            btnNuevoJuego.BackColor = Color.Lime;
            btnNuevoJuego.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnNuevoJuego.Image = Properties.Resources.NUEVOJUEGO;
            btnNuevoJuego.Location = new Point(570, 5);
            btnNuevoJuego.Name = "btnNuevoJuego";
            btnNuevoJuego.Size = new Size(112, 80);
            btnNuevoJuego.TabIndex = 16;
            btnNuevoJuego.UseVisualStyleBackColor = false;
            btnNuevoJuego.Click += btnNuevoJuego_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(721, 343);
            Controls.Add(btnNuevoJuego);
            Controls.Add(label6);
            Controls.Add(listBoxPozo);
            Controls.Add(label5);
            Controls.Add(btnSalir);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(btnCalcularGanador);
            Controls.Add(btnRepartir);
            Controls.Add(btnBarajear);
            Controls.Add(label2);
            Controls.Add(lblGanadorFinal);
            Controls.Add(listBoxJugador3);
            Controls.Add(listBoxJugador2);
            Controls.Add(listBoxJugador1);
            Controls.Add(btnJugar);
            Name = "Form1";
            Text = "JuegoDeCartas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnJugar;
        private ListBox listBoxJugador1;
        private ListBox listBoxJugador2;
        private ListBox listBoxJugador3;
        private Label lblGanadorFinal;
        private Label label2;
        private Button btnBarajear;
        private Button btnRepartir;
        private Button btnCalcularGanador;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnSalir;
        private Label label5;
        private ListBox listBoxPozo;
        private Label label6;
        private Button btnNuevoJuego;
    }
}