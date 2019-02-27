using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_2
{
    public class ZemınKat:IKuyruk
    {
        private object[] Queue;
        public int front = -1;
        public int rear = -1;
        public int size = 0;
        private int count = 0;
        public ZemınKat(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
     
            if ((count == size) )
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;
            if((rear == size - 1))
            {
                rear = 0;
                Queue[rear] = 0;
            }
            
            Queue[++rear] = o;
            count++;
        }

        public object Remove()
        {
            if (IsEmpty())
                throw new Exception("Queue boş.");
            
            object temp = Queue[front];
            Queue[front] = null;
            if (front == size - 1)
            {
                front = 0;
            }
            else
            {
                front++;
            }
            count--;

            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }
        public object Goster(int i)
        {
            return Queue[i];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }
     
    }
}
