using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TeledocTest.DBInteraction;
using TeledocTest.interfaces;
using TeledocTest.Models;

namespace TeledocTest.Repository
{
    public class ClientRepository : IAllClients
    {
        private readonly AppDBContent _appDbContent;

        public ClientRepository(AppDBContent appDbContent)
        {
            this._appDbContent = appDbContent;
        }

        public void AddClient(Client client)
        {
            if (client != null)
            {
                _appDbContent.Clients.Add(client);
                _appDbContent.SaveChanges();
            }
            
        }

        public IEnumerable<Client> Clients
        {
            get => _appDbContent.Clients.Include(c=>c.Founders).ToList();
        }

        public IEnumerable<Founder> Founders
        {
            get => _appDbContent.Founders.ToList();
        }
        
        
        public void AddFounder(Founder founder)
        {
            if (founder != null)
            {
                _appDbContent.Founders.Add(founder);
                _appDbContent.SaveChanges();
            }
            
        }
    }
}