﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascaglassia
{
    class Program
    {
        private static void DrawLine()
        {
            Console.WriteLine("_______________________________________________________________________________");
        }

        private static void DrawStar()
        {
            Console.WriteLine("************************");
        }

        private static void NewLine()
        {
            Console.WriteLine("\n");
        }

        public class Database
        {
            public string Nama { get; set; }
            public string Sex { get; set; }
            public int Umur { get; set; }
        }


        static void Main(string[] args)
        {

            //KOSMETIK
            Console.Title = "Horoscope";
            Console.ForegroundColor = ConsoleColor.Cyan;

            //Header.... LOL
            DrawLine();
            Console.WriteLine("                  H    O     R     O     S     C     O    P    E");
            DrawLine();


            //Menu, mungkin, nanti nya...
            DrawStar();
            Console.WriteLine("++" + DateTime.Today + "++");
            DrawStar();

            //Deklarasi
            String Bday;
            String Gender;
            String Name;
            String Zodiak;
            DateTime Tanggal = new DateTime();



            //INPUT DARI USER
            Console.WriteLine("Insert your Birthday . . . (I.E. : 22 July 1995)");
            Bday = Console.ReadLine();
            NewLine();
            Console.WriteLine("Now, Type your gender . . .");
            Gender = Console.ReadLine();
            NewLine();
            Console.WriteLine("Thx, last but not least, Your name please . . .");
            Name = Console.ReadLine();
            NewLine();
            Console.WriteLine("THANK YOU!!! ^,^");
            Console.WriteLine("Here's your information");
            NewLine();


            //CONVERT INPUT JADI FORMAT TANGGAL
            try
            {
                Tanggal = Convert.ToDateTime(Bday);
            }
            catch (Exception x)
            {
                Console.WriteLine("Oopss... Much Error, Such WOW :" + x.Message + "\n \n Its okay, try again ...");
            }

            //Calculating UMUR
            var Today = DateTime.Today;
            var age = Today.Year - Tanggal.Year;


            //Check BULAN then TANGGAL to menentukan Zodiak menggunakan SWITCH CASE.
            //switch (Tanggal.Month)
            //{

            //    case 1:
            //        if (Tanggal.Day <= 20)
            //        { Console.WriteLine("Zodiak mu adalah Capricorn"); Zodiak = "Capricorn"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Aquarius"); Zodiak = "Aquarius"; }
            //        break;

            //    case 2:
            //        if (Tanggal.Day <= 19)
            //        { Console.WriteLine("Zodiak mu adalah Aquarius"); Zodiak = "Aquarius"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Pisces"); Zodiak = "Pisces"; }
            //        break;

            //    case 3:
            //        if (Tanggal.Day <= 21)
            //        { Console.WriteLine("Zodiak mu adalah Pisces"); Zodiak = "Pisces"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Aries"); Zodiak = "Aries"; }
            //        break;

            //    case 4:
            //        if (Tanggal.Day <= 19)
            //        { Console.WriteLine("Zodiak mu adalah Aries"); Zodiak = "Aries"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Taurus"); Zodiak = "Taurus"; }
            //        break;

            //    case 5:
            //        if (Tanggal.Day <= 20)
            //        { Console.WriteLine("Zodiak mu adalah Taurus"); Zodiak = "Taurus"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Gemini"); Zodiak = "Gemini"; }
            //        break;

            //    case 6:
            //        if (Tanggal.Day <= 21)
            //        { Console.WriteLine("Zodiak mu adalah Gemini"); Zodiak = "Gemini"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Cancer"); Zodiak = "Cancer"; }
            //        break;

            //    case 7:
            //        if (Tanggal.Day <= 22)
            //        { Console.WriteLine("Zodiak mu adalah Cancer"); Zodiak = "Gemini"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Leo"); Zodiak = "LEO"; }
            //        break;


            //    case 8:
            //        if (Tanggal.Day <= 23)
            //        { Console.WriteLine("Zodiak mu adalah Leo"); Zodiak = "LEO"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Virgo"); Zodiak = "Virgo"; }
            //        break;

            //    case 9:
            //        if (Tanggal.Day <= 22)
            //        { Console.WriteLine("Zodiak mu adalah Virgo"); Zodiak = "Virgo"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Libra"); Zodiak = "Libra"; }
            //        break;

            //    case 10:
            //        if (Tanggal.Day <= 23)
            //        { Console.WriteLine("Zodiak mu adalah Libra"); Zodiak = "Libra"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Scorpio"); Zodiak = "Scorpio"; }
            //        break;

            //    case 11:
            //        if (Tanggal.Day <= 22)
            //        { Console.WriteLine("Zodiak mu adalah Scorpio"); Zodiak = "Scorpio"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Sagitarius"); Zodiak = "Sagitarius"; }
            //        break;

            //    case 12:
            //        if (Tanggal.Day <= 21)
            //        { Console.WriteLine("Zodiak mu adalah Sagitarius"); Zodiak = "Sagitarius"; }
            //        else
            //        { Console.WriteLine("Zodiak mu adalah Capricorn"); Zodiak = "Capricorn"; }
            //        break;

            //    default:
            //        Console.WriteLine("Sepertinya ada yang salah dengan hidup mu, zodiac nya ga ketemu :((");
            //        break;

            //}


            if (Tanggal.Month == 1)
            {
                if (Tanggal.Day <= 20)
                { Console.WriteLine("Zodiak mu adalah Capricorn"); Zodiak = "Capricorn"; }
                else
                { Console.WriteLine("Zodiak mu adalah Aquarius"); Zodiak = "Aquarius"; }
            }

            else if (Tanggal.Month == 2)
            {
                if (Tanggal.Day <= 19)
                { Console.WriteLine("Zodiak mu adalah Aquarius"); Zodiak = "Aquarius"; }
                else
                { Console.WriteLine("Zodiak mu adalah Pisces"); Zodiak = "Pisces"; }
            }

            else if (Tanggal.Month == 3)
            {
                if (Tanggal.Day <= 21)
                { Console.WriteLine("Zodiak mu adalah Pisces"); Zodiak = "Pisces"; }
                else
                { Console.WriteLine("Zodiak mu adalah Aries"); Zodiak = "Aries"; }
            }

            else if (Tanggal.Month == 4)
            {
                if (Tanggal.Day <= 19)
                { Console.WriteLine("Zodiak mu adalah Aries"); Zodiak = "Aries"; }
                else
                { Console.WriteLine("Zodiak mu adalah Taurus"); Zodiak = "Taurus"; }
            }

            else if (Tanggal.Month == 5)
            {
                if (Tanggal.Day <= 20)
                { Console.WriteLine("Zodiak mu adalah Taurus"); Zodiak = "Taurus"; }
                else
                { Console.WriteLine("Zodiak mu adalah Gemini"); Zodiak = "Gemini"; }
            }

            else if (Tanggal.Month == 6)
            {
                if (Tanggal.Day <= 21)
                { Console.WriteLine("Zodiak mu adalah Gemini"); Zodiak = "Gemini"; }
                else
                { Console.WriteLine("Zodiak mu adalah Cancer"); Zodiak = "Cancer"; }
            }

            else if (Tanggal.Month == 7)
            {
                if (Tanggal.Day <= 22)
                { Console.WriteLine("Zodiak mu adalah Cancer"); Zodiak = "Gemini"; }
                else
                { Console.WriteLine("Zodiak mu adalah Leo"); Zodiak = "LEO"; }
            }

            else if (Tanggal.Month == 8)
            {
                if (Tanggal.Day <= 23)
                { Console.WriteLine("Zodiak mu adalah Leo"); Zodiak = "LEO"; }
                else
                { Console.WriteLine("Zodiak mu adalah Virgo"); Zodiak = "Virgo"; }
            }

            else if (Tanggal.Month == 9)
            {
                if (Tanggal.Day <= 22)
                { Console.WriteLine("Zodiak mu adalah Virgo"); Zodiak = "Virgo"; }
                else
                { Console.WriteLine("Zodiak mu adalah Libra"); Zodiak = "Libra"; }
            }

            else if (Tanggal.Month == 10)
            {
                if (Tanggal.Day <= 23)
                { Console.WriteLine("Zodiak mu adalah Libra"); Zodiak = "Libra"; }
                else
                { Console.WriteLine("Zodiak mu adalah Scorpio"); Zodiak = "Scorpio"; }
            }

            else if (Tanggal.Month == 11)
            {
                if (Tanggal.Day <= 22)
                { Console.WriteLine("Zodiak mu adalah Scorpio"); Zodiak = "Scorpio"; }
                else
                { Console.WriteLine("Zodiak mu adalah Sagitarius"); Zodiak = "Sagitarius"; }
            }

            else if (Tanggal.Month == 12)
            {
                if (Tanggal.Day <= 21)
                { Console.WriteLine("Zodiak mu adalah Sagitarius"); Zodiak = "Sagitarius"; }
                else
                { Console.WriteLine("Zodiak mu adalah Capricorn"); Zodiak = "Capricorn"; }
            }

            else
            {
                Console.WriteLine("Sepertinya ada yang salah dengan hidup mu, zodiac nya ga ketemu :((");
            }






















            



            DrawLine();
            DrawLine();

            //INSERT THE INPUT To Database
            List<Database> DB = new List<Database>()
            {
                new Database {Nama = Name, Sex = Gender, Umur = age}
            };



            //KOSMETIK ACTUALLT, for somethin~~~~
            List<string> sumber = new List<string>()
            {
                "Ada seorang manusia, dengan Nama",
                "WATCHOUT!!! ",
                "INI KATA KE-TIGA",
                "UBU J A KOW "
            };

            int l = sumber.Count;
            Random r = new Random();
            int xxx = r.Next(l);
            var Inirandom = sumber[xxx];


            //OUTPUT Final~~~
            Console.WriteLine("umur kamu   " + age);
            NewLine();

            Console.WriteLine(Inirandom);
            Console.WriteLine("Press Enter to Continue . . .");
            Console.ReadLine();

            foreach (var Output in DB)
                Console.WriteLine("    Nama : " + Output.Nama + "\n    Gender : " + Output.Sex + "\n     Umur : " + Output.Umur + "\n \n");
            

        }
    }
}



