using System;
using System.Net;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int CurrentYear = DateTime.Now.Year - 1;
            string Game = GrabTodaysData.GrabData(CurrentYear);
        }
    }
}
