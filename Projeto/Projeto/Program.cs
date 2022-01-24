using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto;

namespace Projeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Knigth arus = new Knigth("Arus", 23, "Knigth");    // instanciando classe de  Objeto
            Wizard wizard = new Wizard("Jenica", 23, "White Wizard");

            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack(1));
            Console.WriteLine(wizard.Attack(7));



            Console.ReadLine();

        }
    }
}
