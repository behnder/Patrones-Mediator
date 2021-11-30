using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Mediator
{
    class Personaje
    {
        public Mediator Mediator { get; set; }
        public string Nombre { get; set; }
        public int Vida { get; set; }
        public int PocionesDeVida { get; set; }
        public bool EstaVivo { get; set; }
        public int MultiplicadorDeAtaque { get; set; }
        public int VidaTotal { get; set; }

        public Personaje(string nombre, int vida, int pocionesDeVida, Mediator mediator, int multiplicadorDeAtaque)
        {
            Nombre = nombre;
            Vida = vida;
            VidaTotal = vida;
            PocionesDeVida = pocionesDeVida;
            EstaVivo = true;
            Mediator = mediator;
            MultiplicadorDeAtaque = multiplicadorDeAtaque;
            Console.WriteLine($" {Nombre} tiene {Vida} de vida, {PocionesDeVida} Pociones de HP y un ataque de {MultiplicadorDeAtaque}");
        }

        public void Atacar(Personaje contrincante)
        {
            Console.WriteLine(Nombre + " Está atacando al contrincante! ");
            contrincante.Vida -= MultiplicadorDeAtaque;
            Console.WriteLine("La vida del contrincante es de" + contrincante.Vida);
            if (Vida < 1)
            {
                EstaVivo = false;
                Console.WriteLine(contrincante.Nombre + " Ha sido eliminado");
            }
        }
        public void Curarse()
        {

            if (PocionesDeVida > 0)
            {
                if (Vida < VidaTotal)
                {
                    PocionesDeVida--;
                    Console.WriteLine("Aplicando pocion de curación");
                    Console.WriteLine("La salud actual es de" + Vida);
                    Vida++;

                }
                if (Vida == VidaTotal)
                {
                    Vida = VidaTotal;
                    EstaVivo = false;
                    Console.WriteLine(Nombre + " Está con la salud al máximo : "+ Vida);

                }

            }

            if (PocionesDeVida == 0)
            {
                Console.WriteLine("Ya no quedan pociones");
            }
        }
    }
}
