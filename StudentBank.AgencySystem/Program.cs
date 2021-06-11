using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StudentBank.Models;
using StudentBank.Models.Funcionarios;

namespace StudentBank.AgencySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente(487, 789456);
            Funcionario funcionario = null;
           
            Console.WriteLine(conta.Numero);

            Console.ReadLine();
        }
    }
}
