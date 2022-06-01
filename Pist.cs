namespace Yarisma
{
    class Pist
    {
        private uint trackLen;
        public uint TrackLen
        {
            get {return trackLen;}
            set 
            {
                if(value > 0)
                    trackLen = value;
                else
                    throw new ArgumentOutOfRangeException();
            }
        }
        public Pist(uint length)
        {
            TrackLen = length;
        }

        public bool UpdatePosition(List<IYarismaci> yarismacilar)
        {
            // Take a random guess at every turn
            //to decide the chances of special cases
            Random rand = new Random();
            double guess = rand.NextDouble();
            
            foreach(IYarismaci c in yarismacilar)
            {
                c.Move();

                //CHECK POSITION
                
                //check start line
                if(c.Position < 0)
                    c.Position = 0;

                //check finish line
                if(c.Position >= TrackLen)
                    return false;
                
                
                // SPECIAL CASES

                //#1 Opt.1
                // Cakal - DeveKusu (%50 chance)
                if (guess > 0.5 && c.GetType() == typeof(Cakal))
                {
                    foreach(IYarismaci x in yarismacilar)
                    {
                        if(x.GetType() == typeof(DeveKusu) && 
                           x.Position != 0 && x.Position == c.Position)
                        {
                            //trick to access property DeveKusu.Paralized
                            DeveKusu dk = (DeveKusu)x;
                            dk.Paralized = true;
                            System.Console.WriteLine($"!!{dk} IS PARALIZED #");
                        }
                    }
                }
            }
            return true;
        }
    }
}