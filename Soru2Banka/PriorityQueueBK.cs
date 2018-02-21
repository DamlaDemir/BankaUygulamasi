using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2Banka
{
   public class PriorityQueueBK:IQueue
    {
       public float OrtalamaToplamSure = 0;

        public int ToplamSure = 0;
        private object[] Queue;
        private int front = -1;
        private int size = 0;
        private int count = 0;

        public PriorityQueueBK(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            if (count == size)
            {
                throw new Exception("Queue is full");
            }

            if (IsEmpty())
            {
                front++;
                Queue[front] = o;
                count++;
            }
            else
            {
                int i;
                Musteri m = (Musteri)o;

  
                for (i = count - 1; i >= 0; i--)
                {   //IslemSuresi büyük olan kuyruktan ilk çıkar mantığına göre sıralama yapıldı.
                    if (m.IslemSuresi < ((Musteri)Queue[i]).IslemSuresi)
                        Queue[i + 1] = Queue[i];
                    else
                        break;
                }
                Queue[i + 1] = o;
                front++;
                count++;
            }
        }

        public object Remove()
        {
            if (this.IsEmpty())
            {
                throw new Exception("Queue is empty...");
            }
            object temp = Queue[front];
            Queue[front] = null;
            front--;
            count--;
            return temp;
        }

        public object Peek()
        {
            return Queue[front];
        }

        public bool IsEmpty()
        {
            return (count == 0);
        }


        public int ToplamSureBul(int sure)
        {
            //işlem tamamlanma süresi hesaplama
            ToplamSure += sure;
            return ToplamSure;

        }

        public float OrtalamaBul()
        {
            return OrtalamaToplamSure / 20;
        }

        public string MusteriGoster(Musteri m)
        {
            int x = ToplamSureBul(m.IslemSuresi);//Fonksiyona gelen müşteri için işlem tamamlanma süresi hesaplandı.
            string temp = "";
            temp = m.MusteriNo + " Numaralı müşterinin işlem süresi:" + m.IslemSuresi + " sn" + " İşlem tamamlanma süresi:" + x + " sn" + Environment.NewLine;
            OrtalamaToplamSure += x;//gelen müşterinin işlem tamamlanma süresi ortalama işlem süresi hesaplanmak için ortalamaToplamSureye eklendi.

            return temp;
        }
    }
}
