using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Threading;
using System.Xml.Linq;
using static Assigment2.ListGenerator;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Assigment2
{
    internal class Program
    {

        static void Main(string[] args)
        {


            #region Element Operators


            #region    // 1.Get first Product out of Stock 
            //  var result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0);

            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.

            //  var result = ProductsList.FirstOrDefault(p => p.UnitPrice > 1000);

            #endregion

            #region . Retrieve the second number greater than 5
            /*      int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                  var result = Arr.Where(p=>p>5).ElementAt(1);
      */
            #endregion



            #endregion

            #region  Aggregate Operators
            #region 1. Uses Count to get the number of odd numbers in the array
            /*     int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                 var result = Arr.Count(p => p % 2 == 1); */


            #endregion


            #region   2.Return a list of customers and how many orders each has.
            /*    var result = CustomersList.Select(x => new
                {
                    x.CustomerName,
                    ordercount = x.Orders.Count()

                });*/
            #endregion

            #region  3.Return a list of categories and how many products each has
            /*       var result = ProductsList.Select(x => new
                   {
                      category =  x.Category,
                      number_of_product = ProductsList.Count(c=>c.Category == x.Category)
                   });*/
            #endregion

            #region 4. Get the total of the numbers in an array.
            /*       int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                   var result = Arr.Sum(); 
       */

            #endregion
            #region . Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            /*        var w = File.ReadAllLines("dictionary_english.txt");
                    var result = w.Sum(s => s.Length);*/

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            /* var w = File.ReadAllLines("dictionary_english.txt");
             var result = w.Min(x => x.Length); */


            #endregion


            #region 7.Get the length of the longest word in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            /*    var w = File.ReadAllLines("dictionary_english.txt");
                var result = w.Max(x => x.Length);*/


            #endregion

            #region    8.Get the average length of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First).

            /*     var w = File.ReadAllLines("dictionary_english.txt");
                 var result = w.Average(x => x.Length);*/

            #endregion


            #region   9.Get the total units in stock for each product category.

            /*     var result = ProductsList.GroupBy(p => p.Category).
                     Select(p => new
                     {
                         Category = p.Key,
                         Number_unite = p.Sum(p => p.UnitsInStock )

                     }); */
            #endregion
            #region   10.Get the cheapest price among each category's products
            /*       var result = ProductsList.GroupBy(p => p.Category).
                                   Select(p => new
                                   {
                                       Category = p.Key,
                                       cheapest = p.Min(p => p.UnitPrice)

                                   });  */

            #endregion

            #region  11.Get the products with the cheapest price in each category(Use Let)
            /*       var result = from p in ProductsList
                                group p by p.Category
                                into pc
                                let price = pc.Where(c => c.UnitPrice == pc.Min(y => y.UnitPrice))
                                select price; */


            #endregion
            #region   12.Get the most expensive price among each category's products.
            /*       var result = ProductsList.GroupBy(p => p.Category).
                         Select(p => new
                         {
                             Category = p.Key,
                             cheapest = p.Max(p => p.UnitPrice)

                         });*/


            #endregion


            #region 13.Get the products with the most expensive price in each category.       
            /*     var result = from p in ProductsList
                  group p by p.Category
            into pc
                  let price = pc.Where(c => c.UnitPrice == pc.Max(y => y.UnitPrice))
                  select price;

     foreach (var category in result)
     {
        foreach (var item in category)
         {
             Console.WriteLine(item);
         }

     }*/
            #endregion

            #region    14.Get the average price of each category's products.
            /*            var result = from p in ProductsList
                                     group p by p.Category
                   into pc
                                     let price = pc.Where(c => c.UnitPrice == pc.Average(y => y.UnitPrice))
                                     select price;

                        foreach (var category in result)
                        {
                            foreach (var item in category)
                            {
                                Console.WriteLine(item);
                            }

                        }*/
            #endregion





            #endregion

            #region       LINQ - Ordering Operators

            #region    1.Sort a list of products by name
            //    var result = ProductsList.OrderBy(p => p.ProductName);


            #endregion


            #region   2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
            /*            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


                        var reasult = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase).ToArray();


                        foreach (var word in reasult)
                        {
                            Console.WriteLine(word);
                        }

            */
            #endregion

            #region     3.Sort a list of products by units in stock from highest to lowest.
            //  var result = ProductsList.OrderByDescending(p => p.UnitsInStock); 

            #endregion
            #region   4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            /* string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
             var result = Arr.OrderBy(name => name.Length) 
                           .ThenBy(name => name) 
                           .ToArray();*/

            #endregion

            #region    5.Sort first by-word length and then by a case -insensitive sort of the words in an array.
            /*    string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
                var result = Arr.OrderBy(word => word.Length) 
                                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase) 
                                .ToArray();*/
            #endregion


            #region   6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            // var result = ProductsList.OrderByDescending(p=>p.Category).ThenByDescending(p=>p.UnitPrice).ToList();

            #endregion



            #region     7.Sort first by-word length and then by a case -insensitive descending sort of the words in an array.
            /*    string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
               var result = Arr.OrderByDescending(word => word.Length)
                              .ThenByDescending(word => word, StringComparer.OrdinalIgnoreCase)
                              .ToArray(); */

            #endregion

            #region   8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            /*
                        string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

                        var result = Arr.Where(word => word[1] == 'i')
                                              .Reverse() 
                                              .ToList();*/


            #endregion




            #endregion

            #region   LINQ – Transformation Operators


            #region    1.Return a sequence of just the names of a list of products.

            //   var result = ProductsList.Select(x=>x.ProductName).ToList();

            #endregion

            #region  2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            /*            string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry"};
                        var result = words.Select(x => new
                        {
                            uppercase = x.ToUpper(),
                            lowercase = x.ToLower()
                        });*/


            #endregion
            #region   3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            /*
                        var result = ProductsList.Select(x => new
                        {
                            name = x.ProductName
                            ,
                            price = x.UnitPrice
                        });

            */
            #endregion
            #region 4.Determine if the value of int in an array match their position in the array.
            /*
                        int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
                        var result = Arr.Select((value, index) => new { value, index })
                                                 .Where(x => x.value != x.index)
                                                 .ToList();*/

            #endregion


            #region  5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            /*  int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
              int[] numbersB = { 1, 3, 5, 7, 8 };
              var result = numbersA.Zip(numbersB);  */
            #endregion









            #endregion


            #region LINQ - Set Operatorsion
            #region  1.Find the unique Category names from Product List
            //  var result = ProductsList.Select(p => p.Category).Distinct();
            #endregion

            #region   2.Produce a Sequence containing the unique first letter from both product and customer names.
            //  var result = ProductsList.Select(x => x.ProductName[0]).Union(CustomersList.Select(c => c.CustomerName[0])).Distinct();

            #endregion

            #region    3.Create one sequence that contains the common first letter from both product and customer names.
            //var result = ProductsList.Select(x => x.ProductName[0]).Intersect(CustomersList.Select(c => c.CustomerName[0])).Distinct();


            #endregion

            #region 4.Create one sequence that contains the first letters of product names that are not also first letters of customer names.

            /// var result = ProductsList.Select(x => x.ProductName[0]).Except(CustomersList.Select(c => c.CustomerName[0])).Distinct();

            #endregion

            #region   5.Create one sequence that contains the last Three Characters in each name of all customers and products, including any duplicates

            //   var result = ProductsList.Select(x => x.ProductName[^3..]).Concat(CustomersList.Select(c => c.CustomerName[^3..])).Distinct();

            #endregion



            #endregion

            #region  LINQ - Partitioning Operators

            #region  1.Get the first 3 orders from customers in Washington
            //           var result = CustomersList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Take(3);
            #endregion

            #region 2.Get all but the first 2 orders from customers in Washington.

            //           var result = CustomersList.Where(c => c.Region == "WA").SelectMany(c => c.Orders).Skip(2);

            #endregion
            #region  3.Return elements starting from the beginning of the array until a number is hit that is less than its position in the array.
            /*   int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
               var result = numbers.TakeWhile((num, i) => num > i);*/


            #endregion

            #region   4.Get the elements of the array starting from the first element divisible by 3.
            /*int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var result = numbers.SkipWhile(num=>num %3 != 0  );*/


            #endregion


            #region   5.Get the elements of the array starting from the first element less than its position.
            /*  int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
             var result = numbers.TakeWhile((num, i) => num >= i);*/
            #endregion



            #endregion
            #region LINQ - Quantifiers

            #region   1.Determine if any of the words in dictionary_english.txt(Read dictionary_english.txt into Array of String First) contain the substring 'ei'.

            /*       var word = File.ReadLines("dictionary_english.txt");
                   var result = word.Any(c=>c.Contains("ei"));
       */


            #endregion

            #region  2.Return a grouped a list of products only for categories that have at least one product that is out of stock.

            //   var result = ProductsList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0)).Select(p => p);


            #endregion

            #region  3.Return a grouped a list of products only for categories that have all of their products in stock.


            //   var result = ProductsList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock > 0)).Select(p => p);



            #endregion


            #endregion



            #region  LINQ – Grouping Operators


            #region  Use group by to partition a list of numbers by their remainder when divided by 5

            /*List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
                        var result = numbers.GroupBy(x => x % 5 ); 
                        foreach ( var x in result)
                        {   Console.WriteLine($"Number with remaider of {x.Key} when divided by 5 :  ");
                            foreach ( var y in x) 
                                Console.WriteLine(y);

                        }*/


            #endregion


            #region   Uses group by to partition a list of words by their first letter. Use dictionary_english.txt for Input

            /*var word = File.ReadLines("dictionary_english.txt");
            var result = word.GroupBy(word => word[0]);
*/
            #endregion


            #region    Consider this Array as an Input , Use Group By with a custom comparer that matches words that are consists of the same Characters Together
            /*
                        string[] Arr = { "from", "salt", "earn", "last", "near", "form" };


                        var anagramComparer = new AnagramEqualityComparer();


                        var groupedWords = Arr.GroupBy(word => word, anagramComparer)
                                           .ToList();


                        foreach (var group in groupedWords)
                        {

                            foreach (var word in group)
                            {
                                Console.WriteLine(word);
                            }
                            Console.WriteLine("..............");
                        }
                    }
                }


                class AnagramEqualityComparer : IEqualityComparer<string>
                {
                    public bool Equals(string x, string y)
                    {

                        return string.Concat(x.OrderBy(c => c)) == string.Concat(y.OrderBy(c => c));
                    }

                    public int GetHashCode(string obj)
                    {

                        return string.Concat(obj.OrderBy(c => c)).GetHashCode();
                    }
                }*/
            #endregion
            #endregion



            //Console.WriteLine(result);
            /*       foreach (var x in result)
                   {

                       foreach (var y in x)
                           Console.WriteLine(y);

                   }*/





        }
    }
}
    

