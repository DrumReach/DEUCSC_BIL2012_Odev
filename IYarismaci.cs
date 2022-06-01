namespace Yarisma
{
    interface IYarismaci
    {
        string Name { get; set;}
        int Position { get; set;}
        
        uint Number { get; set;}

        public void Move();
    }
}