using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> ogrenciler = new MyDictionary<int, string>();
            ogrenciler.Add(1, "Samed Dogan");
            ogrenciler.Add(2, "Engin Demiroğ");

           
        }
    }
}
