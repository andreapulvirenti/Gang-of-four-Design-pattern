namespace Composite
{
    public abstract class AComponent
    {
  
        public AComponent(){
        
        }

        public abstract bool IsComposite();

        public abstract void Add(AComponent component);
        public abstract bool Remove(AComponent component);
        public abstract string ShowComponents();

    }
}