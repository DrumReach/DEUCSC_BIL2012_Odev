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

            if (step <= 0.1)
            {// %10 kosma
                Position += 3;
            }
            else if (step <= 0.5)
            {// %40 yurume
                Position += 2;
            }
            else
            {// %50 bekleme
                ;// do nothing
            }
        }

        public override string ToString() => $"Contestant {this.Number} : {this.Name} (Mekanik Fil)";
    }
}