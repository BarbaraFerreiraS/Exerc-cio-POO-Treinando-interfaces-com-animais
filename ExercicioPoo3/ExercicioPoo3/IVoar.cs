using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo3
{
    internal interface IVoar
    {
        public int altitudeMaximaEmMetros { get; set; }
        public double velocidadeDoVoo { get; set; }

        public void Voar()
        {
        }
    }
}
