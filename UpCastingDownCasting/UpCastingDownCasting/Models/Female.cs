using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingDownCasting.Models
{
    class Female:InEurope
    {

        public void Sound() { }
        public override void Death()
        {
            Console.WriteLine("Low"); ;
        }
        public override void SmokingRate()
        {
            Console.WriteLine("Low");
        }
    }
}
