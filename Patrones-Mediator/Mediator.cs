using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_Mediator
{
    class Mediator
    {
        Personaje personaje;
       

        public void AtacarRival(Personaje atacante, Personaje atacado)
        {
            atacante.Atacar(atacado);
        }
        public void Curarse(Personaje personaje)
        {
            personaje.Curarse();
        }
    }
}
