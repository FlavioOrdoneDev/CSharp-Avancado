using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spy_vs_Spy
{
    public class SecretAgent
    {
        private string Alias = "Dash Jones";

        private string RealName = "Herb Jones";

        private string Password { get; set; }

        public string AgentGreeting(string password)
        {
            this.Password = "the crow flies at midnight";
            if (password == Password)
            {
                return this.RealName;
            }
            else
            {
                return this.Alias;
            }
            
        }
    }
}
