using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Database
{
    public static class FemeiDatabase
    {
        public static BindingList<Equipment> Equipments = new BindingList<Equipment>()
        {
            //pantofi
            //femei
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi dama adidas Streetcheck",
                Price=299.99,
                Color="WHITE",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi dama Advantage",
                Price=349.99,
                Color="WHITE-PINK",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi Balet Full Sole Lea",
                Price=71.99,
                Color="BLACK",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi dama Nike Air Zoom SuperRep 3",
                Price=649.99,
                Color="GREY",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi dama Adidas Karlie Kloss",
                Price=699.99,
                Color="WHITE-GREY",
                Category = "Woman"
            },

            
            //haine
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Hanorac Dama Nike Sportwear AIR",
                Price=244.99,
                Color="BLACK",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Colanti dama Pro Dri-FIT Nike SSNL HR TIGHT",
                Price=219.99,
                Color="BLACK-WHITE",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Colanti dama Pro Dri-FIT Nike SSNL HR TIGHT",
                Price=83.99,
                Color="LILAC",
                Category = "Woman"
            },
             new Equipment()
            {
                 Id=Guid.NewGuid(),
                Description="Jacheta dama Itavic 3-Stripes Midweight",
                Price=599.99,
                Color="WHITE",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Bustiera Dama Nike Swoosh UltraBreathe",
                Price=174.99,
                Color="BEIGE",
                Category = "Woman"
            },

            //accesorii
            //femei
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Disc greutate cu 3 manere de 15Kg",
                Price=159.99,
                Color="GREY",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Curled Bar 120cm-28mm",
                Price=119.99,
                Color="SILVER",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Rucsac Vancouver ",
                Price=29.99,
                Color="GREY",
                Category = "Woman"
            },
             new Equipment()
            {
                 Id=Guid.NewGuid(),
                Description="Ochelari inot Goggles Fastskin Speedsocket",
                Price=229.99,
                Color="WHITE-BLACK",
                Category = "Woman"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Manusi Box",
                Price=59.99,
                Color="RED-YELL",
                Category = "Woman"
            }



        };

    }
}
