using System;
using System.Net;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class GrabTodaysData
    {
        public static string GrabData(int CurrentYear)
        {
            string URL = $"https://statsapi.web.nhl.com/api/v1/game/{CurrentYear}030111/boxscore";


            WebClient wc = new WebClient();
            string webData = wc.DownloadString(URL);
            return webData;
        }
        
    }
}
