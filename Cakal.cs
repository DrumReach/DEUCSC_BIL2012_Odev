namespace Yarisma
{
    class Cakal : Animal
    {
        public Cakal(uint number, string name, Pist track) 
                        :base(number, name, track)
        {
           
        }

        public override void Move()
        {  
            Random rand = new Random();
            double step = rand.NextDouble();

            if (step <= 0.2)
            {// %20 kayma
                Position -= 4;
            }
            else if (step <= 0.5)
            {// %30 kosma
                Position += 3;
            }
            else
            {// %50 yurume
                Position += 2;
            }

            // Check Position
            if (Position < 0)
                    Position = 0;
            
            if (Position >= track.PistLen)
                return;
        }
       public override string ToString() => $"Contestant {this.Number} : {this.Name} (Cakal)";
    }

     
}