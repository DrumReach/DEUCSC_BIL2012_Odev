namespace Yarisma
{
    abstract class Robot : IYarismaci
    {
        public bool Bozuldu;

        public string Name { get; set;}

        public uint Position { get; set;}
        

        public uint Number { get; set;}

        public void Move()
        {

        }

        public Robot(uint number, string name)
        {
            Name = name;
            Number = number;
            Position = 0;
            Bozuldu = false;
        }

    }
}