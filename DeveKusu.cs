namespace Yarisma
{
    class DeveKusu : Animal
    {
        public DeveKusu(uint number, string name, Pist track) 
                        :base(number, name, track)
       {
           
       }

       public override void Move()
       {

            Random rand = new Random();
            double step = rand.NextDouble();

            if (step <= 0.2)
            {// %20 hizli kosma
                Position += 6;
            }
            else if (step <= 0.5)
            {// %30 kayma
                Position -= 4;
            }
            else
            {// %50 kosma
                Position += 3;
            }
       }

       public override string ToString() => $"Contestant {this.Number} : {this.Name} (Deve Kusu)";
    }
}