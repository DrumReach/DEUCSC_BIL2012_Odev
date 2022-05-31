namespace Yarisma
{
    class MekanikFil : Robot
    {
        public MekanikFil(uint number, string name, Pist track) 
                        :base(number, name ,track)
       {
           
       }

        public override void Move()
        {
            Random rand = new Random();
            double step = rand.NextDouble();

            // %10 kosma
            if (step <= 0.1)
                Position += 3;
            
            // %40 yurume
            else if (step <= 0.5)
                Position += 2;
            
            // %50 bekleme
            // do nothing
        }

        public override string ToString() => $"Contestant {this.Number} : {this.Name} (Mekanik Fil)";
    }
}