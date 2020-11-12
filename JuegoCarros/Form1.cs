using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace JuegoCarros
{
    public partial class Form1 : Form
    {
        int score = 0;
        int velocidad = 2;
        int tiempo = 50;

        Random  aleatorio = new Random();

        SoundPlayer sonido;
        
        //ESTA ES UNA PRUEBA DE GIT
        public Form1()
        {
            
            InitializeComponent();
            cargando();

        }
        void audioplay()
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\audio\audio.wav");
            sonido.Play();
        }
        void audiochoque()
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\audio\choque.wav");
            sonido.Play();
        }
        void audioganaste()
        {
            sonido = new SoundPlayer(Application.StartupPath + @"\audio\ganaste.wav");
            sonido.Play();
        }

        void audiostop()
        {
            if (sonido != null)
            {
                sonido.Stop();
            }
        }
        void cargando()
        {
            btnNuevo.Visible = true;
            btnSalir.Visible = true;
            nuevo_txt.Visible = true;
            Fin_text.Visible = false;
            TimerMover.Stop();
            coche1_mover.Stop();
            coche2_mover.Stop();
            coche3_mover.Stop();
        }

        private void TimerMover_Tick(object sender, EventArgs e)
        {
          

            Velocidad_text.Text = "Velocidad: " + velocidad;

            if(score>10 & score < 20)
            {
                velocidad = 4;
                nivel_text.Text = "Nivel: 2";
                nivel2_txt.Visible = true;
                this.BackColor = Color.DimGray;
               

            }
            if(score >20 & score < 30)
            {
                velocidad = 5;
                nivel_text.Text = "Nivel: 3";
                nivel3_txt.Visible = true;
                nivel2_txt.Visible = false;
                this.BackColor = Color.Sienna;
            }
            if (score > 30)
            {
                velocidad = 6;
                nivel_text.Text = "Nivel: 4";
                gana_txt.Visible = true;
                GANASTE();
            }
           
            if (Carro.Bounds.IntersectsWith(coche1.Bounds))
            {
                gameOver();
            }
            if (Carro.Bounds.IntersectsWith(coche2.Bounds))
            {
                gameOver();
            }
            if (Carro.Bounds.IntersectsWith(coche3.Bounds))
            {
                gameOver();
            }
            if (Carro.Bounds.IntersectsWith(nivel_gasolina.Bounds))
            {
                nivel_gasolina.Location = new Point(aleatorio.Next(350), aleatorio.Next(500));
                tiempo += 50;
            }
            

            void gameOver()
            {
                if(tiempo < 0) //PIERDE POR NO TENER NITRO
                {
                    btnNuevo.Visible = true;
                    btnSalir.Visible = true;
                    Fin_text.Visible = true;
                    TimerMover.Stop();
                    coche1_mover.Stop();
                    coche2_mover.Stop();
                    coche3_mover.Stop();

                }
                btnNuevo.Visible = true;
                btnSalir.Visible = true;
                Fin_text.Visible = true;
                TimerMover.Stop();
                coche1_mover.Stop();
                coche2_mover.Stop();
                coche3_mover.Stop();
                audiostop();
                audiochoque();
            }
            void GANASTE()
            {
                btnNuevo.Visible = true;
                btnSalir.Visible = true;
                TimerMover.Stop();
                coche1_mover.Stop();
                coche2_mover.Stop();
                coche3_mover.Stop();
                audioganaste();
            }
       
            
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                carJugadorDer.Start();

            }
            if(e.KeyCode == Keys.Left)
            {
                carJugadorIzq.Start();
            }
            if(e.KeyCode == Keys.Up)
            {
                carJugadorArriba.Start();
            }
            if (e.KeyCode == Keys.Down)
            {
                carJugadorAbajo.Start();
            }

        }

        private void carJugadorDer_Tick(object sender, EventArgs e)
        {
            if(Carro.Location.X < 342)
            {
                Carro.Left += 5;
            }
        }

        private void carJugadorIzq_Tick(object sender, EventArgs e)
        {
            if (Carro.Location.X > 5)
            {
                Carro.Left -= 5;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            carJugadorDer.Stop();
            carJugadorIzq.Stop();
            carJugadorArriba.Stop();
            carJugadorAbajo.Stop();

        }

        private void coche1_mover_Tick(object sender, EventArgs e)
        {
            coche1.Top += velocidad / 2;
            if(coche1.Top >= Height)
            {
                score += 1;
                score_text.Text = "Puntaje: "+ score;
                coche1.Top = -coche1.Height;
               
            }
            
        }

        private void coche2_mover_Tick(object sender, EventArgs e)
        {
            coche2.Top += velocidad;
            if (coche2.Top >= Height)
            {
                score += 1;
                score_text.Text = "Puntaje: " + score;
                coche2.Top = -coche2.Height;

            }
        }

        private void coche3_mover_Tick(object sender, EventArgs e)
        {
            coche3.Top += velocidad * 3/2;
            if (coche3.Top >= Height)
            {
                score += 1;
                score_text.Text = "Puntaje: " + score;
                coche3.Top = -coche3.Height;

            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            score = 0;
            velocidad = 2;
            Controls.Clear();
            InitializeComponent();
            audioplay();
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de Salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void gasolina_Tick(object sender, EventArgs e)
        {
            lbGasolina.Text = "gasolina="+tiempo;
            tiempo -= 1;
            
        }

        private void carJugadorArriba_Tick(object sender, EventArgs e)
        {
            if (Carro.Location.Y > 5)
            {
                Carro.Top -= 5;
            }
        }

        private void carJugadorAbajo_Tick(object sender, EventArgs e)
        {
            if (Carro.Location.Y > 5)
            {
                Carro.Top += 5;
            }
        }
    }
}
