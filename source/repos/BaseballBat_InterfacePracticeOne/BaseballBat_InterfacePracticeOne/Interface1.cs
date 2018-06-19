using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseballBat_InterfacePracticeOne
{
    public interface IBaseballBat
    {
        void Swing();
        int WeightInGrams { get; set; }

    }
}
