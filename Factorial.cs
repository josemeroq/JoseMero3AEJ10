using System;
using System.Collections.Generic;
using System.Text;

namespace JoseMero3AEJ10
{
    public class Factorial
    {
        private String num { get; set; }
        private int valor { get; set; }

        private int fact { get; set; }

        public Factorial()
        {
            this.num = "";
            this.valor = 0;
            this.fact = 1;
        }

        public void procesofac()
        {
            Console.WriteLine("Inrese un número");
            num = Console.ReadLine();
            valor = Convert.ToInt32(num);
            for (int i = 1; i <= valor; i++)
            {
                fact *= i;
            }
            Console.WriteLine("El factorial del número " + valor + " es: " + fact);
            Console.ReadKey();
        }
        
    }
}
