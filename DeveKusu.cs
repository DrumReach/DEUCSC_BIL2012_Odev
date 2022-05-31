namespace Yarisma
{
    class DeveKusu : Animal
    {
        public bool Paralized {get; set;}

        public DeveKusu(uint number, string name, Pist track) 
                        :base(number, name, track)
       {
           Paralized = false;
       }

       public override void Move()
       {    
            //check if paralized
            if(!Paralized)
            {
                Random rand = new Random();
                double step = rand.NextDouble();

                // %20 hizli kosma
                if (step <= 0.2)
                    Position += 6;
                
                // %30 kayma
                else if (step <= 0.5)
                    Position -= 4;
                
                // %50 kosma
                else
                    Position += 3;
            }    
        }

       public override string ToString() => $"Contestant {this.Number} : {this.Name} (Deve Kusu)";
    }
}