using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingDownCasting.Models
{
    public class Man : InEurope
    {
        public void Sound() { }
        public override void Death()
        {
            Console.WriteLine("High"); ;
        }
        public override void SmokingRate()
        {
            Console.WriteLine("High"); ;
        }
    }
}
