using System;

namespace MyNamespace
{
   public class Hayvanlar:Canlılar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyona ihtiyaç duyar.");
        }
    }

    public class Sürüngenler:Hayvanlar
    {

        public Sürüngenler()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void SürünerekHareketEtme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder.");
        }
    }

    public class Kuslar:Hayvanlar
    {
        public Kuslar()
        {
            base.Adaptasyon();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuslar Ucarak hareket eder.");
        }
    }
}