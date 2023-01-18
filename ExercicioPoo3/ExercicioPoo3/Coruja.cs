using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo3
{
   public class Coruja : Ave, IOvíparo, IVoar
    {
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
