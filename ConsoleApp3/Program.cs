﻿using System;
using System.Net;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int CurrentYear = DateTime.Now.Year - 1;
            string Game = GrabTodaysData.GrabData(CurrentYear);
            String[] all_players = Split_String.split_game(Game);
            String[] Zac = new string[1];
            Zac[0] = ("Panarin, Artmei");
            foreach (string player in all_players)
            {

            }
        }
    }
}
