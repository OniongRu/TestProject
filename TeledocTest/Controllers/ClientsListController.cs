using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TeledocTest.interfaces;
using TeledocTest.Models;
using TeledocTest.ViewModels;

namespace TeledocTest.Controllers
{
    public class ClientsListController : Controller
    {
        private readonly IAllClients _allClients;
        public ClientsListController(IAllClients iAllClients)
        {
            _allClients = iAllClients;
        }


        public IActionResult AllClients()
        {
            ClientsListViewModel response = null;
            response = new ClientsListViewModel()
            {
                Clients = _allClients.Clients.OrderBy(i=>i.ChangingDate),
                Info = new AddingClientInfo()
                {
                    IsTryToAdd = false
                }
            };

            return View(response);
        }
        
        [HttpPost]
        public ActionResult<Client> Create(Client client)
        { 
            ClientsListViewModel response = null;
            if (String.IsNullOrEmpty(client.Name) || String.IsNullOrEmpty(client.TIN)||client.Type==null)
            {
                response = new ClientsListViewModel()
                {
                    Clients = _allClients.Clients.OrderBy(i=>i.ChangingDate),
                    Info = new AddingClientInfo()
                    {
                        IsTryToAdd = true,
                        ClientAdd = false,
                        AddInfo = "Были введены не все строки"
                    }
                };
                return View("../ClientsList/AllClients", response);
            }
            _allClients.AddClient(new Client()
            {
                Name = client.Name,
                TIN = client.TIN,
                Type = client.Type,
                AddingDate = DateTime.Now,
                ChangingDate = DateTime.Now
            });
            response = new ClientsListViewModel()
            {
                Clients = _allClients.Clients.OrderBy(i=>i.ChangingDate),
                Info = new AddingClientInfo()
                {
                    IsTryToAdd = true,
                    ClientAdd = true,
                    AddInfo = "|NAME["+client.Name+"]|TIN["+client.TIN+"]"
                }
            };
            return View("../ClientsList/AllClients", response);
        }
        
    }
}