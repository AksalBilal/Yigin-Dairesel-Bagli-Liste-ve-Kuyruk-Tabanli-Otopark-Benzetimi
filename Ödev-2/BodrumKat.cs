using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_2
{
   public class BodrumKat: IStack
    {
        private object[] items;
        private int top = -1;

        public BodrumKat(int itemCount)
        {
            this.items = new object[itemCount];
        }
        public void Push(object item)
        {
            if (items.Length == Top + 1)
            {
                throw new Exception("Hata: Stack doldu... (Overflow)");
            }
            items[++Top] = item;
        }

        public object Pop()
        {
            if (IsEmpty())
            {
                System.Windows.Forms.MessageBox.Show("Hata: Stack boş...(Downflow)");
            }
            Object temp = items[Top--];
            return temp;
        }

        public object Peek()
        {
            return items[Top];
        }
        public object Goster2(int i)
        {
            return items[i];
        }

        public bool IsEmpty()
        {
            return Top == -1 ? true : false;
        }

        public int Top
        {
            get
            {
                return top;
            }
            set
            {
                top = value;
            }
        }
    }
}
