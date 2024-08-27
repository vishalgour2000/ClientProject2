using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientProject.Models
{
    public interface IClientRepository
    {
        public Client add(Client client);
    }
}
