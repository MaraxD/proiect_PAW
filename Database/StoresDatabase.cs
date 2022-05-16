using seminar9.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seminar9.Database
{
    class StoresDatabase
    {
        public static List<Store> stores = new List<Store>() 
        { 
            new Store()
            {
                City="Brasov",
                Location="Afi Brașov-Bld.15 Noiembrie, Nr 78,Centrul Comercial Afi Brașov, Unitatea Nr 2013, 500097",
                PhoneNumber="0274839104",
                Program="Luni - Duminica: 10:00 - 22:00"
            },
            new Store()
            {
                City="Bucuresti",
                Location="AFI Palace Cotroceni - Bulevardul General Paul Teodorescu 4",
                PhoneNumber="0294810347",
                Program="Luni - Duminica: 10:00 - 22:00"
            },
            new Store()
            {
                City="Ploiesti",
                Location="CENTRUL COMERCIAL AFI PALACE, str. Calomfirescu nr 2",
                PhoneNumber="0274839104",
                Program="Luni - Duminica: 10:00 - 22:00"
            },
            new Store()
            {
                City="Bacau",
                Location="Complex comercial Arena Mall - Str. Stefan cel Mare nr.28 ",
                PhoneNumber="0295166722",
                Program="Luni - Duminica: 10:00 - 22:00"
            },
            new Store()
            {
                City="Baia Mare",
                Location="VIVO BAIA MARE, Str. Victoriei nr 73",
                PhoneNumber="0299836105",
                Program="Luni - Duminica: 10:00 - 22:00"
            },
            new Store()
            {
                City="Buzau",
                Location="Complex comercial AURORA - B-dul Unirii, nr. 232",
                PhoneNumber="0290974651",
                Program="Luni - Duminica: 10:00 - 22:00"
            },
            new Store()
            {
                City="Cluj",
                Location="VIVO CLUJ NAPOCA - Str. Avram Iancu, nr. 492 – 500",
                PhoneNumber="0291546789",
                Program="Luni - Duminica: 10:00 - 22:00"
            },
            new Store()
            {
                City="Galati",
                Location="GALATI SHOPPING CITY, Str. George Cosbuc nr 251",
                PhoneNumber="0286934251",
                Program="Luni - Duminica: 10:00 - 22:00"
            }
        };

    }
}
