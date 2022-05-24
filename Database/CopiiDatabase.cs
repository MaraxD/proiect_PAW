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
                Id = Guid.NewGuid(),
                Description = "Pantofi Adidas Streetcheck",
                Price = 111.99,
                Color = "WHITE",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Pantofi Nike Air Zoom SuperRep 3",
                Price = 167.99,
                Color = "GREY",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Pantofi baschet Trae Young 1-Adidas",
                Price = 139.99,
                Color = "BLUE-RED",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Pantofi tenis NikeCourt Air Max Volley",
                Price = 127.99,
                Color = "BLACK",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Pantofi copii Grand Court",
                Price = 174.99,
                Color = "WHITE-BLUE",
                Category = "Kids"
            },

            //haine
            //copii
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Trening copii X Football-Inspired Track Suit",
                Price = 199.99,
                Color = "BLACK",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Tricou copii Jordan",
                Price = 167.99,
                Color = "WHITE-RED",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Tricou Adidas ",
                Price = 54.49,
                Color = "PINK",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Pantofi tenis NikeCourt Air Max Volley",
                Price = 127.99,
                Color = "BLACK",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Set De Inot Back To School",
                Price = 69.99,
                Color = "NAVY-PINK",
                Category = "Kids"
            },

            //accesorii
            //copii
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Role Rollers Ils",
                Price = 239.99,
                Color = "BLACK-RED",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Casca copii Prostyle Matt 2.0-Firefly",
                Price = 43.99,
                Color = "LIME",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Trotineta copii Wild Ones",
                Price = 339.99,
                Color = "PINK-LILAC",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Trotineta A 200",
                Price = 399.99,
                Color = "BROWN-BLACK",
                Category = "Kids"
            },
            new Equipment()
            {
                Id = Guid.NewGuid(),
                Description = "Protectii Leisureline",
                Price = 71.99,
                Color = "BLACK-GREY",
                Category = "Kids"
            }

        };
    }
}
