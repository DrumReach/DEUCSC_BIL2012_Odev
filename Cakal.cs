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
            // guess a random double between 0 and 1
            // to calculate probability of a step
            Random rand = new Random();
            double step = rand.NextDouble();
            
            // %20 kayma
            if (step <= 0.2)
                Position -= 4;
            
            // %30 kosma
            else if (step <= 0.5)
                Position += 3;
            
            // %50 yurume
            else
                Position += 2;

        }
        // can be used for printing list of contestants
        public override string ToString() => $"Contestant {this.Number} : {this.Name} ({this.GetType()})";
    }

     
}