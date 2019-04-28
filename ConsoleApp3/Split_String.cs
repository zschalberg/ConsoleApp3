using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp3
{
    class Split_String
    {
        public static String[] split_game(string game_data)
        {
            var players = game_data.Split("ID");
            return players;
        }
    }
}
