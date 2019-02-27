using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ödev_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<string> bodrumkat = new List<string>();//otoparkın bodrum katındaki arabalar!!
        List<string> zeminkat = new List<string>();//otoparkın zemin kattaki(1.kat) arabalar!!
        List<string> ucuncukat = new List<string>();//otoparkın 2. katındaki arabalar!!      
        IkıncıKat ıkıncı = new IkıncıKat();// dairesel bağlı sıra -- otoparkın  2.katı için 
        ZemınKat zemın = new ZemınKat(45); // kuyruk yapısı -- otoparkın zemin katı için
        BodrumKat bodrum = new BodrumKat(15); //yıgıt sırası -- otoparkın bodrum katı için
        int k = 0, sayac = 0, sayac2 = 0, sayi;



        public void Uygulama2(Node test)
        {
            if (test == null)
                return;

            MessageBox.Show(test.Data.ToString());

            if (test.Next != null)
                Uygulama2(test.Next.Next);

            MessageBox.Show(test.Data.ToString());
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public Node Uygulama3Reverse(Node head)
        {
            Node currNode = head;
            Node nextNode = null;
            Node prevNode = null;

            while (currNode != null)
            {
                nextNode = currNode.Next;
                currNode.Next = prevNode;
                prevNode = currNode;
                currNode = nextNode;
            }
            return prevNode;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            bodrumkat.Add(Convert.ToString(Color.Aquamarine));
            bodrumkat.Add(Convert.ToString(Color.Azure));
            bodrumkat.Add(Convert.ToString(Color.Bisque));
            bodrumkat.Add(Convert.ToString(Color.Black));
            bodrumkat.Add(Convert.ToString(Color.BlanchedAlmond));
            bodrumkat.Add(Convert.ToString(Color.Blue));
            bodrumkat.Add(Convert.ToString(Color.BlueViolet));
            bodrumkat.Add(Convert.ToString(Color.Brown));
            bodrumkat.Add(Convert.ToString(Color.BurlyWood));
            bodrumkat.Add(Convert.ToString(Color.CadetBlue));
            bodrumkat.Add(Convert.ToString(Color.Chartreuse));
            bodrumkat.Add(Convert.ToString(Color.Chocolate));
            bodrumkat.Add(Convert.ToString(Color.Coral));
            bodrumkat.Add(Convert.ToString(Color.CornflowerBlue));
            bodrumkat.Add(Convert.ToString(Color.Cornsilk));

            zeminkat.Add(Convert.ToString(Color.DarkTurquoise));
            zeminkat.Add(Convert.ToString(Color.DarkSlateBlue));
            zeminkat.Add(Convert.ToString(Color.DarkBlue));
            zeminkat.Add(Convert.ToString(Color.DarkCyan));
            zeminkat.Add(Convert.ToString(Color.DarkGoldenrod));
            zeminkat.Add(Convert.ToString(Color.DarkGray));
            zeminkat.Add(Convert.ToString(Color.DarkGreen));
            zeminkat.Add(Convert.ToString(Color.DarkKhaki));
            zeminkat.Add(Convert.ToString(Color.DarkMagenta));
            zeminkat.Add(Convert.ToString(Color.DarkOliveGreen));
            zeminkat.Add(Convert.ToString(Color.DarkOrange));
            zeminkat.Add(Convert.ToString(Color.DarkOrchid));
            zeminkat.Add(Convert.ToString(Color.DarkRed));
            zeminkat.Add(Convert.ToString(Color.DarkSalmon));
            zeminkat.Add(Convert.ToString(Color.DarkSeaGreen));

            ucuncukat.Add(Convert.ToString(Color.Cyan));
            ucuncukat.Add(Convert.ToString(Color.DarkSlateGray));
            ucuncukat.Add(Convert.ToString(Color.Crimson));
            ucuncukat.Add(Convert.ToString(Color.DarkViolet));
            ucuncukat.Add(Convert.ToString(Color.DeepPink));
            ucuncukat.Add(Convert.ToString(Color.DeepSkyBlue));
            ucuncukat.Add(Convert.ToString(Color.DimGray));
            ucuncukat.Add(Convert.ToString(Color.DodgerBlue));
            ucuncukat.Add(Convert.ToString(Color.Gold));
            ucuncukat.Add(Convert.ToString(Color.Green));
            ucuncukat.Add(Convert.ToString(Color.Orange));
            ucuncukat.Add(Convert.ToString(Color.Red));
            ucuncukat.Add(Convert.ToString(Color.GreenYellow));
            ucuncukat.Add(Convert.ToString(Color.Indigo));
            ucuncukat.Add(Convert.ToString(Color.LawnGreen));
            for (int i = 0; i < 15; i++)
            {

                bodrum.Push(bodrumkat.ElementAt(i));
                zemın.Insert(zeminkat.ElementAt(i));
                ıkıncı.InsertLast(ucuncukat.ElementAt(i));

            }


            for (int i = 0; i < 15; i++)
            {
                listBodrumKat.Items.Add(bodrum.Goster2(i));
                listZemınKat.Items.Add(zemın.Goster(i));
                listIkıncıKat.Items.Add(ıkıncı.GetElement(i));
            }

        }
        private void btnArabaCıkart_Click(object sender, EventArgs e)
        {
            //zemin kuyruk için zemin kat(zemın)
            //ıkıncı dairesel bağlı sıra için 2.kat(ıkıncı)
            //bodrum yıgıt sırası için bodrum katı(bodrum)



            Random rastgele = new Random();
            
            if (ıkıncı.Size >0 && bodrum.Top>=0)
            {
                sayi= rastgele.Next(1, 3);
            }
            else if (ıkıncı.Size == 0 && bodrum.Top < 0)
            {
                sayi = 3;
            }
            else if (ıkıncı.Size == 0)
            {
                sayi = rastgele.Next(1, 2);
            }

            else if (bodrum.Top < 0)
            {
                sayi = rastgele.Next(2, 3);
            }

            if (ıkıncı.Size + 1 > 8)
            {
                sayac = ıkıncı.Size - 8;
                sayac = 2 * sayac + 1;
                sayac2 = sayac;
            }
            else if (ıkıncı.Size + 1 > 4)
            {
                sayac = ıkıncı.Size - 4;
                sayac = 2 * sayac + 1;

            }
            else if (ıkıncı.Size + 1 > 2)
            {
                sayac = ıkıncı.Size - 2;
                sayac = 2 * sayac + 1;

            }
            else
            {
                sayac = 1;
            }
            if (sayi == 1)
            {


                 
                if (!bodrum.IsEmpty())
                {

                    zemın.Remove();
                    zemın.Insert(bodrum.Peek());
                   

                    bodrum.Pop();
                    listBodrumKat.Items.Clear();
                    for (int i = 0; i < bodrum.Top + 1; i++)
                    {
                        listBodrumKat.Items.Add(bodrum.Goster2(i));
                    }
                    listZemınKat.Items.Clear();
                    for (int i = k; i < zemın.rear; i++)
                    {

                        listZemınKat.Items.Add(zemın.Goster(i + 1));
                    }

                    k++;
                }
               
            }
            else if (sayi == 2)
            {
              
                if (ıkıncı.Size > 0)
                {
                   
                    listZemınKat.Items.Clear();
                    listIkıncıKat.Items.Clear();
                    zemın.Insert(ıkıncı.GetElement(sayac - 1));
                    ıkıncı.DeletePos(sayac - 1);
                    for (int i = 0; i < ıkıncı.Size; i++)
                    {

                        listIkıncıKat.Items.Add(ıkıncı.GetElement(i));
                    }
                    for (int i = k; i < zemın.rear; i++)
                    {

                        listZemınKat.Items.Add(zemın.Goster(i + 1));
                    }
                    k++;
                }
               
            }
            else if(sayi==3)
            {
                listZemınKat.Items.Clear();
                zemın.Remove();
                for (int i = k; i < zemın.rear; i++)
                {

                    listZemınKat.Items.Add(zemın.Goster(i + 1));
                }
                k++;
            }
        }
    }
}

