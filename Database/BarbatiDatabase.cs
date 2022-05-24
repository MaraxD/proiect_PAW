using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Database
{
    public static class BarbatiDatabase
    {
        public static List<Equipment> Equipments = new List<Equipment>()
        {
            //pantofi
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi baschet barbati Trae Young 1-Adidas",
                Price=479.99,
                Color="BLUE-RED",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi antrenament barbati Air Zoom SuperRep 2",
                Price=471.99,
                Color="ΡΟΖ-Σ.ΜΗΛΟ",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi tenis barbati NikeCourt Air Max Volley",
                Price=449.99,
                Color="BLACK",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi Nike Court Vision Low Next Nature",
                Price=349.99,
                Color="WHITE",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantofi casual barbati Court Royale 2 Low",
                Price=223.99,
                Color="WHITE-BLUE",
                Category="Men"
            },

            

            //haine
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Jacheta barbati Sportswear Swoosh",
                Price=363.99,
                Color="WHITE-RED",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantaloni Scurti Club barbati",
                Price=149.99,
                Color="BLACK",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantaloni trening barbati Jumpman Fleece",
                Price=190.99,
                Color="BLACK",
                Category="Men"
            },
             new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Vesta barbati Essentials Down Vest",
                Price=389.99,
                Color="BLACK",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Pantaloni de trening Club Oh Jsy barbati",
                Price=224.99,
                Color="BLACK",
                Category="Men"
            },



            //accesorii
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Borseta Nike Heritage",
                Price=99.99,
                Color="BLACK-WHITE",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Racheta Us Open 25",
                Price=69.99,
                Color="WHITE-RED",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Suport Pentru Genunchi,",
                Price=27.99,
                Color="BLACK",
                Category="Men"
            },
             new Equipment()
            {
                 Id=Guid.NewGuid(),
                Description="Geanta fitness Teambag",
                Price=59.99,
                Color="BLACK",
                Category="Men"
            },
            new Equipment()
            {
                Id=Guid.NewGuid(),
                Description="Manusi",
                Price=20.99,
                Color="BLACK",
                Category="Men"
            }

        };

    }
}
