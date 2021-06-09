using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentBank.Models;

namespace StudentBank.AgencySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(487, 789456);

            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
