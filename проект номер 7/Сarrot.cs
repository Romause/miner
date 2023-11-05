using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace проект_номер_7
{
    public class Сarrot
    {
        public Сarrot() 
        {
            Console.WriteLine("выростить морковку");
        }
        public void Eat()
        {
            Console.WriteLine("сьесть морковку");
            Eat();
        }
    }   
}
