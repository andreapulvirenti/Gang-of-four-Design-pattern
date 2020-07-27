namespace Prototype
{
    public class Person
    {
        public IdInfo IdInfo {get; set; }
        public string Name;
        public int Age;
        public string SurName;

        public Person ShallowClone(){
            return (Person)this.MemberwiseClone();
        }

        public Person DeppCopy(){
            Person p = ShallowClone();
            p.IdInfo = new IdInfo(100);
            p.Name = string.Copy(this.Name);
            return p;
        }

        public Person(){

        }
    }

    public class IdInfo{

        private int _id;

        public IdInfo(int id){
            this._id = id;
        }

        public int Id  {
            get => _id;
            set => _id = value;
        }
    }
}