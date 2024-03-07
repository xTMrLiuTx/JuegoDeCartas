using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace JuegoDeCartas
{
    public partial class Form1 : Form
    {
        // Declaraci�n de variables
        Queue<int> colaCartas = new Queue<int>(); // Cola para almacenar las cartas barajeadas
        Stack<int>[] pilasJugadores = new Stack<int>[3]; // Pilas para cada jugador
        LinkedList<int>[] listasJugadores = new LinkedList<int>[3]; // Listas enlazadas para las cartas ganadas por cada jugador
        LinkedList<int> pozo = new LinkedList<int>(); // Lista enlazada para las cartas en el pozo

        // Constructor del formulario
        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < 3; i++)
            {
                pilasJugadores[i] = new Stack<int>();
                listasJugadores[i] = new LinkedList<int>();
            }
            // Inicializaci�n del ListBox del pozo
            listBoxPozo.Items.Clear(); // Limpia los elementos existentes
        }

        // M�todo para barajear las cartas
        private void Barajear()
        {
            Random rnd = new Random();
            for (int i = 0; i < 15; i++)
            {
                colaCartas.Enqueue(rnd.Next(1, 14));
            }
        }

        // M�todo para repartir las cartas a los jugadores
        private void Repartir()
        {
            while (colaCartas.Count > 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    pilasJugadores[i].Push(colaCartas.Dequeue());
                }
            }
        }

        // M�todo para jugar la ronda de cartas
        private void Jugar()
        {
            int[] cartas = new int[3];

            // Se obtiene una carta de cada jugador
            for (int i = 0; i < 3; i++)
            {
                if (pilasJugadores[i].Count > 0)
                    cartas[i] = pilasJugadores[i].Pop();
                else
                    cartas[i] = 0; // Marcar que el jugador ya no tiene cartas
            }

            // Se determina la carta m�s alta
            int maxCarta = cartas.Max();

            // Se determina qu� jugador tiene la carta m�s alta y se le asignan las cartas
            if (cartas.Count(carta => carta == maxCarta) == 1)
            {
                int jugadorGanador = Array.IndexOf(cartas, maxCarta);
                foreach (int carta in cartas)
                {
                    listasJugadores[jugadorGanador].AddLast(carta);
                }
            }
            // Se manejan empates
            else if (cartas.Count(carta => carta == maxCarta) == 3)
            {
                foreach (int carta in cartas)
                {
                    listasJugadores[Array.IndexOf(cartas, carta)].AddLast(carta);
                }
            }
            else
            {
                foreach (int carta in cartas)
                {
                    if (cartas.Count(c => c == carta) == 1)
                    {
                        pozo.AddLast(carta);
                    }
                    else
                    {
                        listasJugadores[Array.IndexOf(cartas, carta)].AddLast(carta);
                    }
                }
            }
        }

        // M�todo para calcular al ganador del juego
        private int CalcularGanador()
        {
            int[] sumas = new int[3];

            // Se suman los valores de las cartas de cada jugador
            for (int i = 0; i < 3; i++)
            {
                foreach (int carta in listasJugadores[i])
                {
                    sumas[i] += carta;
                }
            }

            // Se determina el jugador con la suma m�s alta
            return Array.IndexOf(sumas, sumas.Max()) + 1;
        }

        // M�todo para mostrar las cartas de los jugadores en los listboxes
        private void MostrarCartas()
        {
            listBoxJugador1.Items.Clear();
            listBoxJugador2.Items.Clear();
            listBoxJugador3.Items.Clear();

            for (int i = 0; i < 3; i++)
            {
                foreach (int carta in pilasJugadores[i])
                {
                    switch (i)
                    {
                        case 0:
                            listBoxJugador1.Items.Add(carta);
                            break;
                        case 1:
                            listBoxJugador2.Items.Add(carta);
                            break;
                        case 2:
                            listBoxJugador3.Items.Add(carta);
                            break;
                        default:
                            break;
                    }
                }
            }
            // Mostrar las cartas del pozo en el ListBox del pozo
            foreach (int carta in pozo)
            {
                listBoxPozo.Items.Add(carta);
            }
        }

        // M�todo para limpiar toda la informaci�n de los ListBox y la etiqueta del ganador
        private void LimpiarInformacion()
        {
            listBoxJugador1.Items.Clear();
            listBoxJugador2.Items.Clear();
            listBoxJugador3.Items.Clear();
            listBoxPozo.Items.Clear(); // Limpiar el ListBox del pozo
            lblGanadorFinal.Text = ""; // Establecer el texto del ganador en vac�o
        }


        // Evento del bot�n "Barajear"
        private void btnBarajear_Click(object sender, EventArgs e)
        {
            Barajear();
            MostrarCartas();
        }

        // Evento del bot�n "Repartir"
        private void btnRepartir_Click(object sender, EventArgs e)
        {
            Repartir();
            MostrarCartas();
        }

        // Evento del bot�n "Jugar"
        private void btnJugar_Click(object sender, EventArgs e)
        {
            Jugar();
            MostrarCartas();
        }

        // Evento del bot�n "Calcular Ganador"
        private void btnCalcularGanador_Click(object sender, EventArgs e)
        {
            int ganador = CalcularGanador();
            lblGanadorFinal.Text = "El ganador es el Jugador " + ganador.ToString();
        }

        // Evento del bot�n "Salir"
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // Cierra el formulario y termina la aplicaci�n
        }

        // Evento del bot�n "Nuevo Juego"
        private void btnNuevoJuego_Click(object sender, EventArgs e)
        {
            LimpiarInformacion(); // Limpia la informaci�n para comenzar un nuevo juego
        }


    }
}

