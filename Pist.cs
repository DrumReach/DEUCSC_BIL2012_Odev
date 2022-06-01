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
                
                
                //OPT 1
                // if (c.GetType() == typeof(Cakal))
                // {
                //     foreach(IYarismaci x in yarismacilar)
                //     {
                //         if(x.GetType() == typeof(DeveKusu) &&
                //            x.Position != 0 && 
                //            x.Position == c.Position)
                //         {
                //             //trick to access property DeveKusu.Paralized
                //             DeveKusu dk = (DeveKusu)x;
                //             dk.Paralized = true;
                //             System.Console.WriteLine($"!!{dk} IS PARALIZED #");
                //         }
                //     }
                // }
                // OPT 2
                if (c.GetType() == typeof(Cakal))
                {
                    List<IYarismaci> ds = yarismacilar.FindAll(x => x.GetType() == typeof(DeveKusu));
                    foreach (IYarismaci d in ds)
                    {
                        if(c.Position == d.Position && d.Position != 0)
                        {
                            DeveKusu dk = (DeveKusu)d;
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