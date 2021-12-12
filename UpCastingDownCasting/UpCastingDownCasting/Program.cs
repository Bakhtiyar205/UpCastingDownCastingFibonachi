using System;
using UpCastingDownCasting.Models;

namespace UpCastingDownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UpCasting
            byte num = 7;
            int num1 = num;

            //Man man = new Man();
            

            //Person man1 = new Man();
            //man1.SmokingRate();

            //Female female = new Female();
            //female.SmokingRate();

            //Person person = new Female();
            //person.SmokingRate();


            //Person female1 = new Female();

            #endregion

            #region DownCasting

            double num3= 5.7;
            int num4 =(int) num3;

            Man man = new Man();

            Person man2 = (Man)man;
            man2.Death();

            Female female = new Female();
            Person person2 = (Female)female;
            person2.SmokingRate();

            #endregion

        }
    }
}
