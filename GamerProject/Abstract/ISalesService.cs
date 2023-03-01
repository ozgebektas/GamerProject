using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GamerProject.Entities;

namespace GamerProject.Abstract
{
  public interface ISalesService

    {
        void Add(Game game, Gamer gamer, Campaign campaign);
    }
}
