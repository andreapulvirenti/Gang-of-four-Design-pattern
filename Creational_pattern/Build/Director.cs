namespace Build
{
    public class Director
    {
        private FullIBuilder _builder;

        public FullIBuilder Builder{
           get => this._builder;
        }

        public Director(FullIBuilder builder){
            this._builder = builder;
        }

        public void BuildMinimalProduct(){
            this._builder.BuildPartA();
        }

        public void BuildFullProduct(){
            this._builder.BuildPartA();
            this._builder.BuildPartB();
            this._builder.BuildPartC();
        }

        public void BuildPartDelta(){
            this._builder.BuildPartA();
            this._builder.BuildPartDelta();

        }
        
    }
}