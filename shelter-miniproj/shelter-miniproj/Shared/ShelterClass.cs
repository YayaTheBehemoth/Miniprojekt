using System;
using System.Collections.Generic;
using System.Text;
namespace shelterminiproj.Shared
{
    public class ShelterClass
    {
        public string Name { get; set; }
        public int Tilladte_personer { get; set; }
        public bool Tilgængelig { get; set; }

        public ShelterClass(string n, int tp, bool t)
        {
            Name = n;
            Tilladte_personer = tp;
            Tilgængelig = t;
        }

        public ShelterClass()
        {
            
        }

    }
}
