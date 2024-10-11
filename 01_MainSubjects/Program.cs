using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_MainSubjects
{
    internal class Program 
    {
        static void Main(string[] args)
        {

            #region YazdirmaKomutlari
            //Console.WriteLine("Merhaba Dünya");
            //Console.Write("Selam");

            //Console.Read();

            //Console.WriteLine("***** YEMEK KATEGORILERI *****");
            //Console.WriteLine();
            //Console.WriteLine("1-) Çorbalar");
            //Console.WriteLine("2-) Ana Yemekler");
            //Console.WriteLine("3-) Soğuk Başlangıçlar");
            //Console.WriteLine("4-) Tatlılar");
            //Console.WriteLine("5-) İçecekler");
            //Console.WriteLine();

            //Console.WriteLine("***** YEMEK KATEGORILERI *****");


            #endregion

            #region String Degiskenler

            //String Degiskenler
            //degiskenturu degiskenadi ;

            //string name;
            //name = "Furkan";
            //Console.Write(name);

            //string customerName;
            //string customerSurname;
            //string customerPhone;
            //string customerEmail, district, city;

            //customerName = "Furkan";
            //customerSurname = "Duman";
            //customerPhone = "+90 500 400 30 20";
            //customerEmail = "deneme@gmail.com";
            //district = "Kartal";
            //city = "Istanbul";

            //Console.WriteLine("**** Rezervasyon Kartı ****");
            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");


            //customerName = "Ayşegül";
            //customerSurname = "Kaya";
            //customerPhone = "+90 400 300 80 70";
            //customerEmail = "test@gmail.com";
            //district = "Sapanca";
            //city = "Sakarya";


            //Console.WriteLine();
            //Console.WriteLine("----------------------------");
            //Console.WriteLine("Müşteri: " + customerName + " " + customerSurname);
            //Console.WriteLine("İletişim: " + customerPhone);
            //Console.WriteLine("Email Adresi: " + customerEmail);
            //Console.WriteLine("Adres: " + district + "/" + city);
            //Console.WriteLine("----------------------------");








            #endregion

            #region Int Degiskenler

            //int 

            int hamburgerPrice = 300;
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("**** Restoran Menü Fiyatı ****");
            Console.WriteLine();
            Console.WriteLine("----- Hamburger: " + hamburgerPrice + " TL ");
            Console.WriteLine("----- Kola: " + cokePrice + " TL ");
            Console.WriteLine("----- Su: " + waterPrice + " TL ");
            Console.WriteLine("----- Kızartma: " + friesPrice + " TL ");
            Console.WriteLine("----- Pizza: " + pizzaPrice + " TL ");
            Console.WriteLine("----- Limonata: " + lemonadePrice + " TL ");

            Console.WriteLine();
            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice;
            int totalCokePrice;
            int totalWaterPrice;
            int totalFriesPrice;
            int totalPizzaPrice;
            int totalLemonadePrice;


            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 3;
            friesCount = 1;
            pizzaCount = 0;
            lemonadeCount = 0;


            totalHamburgerPrice = hamburgerCount * hamburgerPrice;
            totalCokePrice = cokeCount * cokePrice;
            totalWaterPrice = waterCount * waterPrice;
            totalFriesPrice = friesCount * friesPrice;
            totalPizzaPrice = pizzaCount * pizzaPrice;
            totalLemonadePrice = lemonadeCount * lemonadePrice;


   

            Console.WriteLine("----------------------------------------");
            Console.WriteLine("Hamburger Tutarı: " + totalHamburgerPrice);
            Console.WriteLine("Pizza Tutarı: " + totalPizzaPrice);
            Console.WriteLine("Kola Tutarı: " + totalCokePrice);
            Console.WriteLine("Su Tutarı: " + totalWaterPrice);
            Console.WriteLine("Kızartma Tutarı: " + totalFriesPrice);
            Console.WriteLine("Limonata Tutarı: " + totalLemonadePrice);

            Console.WriteLine();

            int totalPrice = totalLemonadePrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalHamburgerPrice;

            Console.WriteLine("Toplam Ödenecek Tutar: " + totalPrice + "TL");




            #endregion




            Console.Read();
        }
    }
}


//Yazdırma Komutları