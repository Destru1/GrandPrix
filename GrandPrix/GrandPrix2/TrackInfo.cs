﻿namespace GrandPrix2
{
    public class TrackInfo
    {
        public TrackInfo(int totalLaps, int lentgh)
        {
            this.TotalLaps = totalLaps;
            this.Length = lentgh;
            this.CurrentLap = 0;
            this.Weather = string.Empty;

        }

        public int TotalLaps { get;}

        public int Length { get; }
        public int CurrentLap { get; set; }
        public string  Weather { get; set; }
    }
}
