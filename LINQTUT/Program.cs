
using System;
using System.Linq;

namespace LINQTUT
{
    class Program
    {
        static void Main(string[] args)
        {
                var customers = new List<Customer>() {new Customer { Id = 1, Name = "Amazon" }, 
                                new Customer { Id = 2, Name = "Target" },
                                new Customer { Id = 3, Name = "Microsoft" }
                                                 };



                var orders = new List<Order>() {new Order { Id = 1, Description = "1st Order", Sales = 1000, CustomerId = 1 },
                             new Order { Id = 2, Description = "2nd Order", Sales = 2000, CustomerId = 3 },
                             new Order { Id = 3, Description = "3rd Order", Sales = 3000, CustomerId = 2 }
};



                var CustOrder = from o in orders
                                join c in customers
                                on o.CustomerId equals c.Id
                                select new { o, c };
                foreach (var co in CustOrder)
                {
                    Console.WriteLine($"{ co.c.Name} | {co.o.Description} | {co.o.Sales} ");
                }




            }

            var customers = new List<Customer>()
            {
               new Customer { Id }
            };



            var CustOrders = from o in orders
                             join c in customers
                                on o.CustomerId equals c.Id
                             select new { o, c };
            foreach (var co in CustOrders)
            {
                Console.WriteLine($"{co.c.name} | {co.o.Description} | {co.o.Sales}");
            }










            {
                int[] ints = new int[]
                 {
                620, 849, 649, 989, 993 ,524, 216, 173, 136, 482,
                842, 308, 251, 572, 150, 797, 611, 489, 934, 310,
                985, 764, 484, 816, 753, 925, 289, 231, 486, 761,
                621, 981, 103 ,482, 917, 124, 276, 839, 476 ,789,
                582, 631, 841, 398, 521, 796, 199, 941, 782, 953,
                412, 362, 424, 336, 812, 344, 579, 570, 212, 483,
                250, 829, 835, 429, 833, 992, 657, 461, 782, 498,
                829, 648, 189, 579, 645, 584, 989, 254, 859, 321,
                991, 421, 151, 350, 687, 491, 568, 548, 403, 836,
                303, 104, 538, 426, 150, 843, 943, 864, 694, 639
                 };
                Console.WriteLine($"Average is {ints.Average()}");

                var sum = ints.Sum() - ints.Min() - ints.Max();
                var avg = sum / (ints.Count() - 2.0);

                //Console.WriteLine($"Average without max and min is {avg}");

                #region List of ints LT Avg ordered descending
                var lowInts = ints.Where(i => i < ints.Average()).OrderByDescending(i => i); // linq/lambda syntax
                foreach (var i in lowInts)
                {
                    Console.WriteLine($"{i}");
                }
                #endregion

                //ORRRR!!!!!!!!!  linq/Query syntax  buuuut you cant do sum, you must then do method syntax
                var lowInts2 = (from i in ints
                                where i < ints.Average()
                                orderby i descending
                                select i).Sum();
                Console.WriteLine($"Sum is {lowInts2}");
            //    foreach (var i in lowInts2)
            //    {                                 this was for query syntax but once you change to method
            //        Console.WriteLine($"{i} ");
            //    }
            
            }
        }
    }
}


//using System;
//using System.Linq;
//using System.Collections.Generic;

//namespace linq_tutorial
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            var customers = new List<Customer>() {
//                new Customer { Id = 1, Name = "Amazon" },
//                new Customer { Id = 2, Name = "Target" },
//                new Customer { Id = 3, Name = "Microsoft" }
//            };
//            var orders = new List<Order>() {
//                new Order { Id = 1, Description = "1st Order", Sales = 1000, CustomerId = 1 },
//                new Order { Id = 2, Description = "2nd Order", Sales = 2000, CustomerId = 3 },
//                new Order { Id = 3, Description = "3rd Order", Sales = 3000, CustomerId = 2 }
//            };

//            var CustOrders = from o in orders
//                             join c in customers
//                                on o.CustomerId equals c.Id
//                             select new { o, c };

//            foreach (var co in CustOrders)
//            {
//                Console.WriteLine($"{co.c.Name} | {co.o.Description} | {co.o.Sales}");
//            }
//        }
//        static void X()
//        {
//            int[] ints = new int[]
//            {
//                620, 849, 649, 989, 993, 524, 216, 173, 136, 482,
//                842, 308, 251, 572, 150, 797, 611, 489, 934, 310,
//                985, 764, 484, 816, 753, 925, 289, 231, 486, 761,
//                621, 981, 103, 482, 917, 124, 276, 839, 476 ,789,
//                582, 631, 841, 398, 521, 796, 199, 941, 782, 953,
//                412, 362, 424, 336, 812, 344, 579, 570, 212, 483,
//                250, 829, 835, 429, 833, 992, 657, 461, 782, 498,
//                829, 648, 189, 579, 645, 584, 989, 254, 859, 321,
//                991, 421, 151, 350, 687, 491, 568, 548, 403, 836,
//                303, 104, 538, 426, 150, 843, 943, 864, 694, 639
//            };
//            Console.WriteLine($"Average is {ints.Average()}");

//            var sum = ints.Sum() - ints.Min() - ints.Max();
//            var avg = sum / (ints.Count() - 2.0);
//            //Console.WriteLine($"Average without max and min is {avg}");
//            #region List of ints LT Avg ordered descending
//            //var lowInts = ints.Where(i => i < ints.Average()).OrderByDescending(i => i);
//            //foreach(var i in lowInts)
//            //{
//            //	Console.Write($"{i} ");
//            //}
//            #endregion
//            var lowInts2 = (from i in ints
//                            where i < ints.Average()
//                            orderby i descending
//                            select i).Sum();
//            Console.WriteLine($"Sum is {lowInts2}");
//        }
//    }
//}

