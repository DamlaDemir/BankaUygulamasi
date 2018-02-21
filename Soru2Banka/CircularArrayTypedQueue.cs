using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru2Banka
{
    public class CircularArrayTypedQueue:IQueue
    {
        public float OrtalamaToplamSure = 0;
        public int ToplamSure { get; set; }
        private object[] Queue;
        private int front = -1;
        private int rear = -1;
        private int size = 0;
        private int count = 0;
        public CircularArrayTypedQueue(int size)
        {
            this.size = size;
            Queue = new object[size];
        }
        public void Insert(object o)
        {
            
            if (count == size)
                throw new Exception("Queue dolu.");

            if (front == -1)
                front = 0;

            if (rear == size - 1)
            {
                rear = 0;
                Queue[rear] = o;
            }
            else
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
                front = 0;
            else
                front++;

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

        public float  OrtalamaBul()
        {
            return OrtalamaToplamSure / 20;
        }

        public string MusteriGoster(Musteri m)
        {
            int x = ToplamSureBul(m.IslemSuresi);//Fonksiyona gelen müşteri için işlem tamamlanma süresi hesaplandı.
            string temp = "";
             temp = m.MusteriNo + " Numaralı müşterinin işlem süresi:" + m.IslemSuresi + " sn" + " İşlem tamamlanma süresi:" +x + " sn" + Environment.NewLine;
             OrtalamaToplamSure += x;//gelen müşterinin işlem tamamlanma süresi ortalama işlem süresi hesaplanmak için ortalamaToplamSureye eklendi.
            return temp;
        }
    }
}
