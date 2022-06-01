using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test_connection.Models;

namespace test_connection.Services
{
    public class ClientServices {

        public Client GetClient(String Nume)
        {
            using (var context = new MasterContext())
            {
                var client = (from c in context.Clients
                              where c.FirstName == Nume
                              select c).ToList();
                return client[0];
            }
        }
    
        public void AddClient(Client client)
        {

            using (var context = new MasterContext())
            {
                context.Set<Client>().Add(client);
                context.SaveChanges();
            }

        }
        public void Update(Client client)
        {
            using (var context = new MasterContext())
            {
                context.Entry(client).State = EntityState.Modified;
                context.SaveChanges();
            }
        }

        public void DeleteClient(Client client)
        {
            using (var context = new MasterContext())
            {
                context.Entry(client).State = EntityState.Deleted;
                context.SaveChanges();
            }

        }
    }
}
