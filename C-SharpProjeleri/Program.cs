using System.Security.Cryptography.X509Certificates;

namespace C_SharpProjeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KolaySeviyeProjeler yeni = new KolaySeviyeProjeler();
            //yeni.TerstenYazdır();
            yeni.Algoritma();
        } 
    }
}