using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Database
{
    public static class FemeiDatabase
    {
        public static List<Equipment> Equipments = new List<Equipment>()
        {
            //pantofi
            //femei
            new Equipment()
            {
                Description="Pantofi dama adidas Streetcheck",
                Price=299.99,
                Color="WHITE"
            },
            new Equipment()
            {
                Description="Pantofi dama Advantage",
                Price=349.99,
                Color="WHITE-PINK"
            },
            new Equipment()
            {
                Description="Pantofi Balet Full Sole Lea",
                Price=71.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Pantofi dama Nike Air Zoom SuperRep 3",
                Price=649.99,
                Color="GREY"
            },
            new Equipment()
            {
                Description="Pantofi dama Adidas Karlie Kloss",
                Price=699.99,
                Color="WHITE-GREY"
            },

            
            //haine
            new Equipment()
            {
                Description="Hanorac Dama Nike Sportwear AIR",
                Price=244.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Colanti dama Pro Dri-FIT Nike SSNL HR TIGHT",
                Price=219.99,
                Color="BLACK-WHITE"
            },
            new Equipment()
            {
                Description="Colanti dama Pro Dri-FIT Nike SSNL HR TIGHT",
                Price=83.99,
                Color="LILAC"
            },
             new Equipment()
            {
                Description="Jacheta dama Itavic 3-Stripes Midweight",
                Price=599.99,
                Color="WHITE"
            },
            new Equipment()
            {
                Description="Bustiera Dama Nike Swoosh UltraBreathe",
                Price=174.99,
                Color="BEIGE"
            },

            //accesorii
            //femei
            new Equipment()
            {
                Description="Disc greutate cu 3 manere de 15Kg",
                Price=159.99,
                Color="GREY"
            },
            new Equipment()
            {
                Description="Curled Bar 120cm-28mm",
                Price=119.99,
                Color="SILVER"
            },
            new Equipment()
            {
                Description="Rucsac Vancouver ",
                Price=29.99,
                Color="GREY"
            },
             new Equipment()
            {
                Description="Ochelari inot Goggles Fastskin Speedsocket",
                Price=229.99,
                Color="WHITE-BLACK"
            },
            new Equipment()
            {
                Description="Manusi Box",
                Price=59.99,
                Color="RED-YELL"
            }



        };

    }
}
