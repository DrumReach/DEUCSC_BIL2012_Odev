namespace Yarisma
{

    interface IYarismaci
    {
        string Name { get; set;}
        uint Konum { get; set;}
        
        uint Number { get; set;}

        public void Move();
    }

    class Yarisma
    {

        List<IYarismaci> yarismacilar;
        
        private uint trackLength;
        public uint TrackLength
        {
            get { return this.trackLength; }

            private set
            {
                if (value <= 0)
                    throw new ArgumentOutOfRangeException("Pist Uzunlugu 0 dan buyuk olmali");
                
                this.trackLength = value;
            }
        }
        public Yarisma(string filePath, uint length)
        {
            TrackLength = length;

            //Read from file
            string[] lines = File.ReadAllLines(filePath);
            string[] parts;
            IYarismaci yarismaci;
            foreach(string line in lines)
            {
                //Split and assign
                parts = line.Split(' ');
                // 0 is number 1 is name 2 is type

                if(parts[2] == "SALYANBOT")
                {
                    yarismaci = new SalyanBot(Convert.ToUInt32(parts[0]), parts[1]);
                    yarismacilar.Add(yarismaci);
                    
                    System.Console.WriteLine(yarismaci);
                }

                else if (parts[2] == "MEKANIKFIL")
                {
                    yarismaci = new MekanikFil(Convert.ToUInt32(parts[0]), parts[1]);
                    yarismacilar.Add(yarismaci);
                }

                else if (parts[2] == "CAKAL")
                {

                }

                else if (parts[2] == "DEVEKUSU")
                {

                }

                else
                {
                    throw new FormatException("Unknown contestant type");
                }
            }
        }
    }
}