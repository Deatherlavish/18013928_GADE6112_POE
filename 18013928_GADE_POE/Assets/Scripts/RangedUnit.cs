using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GADE6112___Task3
{
    class RangedUnit : Unit  {
        public void InitUnit(int x, int y,string Faction)
        {
            base.InitUnit(x, y, 150, 20, 15, 3, faction, "Archer");
        }

        
    }
}
