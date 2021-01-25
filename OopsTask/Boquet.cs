using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsTask
{
        public class BoquetClass : Flower
        {
            List<Flower> Boquet = new List<Flower> { new Flower {Name="Rose", Cost=10, NumberofFlowers=5 },
                                                 new Flower {Name="Lilly",Cost=15, NumberofFlowers=15},
                                                 new Flower {Name="Carnation", Cost=12, NumberofFlowers=10 },
                                                 new Flower {Name="Cherry Blossom", Cost=20, NumberofFlowers=5 },
                                                 new Flower {Name="Chrysantemum", Cost=7, NumberofFlowers=20 },
                                                 new Flower {Name="Daisy", Cost=7, NumberofFlowers=5 }};
            public double CalculateBoquetCost()
            {
                var BoquetCost = Boquet.Select(x => x.Cost * x.NumberofFlowers).Sum(x => x);
                return BoquetCost;
            }
        }
}
