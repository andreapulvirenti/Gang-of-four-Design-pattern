using System;
namespace Build
{

    public interface FullIBuilder : IBuilder , IBuilderDelta
    {
        
    }
    public class ConcreteBuilder : FullIBuilder
    {
        private Product product = new Product();
        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this.product = new Product();
        }
        public void BuildPartA()
        {
            this.product.Add("PRODOTTO A");
            Console.WriteLine("BUILDED PRODUCT A");
        }

        public void BuildPartB()
        {
            this.product.Add("PRODOTTO B");
            Console.WriteLine("BUILDED PRODUCT B");

        }

        public void BuildPartC()
        {
            this.product.Add("PRODOTTO C");
            Console.WriteLine("BUILDED PRODUCT C");
        }

        public void BuildPartDelta(){
            this.product.Add("PRODOTTO DELTA");
            Console.WriteLine("PRODOTTO DELTA");
        }

        public Product GetProduct(){
           return this.product;
        }
    }
}