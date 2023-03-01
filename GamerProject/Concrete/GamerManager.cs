using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class GamerManager : IGenericService<Gamer>
    {
        private IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer t)
        {
            if (_gamerCheckService.CheckIfRealPerson(t))
            {
                Console.WriteLine("Oyuncu eklendi: " + t.FirstName + " " + t.LastName);
            }
            else
            {
                throw new Exception("not a real person");
            }

        }

        public void Delete(Gamer t)
        {
            Console.WriteLine(t.FirstName + " "+t.LastName + "  " + "oyuncu silindi");
        }

        public void Update(Gamer t)
        {
            Console.WriteLine(t.FirstName + " "+t.LastName + "  " + "oyuncu silindi");
        }
    }
}
