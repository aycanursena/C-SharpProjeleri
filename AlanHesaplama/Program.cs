using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;

namespace AlanHesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           Metotlar yeni = new Metotlar();
            yeni.IslemMenusu();

           
        }
        
    }
}