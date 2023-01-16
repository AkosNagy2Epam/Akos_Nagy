using System.Text.Json;
using RestSharp;
using System;
using System.IO;

namespace WebAPITest
{
    class Program
    {
        static void Main(string[] args)
        {
            //displays the readme file

            Console.WriteLine("Hi!");
            Console.WriteLine(File.ReadAllText("readme.txt"));

            Console.ReadLine();
        }



    }
}
