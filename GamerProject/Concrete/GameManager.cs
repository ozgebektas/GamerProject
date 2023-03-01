using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class GameManager : IGenericService<Game>
    {
        public void Add(Game t)
        {
            Console.WriteLine("oyun eklendi" + t.GameName);
        }

        public void Delete(Game t)
        {
            Console.WriteLine("oyun silindi" + t.GameName);
        }

        public void Update(Game t)
        {
            Console.WriteLine("oyun güncellendi" + t.GameName);
        }
    }
}
