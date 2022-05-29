namespace Yarisma
{
    abstract class Animal : IYarismaci
    {
        private string name;
        private uint number;
        public string Name 
        { 
            get
            { return name; }
            set
            {
                if(value == null)
                    throw new ArgumentException("Name connot be empty");
                else
                    name = value;
            }
        }

        public uint Position { get; set;}
        

        public uint Number 
        { 
            get {return number;}
            
            set { number = value; }
        }

        public void Move()
        {
            
        }

        public Animal(uint number, string name)
        {   
        
            Name = name;
            Number = number;
            Position = 0;

        }
    }
}