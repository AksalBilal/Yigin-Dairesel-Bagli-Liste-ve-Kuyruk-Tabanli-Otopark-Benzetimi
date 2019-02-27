using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_2
{
    public interface IKuyruk
    {

            void Insert(object o);
             object Remove();
            object Peek();
            Boolean IsEmpty();   
    }
}
