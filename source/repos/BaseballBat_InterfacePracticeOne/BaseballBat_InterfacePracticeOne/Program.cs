using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballBat_InterfacePracticeOne
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodBat = new WoodBat();
            var aluminum = new AluminumBat();
            var kipnis = new BaseballPlayer();

            kipnis.TakeTurn(woodBat);
            kipnis.TakeTurn(aluminum);
        }
    }
}
