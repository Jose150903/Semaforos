using System;
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

namespace Simulacion_Semaforo
{
    public partial class Form1 : Form
    {
         Timer timer1 = new Timer();

        // Tiempos configurables para los semáforos
         int tiempoRojo, tiempoAmarillo, tiempoVerde;
         int tiempoRojo1;
         int tiempoAmarillo1; 
         int tiempoVerde1;

         int estadoSemaforo1 = 0; // 0: Rojo, 1: Amarillo, 2: Verde
         int estadoSemaforo2 = 2; // Inicializado en 2 para que empiece en verde (opuesto al semáforo 1)

        //Reproductor de sonido de cambio
        SoundPlayer Sonido_Semaforo = new SoundPlayer("C:\\Users\\Rog G75V\\Desktop\\Sistemas Computacionales\\Simulacion_Semaforo\\Resources\\Sonido_Semaforo2.wav");

        public Form1()
        {
            InitializeComponent();

            

            timer1.Interval = 250; // 1 segundo
            timer1.Tick += Timer1_Tick;

            //Para hacer la forma de las luces redondas
            luzCircular(ptbRojo);
            luzCircular(ptbAmarillo);
            luzCircular(ptbVerde);
            luzCircular(ptbRojo1);
            luzCircular(ptbAmarillo1);
            luzCircular(ptbVerde1);
            
        }
        //Método para hacer los picturebox circulares(luces)
        private void luzCircular(PictureBox pictureBox)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0,0, pictureBox.Width,pictureBox.Height);
            pictureBox.Region = new Region(path);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            try {
                
            // Lógica para cambiar el color del semáforo 1
            switch (estadoSemaforo1)
            {
                case 0: // Rojo
                    ptbRojo.BackColor = Color.Red;
                    ptbAmarillo.BackColor = Color.Gray;
                    ptbVerde.BackColor = Color.Gray;

                    // Semáforo 2 en verde (opuesto)
                    ptbRojo1.BackColor = Color.Gray;
                    ptbAmarillo1.BackColor = Color.Gray;
                    ptbVerde1.BackColor = Color.Green;

                    if (tiempoRojo1 == 0)
                    {

                        estadoSemaforo1 = 1; // Cambia al estado amarillo
                        estadoSemaforo2 = 1; // Cambia al estado amarillo
                        tiempoRojo1 = (Convert.ToInt32(txtRojo.Text)*4); // Restablece tiempo de rojo
                        //Sonido para el cambio de luces
                        Sonido_Semaforo.Play();
                    }
                    tiempoRojo1--;
                    break;

                case 1: // Amarillo
                    ptbRojo.BackColor = Color.Gray;
                    ptbAmarillo.BackColor = Color.Yellow;
                    ptbVerde.BackColor = Color.Gray;

                    // Semáforo 2 en amarillo (sincronizado)
                    ptbRojo1.BackColor = Color.Gray;
                    ptbAmarillo1.BackColor = Color.Yellow;
                    ptbVerde1.BackColor = Color.Gray;

                    if (tiempoAmarillo1 == 0)
                    {
                        estadoSemaforo1 = 2; // Cambia al estado verde
                        estadoSemaforo2 = 0; // Cambia al estado rojo (opuesto)
                        tiempoAmarillo1 = (Convert.ToInt32(txtAmarillo.Text)*4); // Restablece tiempo de amarillo
                        //Sonido para el cambio de luces
                        Sonido_Semaforo.Play();
                    }
                    tiempoAmarillo1--;
                    break;

                case 2: // Verde
                    ptbRojo.BackColor = Color.Gray;
                    ptbAmarillo.BackColor = Color.Gray;
                    ptbVerde.BackColor = Color.Green;

                    // Semáforo 2 en rojo (opuesto)
                    ptbRojo1.BackColor = Color.Red;
                    ptbAmarillo1.BackColor = Color.Gray;
                    ptbVerde1.BackColor = Color.Gray;

                    if (tiempoVerde1 == 0)
                    {
                        estadoSemaforo1 = 0; // Cambia al estado rojo
                        estadoSemaforo2 = 2; // Cambia al estado verde (opuesto)
                        tiempoVerde1 = (Convert.ToInt32(txtVerde.Text) * 4); // Restablece tiempo de verde
                        //Sonido para el cambio de luces
                        Sonido_Semaforo.Play();
                    }
                    tiempoVerde1--;
                    break;
                }
            }
            catch
            {
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Método para iniciar los semáforos
        
        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            tiempoRojo1 = Convert.ToInt32(txtRojo.Text); // Restablece tiempo de rojo
            tiempoAmarillo1 = Convert.ToInt32(txtAmarillo.Text); // Restablece tiempo de amarillo
            tiempoVerde1 = Convert.ToInt32(txtVerde.Text); // Restablece tiempo de verde
            timer1.Start();

        }

        // Método para detener los semáforos
        private void BtnDetener_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        // Método para apagar los semáforos (pone todos los colores en gris)
        private void BtnApagar_Click(object sender, EventArgs e)
        {
            timer1.Stop();

            ptbRojo.BackColor = Color.Gray;
            ptbAmarillo.BackColor = Color.Gray;
            ptbVerde.BackColor = Color.Gray;

            ptbRojo1.BackColor = Color.Gray;
            ptbAmarillo1.BackColor = Color.Gray;
            ptbVerde1.BackColor = Color.Gray;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
