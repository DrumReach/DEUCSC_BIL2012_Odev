namespace Yarisma
{

    interface IYarismaci
    {
        string Name { get; set;}
        uint Position { get; set;}
        
        uint Number { get; set;}

        public void Move();
    }

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

                            // 0 is number 1 is name 2 is type
                            if(parts[2] == "SALYANBOT")
                            {
                                yarismaci = new SalyanBot(Convert.ToUInt32(parts[0]), parts[1]);
                                yarismacilar.Add(yarismaci);
                            }

                            else if (parts[2] == "MEKANIKFIL")
                            {
                                yarismaci = new MekanikFil(Convert.ToUInt32(parts[0]), parts[1]);
                                yarismacilar.Add(yarismaci);
                            }

                            else if (parts[2] == "CAKAL")
                            {
                                yarismaci = new Cakal(Convert.ToUInt32(parts[0]), parts[1]);
                                yarismacilar.Add(yarismaci);
                            }

                            else if (parts[2] == "DEVEKUSU")
                            {
                                yarismaci = new DeveKusu(Convert.ToUInt32(parts[0]), parts[1]);
                                yarismacilar.Add(yarismaci);
                            }

                            else
                            {
                                throw new FormatException("Unknown contestant type, please check file");
                            }

                        }//for
                    }//try

                    catch(FormatException ex)
                    {
                        System.Console.WriteLine("Unknown contestant type\n" + ex.Message);
                    }

                    catch(IndexOutOfRangeException ex)
                    {
                        System.Console.WriteLine(ex.Message + "\nFile is not formatted correctly!");
                    }

            }
            catch (IOException ex)
            {
                Console.WriteLine(ex.Message);
            }

            

        }//Constructor

        public void KonumlariYazdir() 
        {
            foreach(IYarismaci cont in yarismacilar)
            {
                Console.WriteLine($"{cont.Position} :: {cont.Number}, {cont.Name}");
            }
        }

        public void Baslat()
        {
            //test
            for(int i =0; i <= Track.PistLen - 1; i++)
            {
                foreach(IYarismaci cont in yarismacilar)
                {
                    cont.Position++;
                    // cont.Move();
                }
            }
        }
        
    }
}