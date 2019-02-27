using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_2
{
    public abstract class IkıncıKatAbstract
    {

        public Node Head;
        public int Size = 0;
        public abstract void InsertFirst(object value);
        public abstract void InsertLast(object value);
        public abstract void InsertPos(int position, int value);
        public abstract void DeleteFirst();
        public abstract void DeleteLast();
        public abstract void DeletePos(int position);
        public abstract  string GetElement(int position);       
        public abstract string DisplayElements();
    }
}
