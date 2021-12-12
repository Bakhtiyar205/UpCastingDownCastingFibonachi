using System;
using System.Collections.Generic;
using System.Text;

namespace UpCastingDownCasting.Models
{
    public abstract class Person
    {
        public abstract void Death();
        public virtual void SmokingRate()
        {
            Console.WriteLine("Medium");
        }
    }
}
