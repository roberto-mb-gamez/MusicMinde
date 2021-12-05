using System;
using System.Collections.Generic;

namespace MusicMudeApi
{
    public class Showing
    {
        public string Location { get; set; }
        public int NumberOfSeats { get; set; }
        public List<DateTime> ShowTimes { get; set; }
    }
}
