using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo3
{
    public class Ave : Animal
    {
        public bool rapina;
        public string corPena;

        public void Ciscar()
        {
            Console.WriteLine("Essa ave possui hábito de ciscar! ");
        }
    }
}
