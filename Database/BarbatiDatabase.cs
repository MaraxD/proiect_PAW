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
        public static BindingList<Equipment> Equipments = new BindingList<Equipment>()
        {
            //pantofi
            new Equipment()
            {

                Description="Pantofi baschet barbati Trae Young 1-Adidas",
                Price=479.99,
                Color="BLUE-RED"
            },
            new Equipment()
            {

                Description="Pantofi antrenament barbati Air Zoom SuperRep 2",
                Price=471.99,
                Color="ΡΟΖ-Σ.ΜΗΛΟ"
            },
            new Equipment()
            {

                Description="Pantofi tenis barbati NikeCourt Air Max Volley",
                Price=449.99,
                Color="BLACK"
            },
            new Equipment()
            {

                Description="Pantofi Nike Court Vision Low Next Nature",
                Price=349.99,
                Color="WHITE"
            },
            new Equipment()
            {

                Description="Pantofi casual barbati Court Royale 2 Low",
                Price=223.99,
                Color="WHITE-BLUE"
            },

            

            //haine
            new Equipment()
            {
                Description="Jacheta barbati Sportswear Swoosh",
                Price=363.99,
                Color="WHITE-RED"
            },
            new Equipment()
            {
                Description="Pantaloni Scurti Club barbati",
                Price=149.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Pantaloni trening barbati Jumpman Fleece",
                Price=190.99,
                Color="BLACK"
            },
             new Equipment()
            {
                Description="Vesta barbati Essentials Down Vest",
                Price=389.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Pantaloni de trening Club Oh Jsy barbati",
                Price=224.99,
                Color="BLACK"
            },



            //accesorii
            new Equipment()
            {
                Description="Borseta Nike Heritage",
                Price=99.99,
                Color="BLACK-WHITE"
            },
            new Equipment()
            {
                Description="Racheta Us Open 25",
                Price=69.99,
                Color="WHITE-RED"
            },
            new Equipment()
            {
                Description="Suport Pentru Genunchi,",
                Price=27.99,
                Color="BLACK"
            },
             new Equipment()
            {
                Description="Geanta fitness Teambag",
                Price=59.99,
                Color="BLACK"
            },
            new Equipment()
            {
                Description="Manusi",
                Price=20.99,
                Color="BLACK"
            }


           
        };

    }
}
