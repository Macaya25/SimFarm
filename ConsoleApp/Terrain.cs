using System;
using System.Collections;
namespace ConsoleApp
{
    class Terrain
    {

        public string[,] cell = new string[10, 10];
        public Terrain()
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cell[i, j] = "T";
                }
                
            }
            
        }
        
    }
}
