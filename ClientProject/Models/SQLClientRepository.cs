using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientProject.Models
{
    public class SQLClientRepository:IClientRepository
    {
        private AppDbContext context;
        public SQLClientRepository(AppDbContext context)
        {
            this.context = context;
        }
        public Client add(Client client)
        {
            context.clients.Add(client);
            context.SaveChanges();
            return client;
        }
    }
}
