using GamerProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamerProject.Abstract
{
  public interface IGameService:IGenericService<Game>
    {

        //IGenericService sınıfı kullanılarak aynı olan void metotları tek bir interface de yazmış olduk.
        //burada T parametresi sen hangi service interface da hangi class'dan değerler alamk istiyorsan onları buraya çağırmana yarayacak.
    }
}
