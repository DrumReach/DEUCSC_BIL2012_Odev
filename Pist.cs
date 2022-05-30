namespace Yarisma
{
    class Pist
    {
        private uint pistLen;
        public uint PistLen
        {
            get {return pistLen;}
            set 
            {
                pistLen = value;
            }
        }
        public Pist(uint length)
        {
            PistLen = length;
        }
    }
}