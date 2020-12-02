namespace Builder.Builder
{
    public class Director
    {
        private IBuilder _builder;

        public IBuilder Builder
        {
            set { _builder = value; }
        }
        public void buildMinimalViableProduct()
        {
            this._builder.JustDoItOne();
        }

        public void buildFullFeaturedProduct()
        {
            this._builder.JustDoItOne();
            this._builder.JustDoItTwo();
            this._builder.JustDoItThree();
        }
    }
}
