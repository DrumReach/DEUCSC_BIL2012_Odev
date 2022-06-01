namespace Yarisma
{
    abstract class Animal : IYarismaci
    {
        public Animal(uint number, string name, Pist track)
        {   
        
            Name = name;
            Number = number;
            Position = 0;
            this.track = track;

        }
        
        private string name = default!;
        private uint number;

        public Pist track;
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

        public int Position { get; set;}
        

        public uint Number 
        { 
            get {return number;}
            
            set { number = value; }
        }

        public abstract void Move();

    }
}