namespace Yarisma
{
    class Yarisma
    {

        public List<IYarismaci> yarismacilar;
        
        public Pist Track;

        public Yarisma(string filePath, uint length)
        {
            IYarismaci yarismaci;
            yarismacilar = new List<IYarismaci>();
            
            // Create Track
            this.Track = new Pist(length);


            //Read from file
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                
                //check if file is empty
                if(lines.Length == 0)
                    throw new MissingFieldException("FILE IS EMPTY!");
                
                string[] parts;


                
                //Split and assign
                try
                {
                    foreach(string line in lines)
                    {   
                        parts = line.Split(' ');

                        // parts 0 is number 1 is name 2 is type
                        if(parts[2].ToUpper() == "SALYANBOT")
                        {
                            yarismaci = new SalyanBot(Convert.ToUInt32(parts[0]), parts[1], this.Track);
                            yarismacilar.Add(yarismaci);
                        }

                        else if (parts[2].ToUpper() == "MEKANIKFIL")
                        {
                            yarismaci = new MekanikFil(Convert.ToUInt32(parts[0]), parts[1], this.Track);
                            yarismacilar.Add(yarismaci);
                        }

                        else if (parts[2].ToUpper() == "CAKAL")
                        {
                            yarismaci = new Cakal(Convert.ToUInt32(parts[0]), parts[1], this.Track);
                            yarismacilar.Add(yarismaci);
                        }

                        else if (parts[2].ToUpper() == "DEVEKUSU")
                        {
                            yarismaci = new DeveKusu(Convert.ToUInt32(parts[0]), parts[1], this.Track);
                            yarismacilar.Add(yarismaci);
                        }

                        else
                        {
                            throw new FormatException();
                        }

                    }
                }
                catch(FormatException ex)
                {
                    System.Console.WriteLine("Unknown contestant type\n" + ex.Message);
                }

                catch(IndexOutOfRangeException)
                {
                    System.Console.WriteLine("File is not formatted correctly!");
                }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void KonumlariYazdir() 
        {
            //Sort List by position
            yarismacilar = yarismacilar.OrderBy(x => x.Position).ToList();

            foreach(IYarismaci cont in yarismacilar)
            {
                Console.WriteLine($"{cont.Position} :: {cont.Number}, {cont.Name}");
            }
            
        }

        public void Baslat()
        {
            //Reset to initial state (required for multiple races without termination)
            foreach(IYarismaci c in yarismacilar)
            {
                c.Position = 0;
                //heal paralized
                if (c.GetType() == typeof(DeveKusu))
                {
                    DeveKusu dk = (DeveKusu)c;
                    dk.Paralized = false;
                }
            }

            // UpdatePosition() returns false if a contestant wins
            // used for looping each step
            bool flag = true;
            
            while(flag)
                flag = Track.UpdatePosition(yarismacilar);
                
        }
    }
}