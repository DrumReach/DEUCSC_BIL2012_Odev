namespace Yarisma
{
    abstract class Animal : IYarismaci
    {
        public string Name { get; set;}

        public uint Position { get; set;}
        

        public uint Number { get; set;}

        public void Move()
        {
            
        }

        public Animal(uint number, string name)
        {
            Name = name;
            Number = number;
            Position = 0;
        }
    }
}