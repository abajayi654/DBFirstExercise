using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstExercise
{
    public enum Classification : Byte
    {
        Silver = 1,
        Gold = 2,
        Platinum = 3,
    }
    internal class Program
    {
        static void Main(string[] args)
        {


            var Vidzy = new VidzyEntities();
            var movieDate = new DateTime(2008, 7, 21);
            Vidzy.AddVideo("The Dark Knight", movieDate, "Horror", (byte)Classification.Gold);
        }
    }
}
