using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo3
{
    public class Cisne : Ave, IAquático, IOvíparo, IVoar
    {
        public bool viveEmTerra { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }
        public int altitudeMaximaEmMetros { get; set; }
        public double velocidadeDoVoo { get; set; }

        public void Botar()
        {
            Console.WriteLine("Animal propenso para botar em alguns dias!");
        }

        public void Chocar()
        {
            Console.WriteLine("Animal chocando ovos que botou!");
        }

        public void Voar()
        {
            Console.WriteLine("Animal com capacidade para vôos!");
        }
    }
}
