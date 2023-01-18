using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo3
{
    public class Lontra : Mamífero, IAquático
    {
        public bool viveEmTerra { get; set; }
        public bool mergulho { get; set; }
        public bool aguaDoce { get; set; }
    }
}
