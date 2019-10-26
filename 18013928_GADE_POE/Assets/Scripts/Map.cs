using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace GADE6112___Task3
{
    class Map
    {
        
        public readonly int width = 20;
        public readonly int height = 20;

        string[,] map;

        public Map(int width, int height) {

            this.width = width;
            this.height = height;
            map = new string[width, height];
        }

        public void UpdateMap(UnitAndBuildingManager manager)
        {
          
        }

        public string GetMapDisplay()
        {
            string mapString = "";
           
            return mapString;
        }
    }
}
