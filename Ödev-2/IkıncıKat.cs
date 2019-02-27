using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev_2
{
    public class IkıncıKat : IkıncıKatAbstract
    {
        public override void InsertFirst(object value)
        {
            Node tmpHead = new Node 
            { 
                Data = value 
            };

            if (Head == null)
                Head = tmpHead;
            else
            {
                //En kritik nokta: tmpHead'in next'i eski Head'i göstermeli
                tmpHead.Next = Head;
                //Yeni Head artık tmpHead oldu
                Head = tmpHead;
            }
            //Bağlı listedeki eleman sayısı bir arttı
            Size++;
        }

        public override void InsertLast(object value)
        {
            //Eski sonuncu node, Head'den başlanarak set ediliyor
            Node oldLast = Head;

            if (Head == null)
                //Hiç kayıt eklenmediği için InsertFirst çağrılabilir
                InsertFirst(value);
            else
            {
                //Yeni sonuncu node yaratılıyor
                Node newLast = new Node 
                { 
                    Data = value 
                };

                //Eski sonuncu node bulunuyor
                //Tail olsaydı sonuncuyu bulmaya gerek yoktu.
                while (oldLast != null)
                {
                    if (oldLast.Next != null)
                        oldLast = oldLast.Next;
                    else
                        break;
                }

                //Eski sonuncu node referansı artık yeni sonuncu node'u gösteriyor
                oldLast.Next = newLast;

                //Bağlı listedeki eleman sayısı bir arttı
                Size++;
            }
        }

        public override void InsertPos(int position, int value)
        {
            throw new NotImplementedException();
        }

        public override void DeleteFirst()
        {
            if (Head != null)
            {
                //Head'in next'i HeadNext'e atanıyor
                Node tempHeadNext = this.Head.Next;
                //HeadNext null ise zaten tek kayıt olan Head silinir.
                if (tempHeadNext == null)
                    Head = null;
                else
                    //HeadNext null değilse yeni Head, HeadNext olur.
                    Head = tempHeadNext;
                //Listedeki eleman sayısı bir azaltılıyor
                Size--;
            }
        }

        public override void DeleteLast()
        {
            //Last node bulunup NULL yapılacak
            Node lastNode = Head;
            //Last node'dan bir önceki node'un Next'i null olacak
            Node lastPrevNode = null;
            while (true)
            {
                if (lastNode.Next != null)
                {
                    lastPrevNode = lastNode;
                    lastNode = lastNode.Next;                    
                }                
                else
                    break;
            }
            //Listedeki eleman sayısı bir azaltılıyor
            Size--;
            //Last node null oldu
            lastNode = null;

            //Last node'dan önceki node varsa onun next'i null olacak yoksa zaten tek kayıt vardır, 
            //o da Head'dir, o da null olacak
            if (lastPrevNode != null)
                lastPrevNode.Next = null;
            else
                Head = null;
        }

        public override void  DeletePos(int position)
        {
            if (position == 0)

                DeleteFirst();
            else
            {
                Node PosNode = Head;
                Node lastPreviousNode = null;
                int count = 1;

                while(true)
            {
                    if (PosNode.Next != Head)
                    {
                        lastPreviousNode = PosNode;
                        PosNode = lastPreviousNode.Next;
                    }
                    else
                    
                        break;
                    
                    if (count == position)
                    {
                        break;
                    }
                    count++;
                }
                Size--;
                if (lastPreviousNode != null)
                {
                    lastPreviousNode.Next = PosNode.Next;
                }
                else
                    Head = null;

                PosNode = null;
            }
            
            
        }
        public override   string GetElement(int position)
        {
            //Geri dönülecek eleman
            Node retNode = null;
            //Head'den başlanarak Next node'a gidilecek
            Node tempNode = Head;            
            int count = 0;

            while (tempNode != null)
            {
                if (count == position)
                {
                    retNode = tempNode;
                    break;
                }
                //Next node'a git
                tempNode = tempNode.Next;
                count++;
            }
            return retNode.Data.ToString();
        }
      
        public override string DisplayElements()
        {
            string temp = "";
            Node item = Head;
            while (item != null)
            {
                temp += "-->" + item.Data;
                item = item.Next;
            }

            return temp;
        }
    }
}
