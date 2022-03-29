using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using shelterminiproj.Shared;
public class SampleShelters
{
    public readonly static List<Shelter> list1 = new List<Shelter>()
        {
            new Shelter {name = "shelter1",tilladte_personer = 5,tilgængelig = true },
            new Shelter {name = "shelter2",tilladte_personer = 5,tilgængelig = true },
            new Shelter {name = "shelter3",tilladte_personer = 5,tilgængelig = true },
            new Shelter {name = "shelter4",tilladte_personer = 5,tilgængelig = true },
            new Shelter {name = "shelter5",tilladte_personer = 5,tilgængelig = true }
        };

    public readonly static List<Shelter> list2 = new List<Shelter>()
    {

    };
}