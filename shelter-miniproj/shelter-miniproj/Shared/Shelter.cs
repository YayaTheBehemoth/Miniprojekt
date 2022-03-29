using System;
namespace shelterminiproj.Shared
{
    public class Shelter
    {
        public string name { get; set; }
        public int tilladte_personer { get; set; }
        public bool tilgængelig { get; set; }

        public Shelter(string n, int tp, bool t)
        {
            name = n;
            tilladte_personer = tp;
            tilgængelig = t;
        }

        public Shelter()
        {
            
        }

    }
}
