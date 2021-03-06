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
                {
                    // use this trick to block finish line 
                    // instead of checking each step
                    // ex. a step is +4 instead of 4 * (+1)
                    c.Position = (int)TrackLen;
                    return false;
                }
                
                

                /* SPECIAL CASES */
                
                //if one contestant has a special trait 
                //check for it  on it's every turn (linear search)

                //#1 Cakal - DeveKusu (%50 chance)
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

                            //Console.WriteLine($"!!{dk} IS PARALIZED by {c}");
                        }
                    }
                }

                //#2 MekanikFil - DeveKusu
                else if (guess <= 0.2 && c.GetType() == typeof(MekanikFil))
                {
                    foreach(IYarismaci x in yarismacilar)
                    {
                        if(x.GetType() == typeof(DeveKusu) && 
                           x.Position != 0 && x.Position == c.Position)
                        {
                            //trick to access property DeveKusu.Paralized
                            DeveKusu dk = (DeveKusu)x;
                            dk.Paralized = true;

                            //Console.WriteLine($"!!{dk} IS PARALIZED by {c}");
                        }
                    }
                }

                //#3 SalyanBot (%25 chance between .2 and .45 so it wouldn't conflict with other special cases)
                if(guess > 0.2 && guess < 0.45 && c.GetType() == typeof(SalyanBot))
                {
                    foreach(IYarismaci x in yarismacilar)
                    {
                        if(x.GetType() != typeof(SalyanBot) && x.Position != 0 && x.Position == c.Position)
                        {
                            x.Position--;
                            //Useful to see behind the scenes
                            //System.Console.WriteLine($"{x.Name} got a SETBACK at {x.Position}");
                        }
                    }
                }

            }
            return true;
        }
    }
}