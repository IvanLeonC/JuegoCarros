namespace JuegoCarros
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
            this.TimerMover = new System.Windows.Forms.Timer(this.components);
            this.Carro = new System.Windows.Forms.PictureBox();
            this.carJugadorIzq = new System.Windows.Forms.Timer(this.components);
            this.carJugadorDer = new System.Windows.Forms.Timer(this.components);
            this.coche2 = new System.Windows.Forms.PictureBox();
            this.coche1 = new System.Windows.Forms.PictureBox();
            this.coche3 = new System.Windows.Forms.PictureBox();
            this.coche1_mover = new System.Windows.Forms.Timer(this.components);
            this.coche2_mover = new System.Windows.Forms.Timer(this.components);
            this.coche3_mover = new System.Windows.Forms.Timer(this.components);
            this.Fin_text = new System.Windows.Forms.Label();
            this.score_text = new System.Windows.Forms.Label();
            this.Velocidad_text = new System.Windows.Forms.Label();
            this.nivel_text = new System.Windows.Forms.Label();
            this.gana_txt = new System.Windows.Forms.Label();
            this.MENU = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.nuevo_txt = new System.Windows.Forms.Label();
            this.nivel2_txt = new System.Windows.Forms.Label();
            this.nivel3_txt = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Carro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coche2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coche1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coche3)).BeginInit();
            this.MENU.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // TimerMover
            // 
            this.TimerMover.Enabled = true;
            this.TimerMover.Interval = 10;
            this.TimerMover.Tick += new System.EventHandler(this.TimerMover_Tick);
            // 
            // Carro
            // 
            this.Carro.BackColor = System.Drawing.Color.Transparent;
            this.Carro.Image = ((System.Drawing.Image)(resources.GetObject("Carro.Image")));
            this.Carro.Location = new System.Drawing.Point(163, 477);
            this.Carro.Name = "Carro";
            this.Carro.Size = new System.Drawing.Size(57, 111);
            this.Carro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Carro.TabIndex = 1;
            this.Carro.TabStop = false;
            // 
            // carJugadorIzq
            // 
            this.carJugadorIzq.Interval = 10;
            this.carJugadorIzq.Tick += new System.EventHandler(this.carJugadorIzq_Tick);
            // 
            // carJugadorDer
            // 
            this.carJugadorDer.Interval = 10;
            this.carJugadorDer.Tick += new System.EventHandler(this.carJugadorDer_Tick);
            // 
            // coche2
            // 
            this.coche2.BackColor = System.Drawing.Color.Transparent;
            this.coche2.Image = ((System.Drawing.Image)(resources.GetObject("coche2.Image")));
            this.coche2.Location = new System.Drawing.Point(163, -47);
            this.coche2.Name = "coche2";
            this.coche2.Size = new System.Drawing.Size(57, 113);
            this.coche2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coche2.TabIndex = 2;
            this.coche2.TabStop = false;
            // 
            // coche1
            // 
            this.coche1.BackColor = System.Drawing.Color.Transparent;
            this.coche1.Image = ((System.Drawing.Image)(resources.GetObject("coche1.Image")));
            this.coche1.Location = new System.Drawing.Point(313, 99);
            this.coche1.Name = "coche1";
            this.coche1.Size = new System.Drawing.Size(59, 113);
            this.coche1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coche1.TabIndex = 2;
            this.coche1.TabStop = false;
            // 
            // coche3
            // 
            this.coche3.BackColor = System.Drawing.Color.Transparent;
            this.coche3.Image = ((System.Drawing.Image)(resources.GetObject("coche3.Image")));
            this.coche3.Location = new System.Drawing.Point(12, 218);
            this.coche3.Name = "coche3";
            this.coche3.Size = new System.Drawing.Size(57, 111);
            this.coche3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coche3.TabIndex = 2;
            this.coche3.TabStop = false;
            // 
            // coche1_mover
            // 
            this.coche1_mover.Enabled = true;
            this.coche1_mover.Interval = 10;
            this.coche1_mover.Tick += new System.EventHandler(this.coche1_mover_Tick);
            // 
            // coche2_mover
            // 
            this.coche2_mover.Enabled = true;
            this.coche2_mover.Interval = 10;
            this.coche2_mover.Tick += new System.EventHandler(this.coche2_mover_Tick);
            // 
            // coche3_mover
            // 
            this.coche3_mover.Enabled = true;
            this.coche3_mover.Interval = 10;
            this.coche3_mover.Tick += new System.EventHandler(this.coche3_mover_Tick);
            // 
            // Fin_text
            // 
            this.Fin_text.AutoSize = true;
            this.Fin_text.BackColor = System.Drawing.Color.White;
            this.Fin_text.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fin_text.ForeColor = System.Drawing.Color.Red;
            this.Fin_text.Location = new System.Drawing.Point(45, 268);
            this.Fin_text.Name = "Fin_text";
            this.Fin_text.Size = new System.Drawing.Size(321, 60);
            this.Fin_text.TabIndex = 3;
            this.Fin_text.Text = "Fin del Juego";
            this.Fin_text.Visible = false;
            // 
            // score_text
            // 
            this.score_text.AutoSize = true;
            this.score_text.BackColor = System.Drawing.Color.White;
            this.score_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score_text.Location = new System.Drawing.Point(22, 29);
            this.score_text.Name = "score_text";
            this.score_text.Size = new System.Drawing.Size(90, 20);
            this.score_text.TabIndex = 4;
            this.score_text.Text = "Puntaje: 0";
            // 
            // Velocidad_text
            // 
            this.Velocidad_text.AutoSize = true;
            this.Velocidad_text.BackColor = System.Drawing.Color.White;
            this.Velocidad_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Velocidad_text.Location = new System.Drawing.Point(22, 60);
            this.Velocidad_text.Name = "Velocidad_text";
            this.Velocidad_text.Size = new System.Drawing.Size(108, 20);
            this.Velocidad_text.TabIndex = 6;
            this.Velocidad_text.Text = "Velocidad: 1";
            // 
            // nivel_text
            // 
            this.nivel_text.AutoSize = true;
            this.nivel_text.BackColor = System.Drawing.Color.White;
            this.nivel_text.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel_text.Location = new System.Drawing.Point(22, 93);
            this.nivel_text.Name = "nivel_text";
            this.nivel_text.Size = new System.Drawing.Size(67, 20);
            this.nivel_text.TabIndex = 7;
            this.nivel_text.Text = "Nivel: 1";
            // 
            // gana_txt
            // 
            this.gana_txt.AutoSize = true;
            this.gana_txt.BackColor = System.Drawing.Color.White;
            this.gana_txt.Font = new System.Drawing.Font("Berlin Sans FB", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gana_txt.ForeColor = System.Drawing.Color.Red;
            this.gana_txt.Location = new System.Drawing.Point(22, 189);
            this.gana_txt.Name = "gana_txt";
            this.gana_txt.Size = new System.Drawing.Size(371, 79);
            this.gana_txt.TabIndex = 8;
            this.gana_txt.Text = "¡GANASTE!";
            this.gana_txt.Visible = false;
            // 
            // MENU
            // 
            this.MENU.Controls.Add(this.score_text);
            this.MENU.Controls.Add(this.Velocidad_text);
            this.MENU.Controls.Add(this.nivel_text);
            this.MENU.Location = new System.Drawing.Point(423, 399);
            this.MENU.Name = "MENU";
            this.MENU.Size = new System.Drawing.Size(165, 134);
            this.MENU.TabIndex = 10;
            this.MENU.TabStop = false;
            this.MENU.Text = "MENU";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(5, 600);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Black;
            this.pictureBox4.Location = new System.Drawing.Point(399, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(5, 600);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.RosyBrown;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.Red;
            this.btnSalir.Location = new System.Drawing.Point(455, 320);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(111, 45);
            this.btnSalir.TabIndex = 9;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Visible = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.RosyBrown;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.Red;
            this.btnNuevo.Location = new System.Drawing.Point(455, 268);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(111, 45);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Visible = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(410, 0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(190, 154);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 12;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox1.Location = new System.Drawing.Point(86, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 605);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox2.Location = new System.Drawing.Point(280, -28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(15, 633);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // nuevo_txt
            // 
            this.nuevo_txt.AutoSize = true;
            this.nuevo_txt.BackColor = System.Drawing.Color.White;
            this.nuevo_txt.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nuevo_txt.ForeColor = System.Drawing.Color.Red;
            this.nuevo_txt.Location = new System.Drawing.Point(22, 328);
            this.nuevo_txt.Name = "nuevo_txt";
            this.nuevo_txt.Size = new System.Drawing.Size(371, 60);
            this.nuevo_txt.TabIndex = 14;
            this.nuevo_txt.Text = "Dale en Nuevo!";
            this.nuevo_txt.Visible = false;
            // 
            // nivel2_txt
            // 
            this.nivel2_txt.AutoSize = true;
            this.nivel2_txt.BackColor = System.Drawing.Color.White;
            this.nivel2_txt.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel2_txt.ForeColor = System.Drawing.Color.Red;
            this.nivel2_txt.Location = new System.Drawing.Point(107, 6);
            this.nivel2_txt.Name = "nivel2_txt";
            this.nivel2_txt.Size = new System.Drawing.Size(183, 60);
            this.nivel2_txt.TabIndex = 15;
            this.nivel2_txt.Text = "Nivel 2";
            this.nivel2_txt.Visible = false;
            // 
            // nivel3_txt
            // 
            this.nivel3_txt.AutoSize = true;
            this.nivel3_txt.BackColor = System.Drawing.Color.White;
            this.nivel3_txt.Font = new System.Drawing.Font("Berlin Sans FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nivel3_txt.ForeColor = System.Drawing.Color.Red;
            this.nivel3_txt.Location = new System.Drawing.Point(109, 9);
            this.nivel3_txt.Name = "nivel3_txt";
            this.nivel3_txt.Size = new System.Drawing.Size(181, 60);
            this.nivel3_txt.TabIndex = 16;
            this.nivel3_txt.Text = "Nivel 3";
            this.nivel3_txt.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.nivel3_txt);
            this.Controls.Add(this.nivel2_txt);
            this.Controls.Add(this.nuevo_txt);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.MENU);
            this.Controls.Add(this.gana_txt);
            this.Controls.Add(this.Fin_text);
            this.Controls.Add(this.coche3);
            this.Controls.Add(this.coche1);
            this.Controls.Add(this.coche2);
            this.Controls.Add(this.Carro);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.Carro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coche2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coche1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coche3)).EndInit();
            this.MENU.ResumeLayout(false);
            this.MENU.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer TimerMover;
        private System.Windows.Forms.PictureBox Carro;
        private System.Windows.Forms.Timer carJugadorIzq;
        private System.Windows.Forms.Timer carJugadorDer;
        private System.Windows.Forms.PictureBox coche2;
        private System.Windows.Forms.PictureBox coche1;
        private System.Windows.Forms.PictureBox coche3;
        private System.Windows.Forms.Timer coche1_mover;
        private System.Windows.Forms.Timer coche2_mover;
        private System.Windows.Forms.Timer coche3_mover;
        private System.Windows.Forms.Label Fin_text;
        private System.Windows.Forms.Label score_text;
        private System.Windows.Forms.Label Velocidad_text;
        private System.Windows.Forms.Label nivel_text;
        private System.Windows.Forms.Label gana_txt;
        private System.Windows.Forms.GroupBox MENU;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label nuevo_txt;
        private System.Windows.Forms.Label nivel2_txt;
        private System.Windows.Forms.Label nivel3_txt;
    }
}

