using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientsContracts
{
    class Contract
    {
        public Contract() { }
        public int Id { get; set; }
        public long clientId { get; set; }
        public DateTime date { get; set; }
        public int sum { get; set; }
        public Client client { get; set; }
    }
}
