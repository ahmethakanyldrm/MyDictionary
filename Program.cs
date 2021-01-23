﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> cities = new MyDictionary<int, string>();
            cities.Add(23, "Elazığ");
            cities.Add(19, "Çorum");
            cities.Add(31, "Hatay");
            cities.Add(42, "Konya");
            cities.Add(47, "Mardin");
            cities.Add(45, "Manisa");
            cities.Add(41, "Kocaeli");

            
               for (int i = 0; i < cities.Cities.Length; i++)
            {
                Console.WriteLine("Şehir : {0}   Plaka Kodu : {1}",cities.Cities[i],cities.PlateNumbers[i]);
            }
            
            //2 farklı foreach ile yazdırma 
            
            //foreach (var city in cities.Cities)
            //{
            //    Console.WriteLine("Şehir : " + city);
            //}
            //Console.WriteLine();
            //Console.WriteLine("------------");
            //Console.WriteLine();
            //foreach (var plateNumber in cities.PlateNumbers)
            //{
            //    Console.WriteLine("Plaka Kodu  : " + plateNumber);
            //}
           
                     
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
