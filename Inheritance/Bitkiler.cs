using System;

namespace MyNamespace
{
    public class Bitkiler:Canlılar
    {
        protected void FotosentezYapmak()
        {
            Console.WriteLine("Bitkiler Fotosentez Yapar");
        }
    }
    
    public class TohumluBitkiler:Bitkiler
    {
        public TohumluBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void TohumlaÇogalma()
        {
            Console.WriteLine("Tohumlu bitkiler tohumla Çoğalır");
        }
    }

     public class TohumsuzBitkiler:Bitkiler
    {
        public TohumsuzBitkiler()
        {
            base.FotosentezYapmak();
            base.Beslenme();
            base.Bosaltım();
            base.Solunum();
        }
        public void SporlaÇogalma()
        {
            Console.WriteLine("Tohumlu bitkiler Sporla Çoğalır");
        }
    }
}