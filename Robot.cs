namespace Yarisma
{
    abstract class Robot : IYarismaci
    {

        private string name;
        private uint number;


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

        public uint Position { get; set;}
        

        public uint Number 
        { 
            get {return number;}
            
            set { number = value; }
        }

        public void Move()
        {

        }

        public Robot(uint number, string name)
        {
            Name = name;
            Number = number;
            Position = 0;
            Bozuldu = false;
        }

    }
}