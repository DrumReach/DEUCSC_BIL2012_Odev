namespace Yarisma
{
    class Cakal : Animal
    {
        public Cakal(uint number, string name) 
                        :base(number, name)
        {
           
        }

        public void Move()
        {
            
        }
       public override string ToString() => $"Contestant {this.Number} : {this.Name} (Cakal)";
    }

     
}