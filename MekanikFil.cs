namespace Yarisma
{
    class MekanikFil : Robot
    {
        public MekanikFil(uint number, string name, Pist track) 
                        :base(number, name ,track)
       {
           // all the operations already done in base class constructor
       }

        public override void Move()
        {
            if(!Bozuldu)
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
        }

        public override string ToString() => $"{this.Number} : {this.Name} (Mekanik Fil)";
    }
}