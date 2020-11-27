using System;
using System.Collections.Generic;
using System.Text;

namespace Lab8_2
{
    public class SmartPhone: СolorScreenPhone
    {
        public bool IsSupportTouchScreen { get; set; }
        public int CountOfTouchs { get; set; }
        public int CountOfCameras { get; set; }

        public void TakeAPhoto()
        {
            var temp = Console.ReadLine();
            CountOfTouchs.ToString();
            CountOfCameras.ToString();
        }
    }
}
