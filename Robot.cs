namespace Yarisma
{
    abstract class Robot : IYarismaci
    {
        public Robot(uint number, string name, Pist track)
        {
            Name = name;
            Number = number;
            Position = 0;
            Bozuldu = false;
            this.track = track;
        }

        private string name = default!;
        private uint number;

        public Pist track;


        //this property initialized to false at start and can be used in Pist.UpdatePsoition()
        // it is not used in this case due to no special cases including a disfunctional robot
        public bool Bozuldu {get; set;}

        public string Name 
        { 
            get
            {
                return name;
            }
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