using Microsoft.AspNetCore.Mvc;
using TeledocTest.interfaces;

namespace TeledocTest.Controllers
{
    public class ClientPageController : Controller
    {
        private readonly IAllClients _allClients;
        public ClientPageController(IAllClients iAllClients)
        {
            _allClients = iAllClients;
        }
        
        
        public IActionResult ClientInformation(int clientId)
        {
            


            return View();
        }
    }
}