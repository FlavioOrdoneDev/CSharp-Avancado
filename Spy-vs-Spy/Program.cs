using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spy_vs_Spy
{
    class Program
    {
        static void Main(string[] args)
        {
            SecretAgent secretAgent = new SecretAgent();
            var name = secretAgent.AgentGreeting("the crow flies at midnight");

            Console.WriteLine("O nome do agente é: " + name);

            Console.ReadKey();
        }
    }
}
