﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABAAAA6
{
    
        public class Controller //тут запросы
        {

            public static void FindCheaper(Gym obj)
            {
                var display = from i in obj.data
                              orderby i.price
                              select i;

                Console.Write("Enter price: ");
                int userprice = Convert.ToInt32(Console.ReadLine());

                foreach (tennis i in display)
                {
                    if (i.price <= userprice)
                    {
                        Console.WriteLine("Tennis name" + i.Shop + " "
                            + "Goods' price: " + i.price + " BYN");
                    }
                }
            }


            public static void Find(Gym obj)
            {
                var display = from i in obj.data
                              orderby i.Shop
                              select i;

                Console.Write("Enter shop: ");
                string useshop = Convert.ToString(Console.ReadLine());

                foreach (tennis i in display)
                {
                    if (i.Shop == useshop)
                    {
                        Console.WriteLine("Shop name:" + i.Shop + " " + "Goods' price: " + i.price + " BYN");
                    }
                }
            }
        }
    
}
