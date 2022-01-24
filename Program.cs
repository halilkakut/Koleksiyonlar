using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collection Generic
            // T => object türündedir

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);

            foreach (var sayi in sayiListesi)
            {
                Console.WriteLine(sayi);
            }

            foreach (var renk in renkListesi)
            {
                Console.WriteLine(renk);
            }

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Listeden Eleman Çıkarma
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Liste içerisinde Arama
            if(sayiListesi.Contains(10)){
                Console.WriteLine("10 Liste içerisinde bulundu");
            }

            //Eleman ile indexe erişme
            Console.WriteLine(renkListesi.BinarySearch("Sarı")); //indexi getirir

            //Diziyi Listeye Çevirme
            string[] hayvanlar = {"Kedi","Köpek","Kuş"};
            List<string> animalList = new List<string>(hayvanlar);

            //Listeyi nasıl temizleriz
            animalList.Clear();

            //Liste içerisinde nesne tutmak
            List<Users> userList = new List<Users>();
            
            Users user = new Users();
            user.Name = "Halil";
            user.LastName = "Kakut";
            user.Age = 28;

            Users user1 = new Users();
            user1.Name = "Ahmet";
            user1.LastName = "Kakut";
            user1.Age = 21;

            userList.Add(user1);
            userList.Add(user);

            List<Users> newList = new List<Users>();
            newList.Add(new Users(){
                Name = "Osman",
                LastName ="yılmaz",
                Age = 20
            });

            foreach (var item in userList)
            {
                Console.WriteLine("Kullanıcı Adı: "+item.Name);
                Console.WriteLine("Kullanıcı Soyisim: "+item.LastName);
                Console.WriteLine("Kullanıcı Yaş: " +item.Age);
            }

        }
    }

    public class Users{
        private string name;
        private string lastName;
        private int age;

        public string Name { get => name; set => name = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
    }
}
