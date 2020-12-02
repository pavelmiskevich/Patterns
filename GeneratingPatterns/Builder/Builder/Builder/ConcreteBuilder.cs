namespace Builder.Builder
{
    class ConcreteBuilder : IBuilder
    {
        private Product _product = new Product();

        public ConcreteBuilder()
        {
            this.Reset();
        }

        public void Reset()
        {
            this._product = new Product();
        }

        public void JustDoItOne()
        {
            this._product.Add("PartA1");
        }

        public void JustDoItTwo()
        {
            this._product.Add("PartB1");
        }

        public void JustDoItThree()
        {
            this._product.Add("PartC1");
        }

        public Product GetProduct()
        {
            Product result = this._product;

            this.Reset();

            return result;
        }
    }
}
