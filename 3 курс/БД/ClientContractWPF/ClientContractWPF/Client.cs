using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientContractWPF
{
    class Client
    {
        public Client() { }
        public int Id { get; set; }
        public string orgName { get; set; }
        public string adress { get; set; }
        public string cheff { get; set; }
        public List<Contract> Contracts { get; set; } = new List<Contract>();
    }
}
