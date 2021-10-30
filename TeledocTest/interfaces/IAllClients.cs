using System.Collections.Generic;
using TeledocTest.Models;

namespace TeledocTest.interfaces
{
    public interface IAllClients
    {
        void AddClient(Client client);
        public void AddFounder(Founder founder);
        IEnumerable<Client> Clients { get; }
        IEnumerable<Founder> Founders { get; }
    }
}