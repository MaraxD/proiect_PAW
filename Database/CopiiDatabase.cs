using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Database
{
    public static class CopiiDatabase
    {
        public static BindingList<Equipment> Equipments = new BindingList<Equipment>()
        {
           

            //copii
            new Equipment()
            {
                Description="Pantofi Adidas Streetcheck",
                Price=111.99,
                Color="WHITE"
            },
            new Equipment()
            {
                Description="Pantofi Nike Air Zoom SuperRep 3",
                Price=167.99,
                Color="GREY"
            },
            new Equipment()
            {
                Description="Pantofi baschet Trae Young 1-Adidas",
                Price=139.99,
                Color="BLUE-RED"
            },
             new Equipment()
            {
                Description="Pantofi tenis NikeCourt Air Max Volley",
                Price=127.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Pantofi copii Grand Court",
                Price=174.99,
                Color="WHITE-BLUE"
            },

            //haine
            //copii
            new Equipment()
            {
                Description="Trening copii X Football-Inspired Track Suit",
                Price=199.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Tricou copii Jordan",
                Price=167.99,
                Color="WHITE-RED"
            },
            new Equipment()
            {
                Description="Tricou Adidas ",
                Price=54.49,
                Color="PINK"
            },
             new Equipment()
            {
                Description="Pantofi tenis NikeCourt Air Max Volley",
                Price=127.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Set De Inot Back To School",
                Price=69.99,
                Color="NAVY-PINK"
            },

            //accesorii
            //copii
            new Equipment()
            {
                Description="Role Rollers Ils",
                Price=239.99,
                Color="BLACK-RED"
            },
            new Equipment()
            {
                Description="Casca copii Prostyle Matt 2.0-Firefly",
                Price=43.99,
                Color="LIME"
            },
            new Equipment()
            {
                Description="Trotineta copii Wild Ones",
                Price=339.99,
                Color="PINK-LILAC"
            },
             new Equipment()
            {
                Description="Trotineta A 200",
                Price=399.99,
                Color="BROWN-BLACK"
            },
            new Equipment()
            {
                Description="Protectii Leisureline",
                Price=71.99,
                Color="BLACK-GREY"
            }
        };

    }
}
