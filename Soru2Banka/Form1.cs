using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2Banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int[] KarsilastirmaDongusel = new int[20];
        int i ,j,z= 0;
        CircularArrayTypedQueue c = new CircularArrayTypedQueue(20);
        PriorityQueueKB pKB=new PriorityQueueKB(20);
        PriorityQueueBK pBK = new PriorityQueueBK(20);


        public string KarsilastirKB(Musteri m)//Döngüsel kuyruk Öncelik Kuyruğu(K-->B) karşılaştırması
        {
            string temp = "";
             for(int i=0;i<20;i++)
            {
                if(i==m.MusteriNo-1)//gelen müşterinin müşteri numarasına göre dizide(KarsilastirmaDongusel) arama işlemi
                {
                    if(KarsilastirmaDongusel[i]>pKB.ToplamSure)
                        //gelen müşteri dizide bulununca 
                        //müşterinin döngüsel kuyruk işlem tamamlanma süresi ile öncelik kuyruğu(K-->B) işlem tamamlanma süresi karşılaştırıldı.
                    {
                        temp = m.MusteriNo + " Numaralı müşterinin öncelik kuyruğundaki işlem tamamlanma süresi daha kısadır!"+" İşlem süresi:"+ m.IslemSuresi+" sn " + "Kazanç:" + (KarsilastirmaDongusel[i] - pKB.ToplamSure)+" sn"+Environment.NewLine;
                    }
                }
                
            }
             return temp;
        }


        public string KarsilastirBK(Musteri m)//Döngüsel kuyruk Öncelik Kuyruğu(B-->K) karşılaştırması
        {
            string temp = "";
            for (int i = 0; i < 20; i++)
            {
                if (i == m.MusteriNo - 1)//gelen müşterinin müşteri numarasına göre dizide(KarsilastirmaDongusel) arama işlemi
                {
                    if (KarsilastirmaDongusel[i] > pBK.ToplamSure)
                    //gelen müşteri dizide bulununca 
                    //müşterinin döngüsel kuyruk işlem tamamlanma süresi ile öncelik kuyruğu(B-->K) işlem tamamlanma süresi karşılaştırıldı.
                    {
                        temp = m.MusteriNo + " Numaralı müşterinin öncelik kuyruğundaki işlem tamamlanma süresi daha kısadır!" + " İşlem süresi:" + m.IslemSuresi + " sn " + "Kazanç:" + (KarsilastirmaDongusel[i] - pBK.ToplamSure) + " sn" + Environment.NewLine;
                    }
                }

            }
            return temp;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            Random r = new Random();
            for (int i = 0; i <20; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNo = i+1;
                m.IslemSuresi = r.Next(60, 600);
                c.Insert(m);
                pKB.Insert(m);
                pBK.Insert(m);
                //Müşteriler kuyruklara eklendi.
            }

        }


        private void btnSil_Click(object sender, EventArgs e)
        {
            if (i >=20)
                MessageBox.Show("HATA KUYRUKTA MÜŞTERİ KALMADI!!"); 
            string temp="";
            Musteri m = new Musteri();
            m = (Musteri)c.Remove();//Kuyruğun önündeki müşteri kuyruktan çıkarıldı.
            temp=c.MusteriGoster(m);//İşlem tamamlanma süresi hesaplamak için müşteri fonksiyona gönderildi.

            KarsilastirmaDongusel[i] = c.ToplamSure;//Karşılaştırma yapılması için kuyruktan çıkan müşterinin işlem tamamlanma süresi(toplamSure) sırayla diziye atıldı.
            rtxtListele.Text += temp;
            i++;
         
        }


        private void btnOrtalamaIslem_Click(object sender, EventArgs e)
        {
            if (i == 20)
                lblOrtalamaIslem.Text = c.OrtalamaBul().ToString() + " Saniye";//20 müşterinin döngüsel kuyruğa göre ortalama işlem tamamlanma süresi hesaplandı.
            else
                MessageBox.Show("DİKKAT! KUYRUKTAN 20 MÜŞTERİYİ DE ÇIKARIN");
        }


        private void btnSilOncelikKB_Click(object sender, EventArgs e)
        {
            string temp = "";
            j++;
            if (j > 20)
            MessageBox.Show("HATA KUYRUKTA MÜŞTERİ KALMADI!!");
            Musteri m = new Musteri();
            m = (Musteri)pKB.Remove();
            temp = pKB.MusteriGoster(m);
            rtxtListeleKB.Text += temp;
            rtxtKarsilastirListeleKB.Text+=KarsilastirKB(m); //Her bir müşterinin Döngüsel kuyruktaki işlem tamamlanma süresi öncelik kuyruğundaki(K-->B) işlem tamamlanma süresiyle kıyaslandı.  
        }

        private void btnIslemTamamlanmaKB_Click(object sender, EventArgs e)
        {
            if (j== 20)
                lblIslemTamamlanmaKB.Text = pKB.OrtalamaBul().ToString() + " Saniye";//20 müşterinin öncelik kuyruğuna(K-->B) göre ortalama işlem tamamlanma süresi hesaplandı
            else
                MessageBox.Show("DİKKAT! KUYRUKTAN 20 MÜŞTERİYİ DE ÇIKARIN");
        }

        private void btnSilOncelikBK_Click(object sender, EventArgs e)
        {
            string temp = "";
            z++;
            if (z > 20)
            MessageBox.Show("HATA KUYRUKTA MÜŞTERİ KALMADI!!");
            Musteri m = new Musteri();
            m = (Musteri)pBK.Remove();
            temp = pBK.MusteriGoster(m);
            rtxtListeleBK.Text += temp;
            rtxtKarsilastirListeleBK.Text += KarsilastirBK(m);//Her bir müşterinin Döngüsel kuyruktaki işlem tamamlanma süresi öncelik kuyruğundaki(B-->K) işlem tamamlanma süresiyle kıyaslandı.  
        }

        private void btnIslemTamamlanmaBK_Click(object sender, EventArgs e)
        {
            if (z == 20)
                lblIslemTamamlanmaBK.Text = pBK.OrtalamaBul().ToString() + " Saniye";//20 müşterinin öncelik kuyruğuna(B-->K) göre ortalama işlem tamamlanma süresi hesaplandı
            else
                MessageBox.Show("DİKKAT! KUYRUKTAN 20 MÜŞTERİYİ DE ÇIKARIN");
        }

        private void btnKazancKB_Click(object sender, EventArgs e)
        {
            float fark = 0;
            float yuzde = 0;
            fark = c.OrtalamaBul() - pKB.OrtalamaBul();//Döngüsel kuyruktaki ortalama işlem süresi ile öncelik kuyruğundaki (K-->B) ortalama işlem süresi arasındaki fark bulundu.
            yuzde = 1 - (pKB.OrtalamaBul() / c.OrtalamaBul());//Kazanç yüzde olarak bulundu.
            lblKazancKB.Text = "İşlem tamamlanma süresi farkı:" + fark.ToString()+" sn" + Environment.NewLine+"Döngüsel kuyruğa göre öncelik kuyruğunu kullanmak(K-->B) %" + yuzde.ToString() + " daha avantajlıdır.";



        }

        private void btnKazanBK_Click(object sender, EventArgs e)
        {
            float fark = 0;
            float yuzde = 0;
            fark = pBK.OrtalamaBul() - c.OrtalamaBul();//Döngüsel kuyruktaki ortalama işlem süresi ile öncelik kuyruğundaki (B-->K) ortalama işlem süresi arasındaki fark bulundu.
            yuzde = 1 - (c.OrtalamaBul() / pBK.OrtalamaBul());//Kazanç yüzde olarak bulundu.
            lblKazancBK.Text = "İşlem tamamlanma süresi farkı:" + fark.ToString() +" sn"+ Environment.NewLine + "Öncelik kuyruğuna göre (B-->K) döngüsel kuyruğunu kullanmak % " + yuzde.ToString() + " daha avantajlıdır.";
        }
     
        }
    }

