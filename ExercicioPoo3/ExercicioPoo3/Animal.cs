using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo3
{
    public class Animal
    {
        public string nome { get; set; }
        public DateTime dataDeNascimento { get; set; }
        public int idade { get; set; }
        public char sexo { get; set; }
        public bool carnivoro { get; set; }
        public bool peconhento { get; set; }


        public void Movimentar()
        {
            Console.WriteLine("Animal está se movimentando");
        }

        public void Comunicar()
        {
            Console.WriteLine("Iniciando tentativa de contato com animal");
        }

        public void Alimentar()
        {
            if (carnivoro == true)
            {
                Console.WriteLine("Animal carnívoro!");
            }
            else
            {
                Console.WriteLine("Animal não carnívoro!");
            }
        }
    }
}
