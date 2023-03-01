using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Vidzy = new VidzyEntities();
            var movieDate = new DateTime(2008, 7, 21);
            Vidzy.AddVideo("The Dark Knight", movieDate, "Horror");
        }
    }
}
