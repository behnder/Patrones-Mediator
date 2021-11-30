using System;
using System.Collections;
namespace Patrones_Mediator
{
    class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            Mediator actionManager = new Mediator();
            Personaje enemigo = new Personaje("Enemigo01",50,4,actionManager, random.Next(0,2));
            Personaje jugador = new Personaje("Jugador",80,10,actionManager, random.Next(2, 4));
            Console.WriteLine("==================================================================");

            jugador.Mediator.AtacarRival(jugador,enemigo);
            enemigo.Mediator.Curarse(enemigo);
            enemigo.Mediator.Curarse(enemigo);

            enemigo.Mediator.AtacarRival(enemigo, jugador);
            enemigo.Mediator.AtacarRival(enemigo, jugador);
            enemigo.Mediator.AtacarRival(enemigo, jugador);
            enemigo.Mediator.AtacarRival(enemigo, jugador);
            enemigo.Mediator.AtacarRival(enemigo, jugador);

            jugador.Mediator.Curarse(jugador);
            jugador.Mediator.Curarse(jugador);
            jugador.Mediator.Curarse(jugador);
            jugador.Mediator.Curarse(jugador);
          
            Console.ReadKey();




        }
    }
}
