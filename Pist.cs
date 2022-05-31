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
                
                
            }
            return true;
        }
    }
}