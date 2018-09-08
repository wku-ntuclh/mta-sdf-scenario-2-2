using System;

namespace Scenario_2_2
{
    class Program
    {
        public struct Location
        {
            public int x, y, z;
        }

        static void Main(string[] args)
        {
            Location[] data = new Location[5000];
            Random r = new Random();
            for(int i = 0; i < data.Length; i++)
            {
                data[i].x = r.Next();
                data[i].y = r.Next();
                data[i].z = r.Next();
                Console.WriteLine(data[i].x + ", " + data[i].y + ", " + data[i].z);
            }
        }
    }
}
