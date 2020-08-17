using System;

namespace ConsoleApp
{
    class Map
    {
        
        private Terrain[] cells = new Terrain[100]; 
        public Map()
        {
            for (int i = 0; i < 100; i++)
            {
                cells[i] = new Terrain();
            }
            for (int i = 0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    cells[35].cell[i, j] = "A";
                }
            }
            
        }
        public void showMap()
        {
            for(int F = 0; F < 100; F += 10)
            {
                for (int z = 0; z < 10; z++)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        for (int j = 0; j < 10; j++)
                        {
                            Console.Write(cells[i+F].cell[z, j]);
                        }
                    }
                    Console.Write("\n");
                }
            }
            
            
            
            
        }
    }
}
