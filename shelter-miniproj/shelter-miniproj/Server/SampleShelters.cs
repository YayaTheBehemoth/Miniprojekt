using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shelterminiproj.Shared;
public class SampleShelters
{
    public readonly static List<ShelterClass> list1 = new List<ShelterClass>()
        {
            new ShelterClass {Name = "shelter1",Tilladte_personer = 5,Tilgængelig = true },
            new ShelterClass {Name = "shelter2",Tilladte_personer = 5,Tilgængelig = true },
            new ShelterClass {Name = "shelter3",Tilladte_personer = 5,Tilgængelig = true },
            new ShelterClass {Name = "shelter4",Tilladte_personer = 5,Tilgængelig = true },
            new ShelterClass {Name = "shelter5",Tilladte_personer = 5,Tilgængelig = true }
        };

    public readonly static List<ShelterClass> list2 = new List<ShelterClass>()
    {

    };
}