using System;
using System.Collections;
using System.Collections.Generic;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVisitable> products = new List<IVisitable>();
            products.Add(new ProductSoldInPieces("PR1", "Penne Stilo BIC", 2.80, 5));
            products.Add(new ProductSoldInPieces("PR2", "Zaino Invicta", 34.99, 1));
            products.Add(new ProductSoldInWeight("PR3", "Formaggio Parmigiano", 9.90, 2));
            products.Add(new ProductSoldInWeight("PR4", "Arachidi", 6.50, 2));
            products.Add(new ProductSoldInWeight("PR5", "Peperoni", 1.50, 6));

            var total = calculateShoppingCost(products);
            Console.WriteLine($"the total cost is: {total}");
        }
        private static double calculateShoppingCost(List<IVisitable> products)
        {
            double total = 0;
            IVisitor visitor = new ShoppingVisitor();
            foreach (var item in products)
            {
                var partial = item.Accept(visitor);
                total += partial;
            }
            return Math.Round(total,2);
        }
    }
}
