using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    //İsimlendirme
    //------------
    //Interface olduğu için Başına I koyulur.
    //İlgili alan adı olan Category yazılır.
    //Data Access Layer içinde olduğu için sonun Dal kısaltması eklenir.
    public interface ICategoryDal : IGenericDal<Category>
    {
    }
}
