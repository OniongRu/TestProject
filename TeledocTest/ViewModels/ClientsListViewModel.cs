using System.Collections.Generic;
using System.Linq;
using TeledocTest.Models;

namespace TeledocTest.ViewModels
{
    public class AddingClientInfo
    {
        public bool IsTryToAdd { get; set; }
        public bool ClientAdd { get; set; }
        public string AddInfo { get; set; }
    }
    public class ClientsListViewModel
    {
        public AddingClientInfo Info { get; set; }
        public IOrderedEnumerable<Client> Clients { get; set; }
    }
}