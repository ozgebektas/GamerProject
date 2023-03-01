using GamerProject.Abstract;
using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Concrete
{
    public class CampaignManager : IGenericService<Campaign>
    {
        public void Add(Campaign t)
        {
            Console.WriteLine("kampanya eklendi" + t.CampaignName);
        }

        public void Delete(Campaign t)
        {
            Console.WriteLine("kampanya silindi" + t.CampaignName);
        }

        public void Update(Campaign t)
        {
            Console.WriteLine("kampanya güncellendi" + t.CampaignName);
        }
    }
}
