using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo3
{
    public class Mamífero : Animal
    {
        public int qtdeDeMamas { get; set; }
        public bool pelos { get; set; }
        public string corDoPelo { get; set; }

        public void Amamentar()
        {
            Console.WriteLine("Animal com capacidade para amamentar filhote!");
        }
    }
}
