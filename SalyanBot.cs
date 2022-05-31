namespace Yarisma
{
    class SalyanBot : Robot
    {

       public SalyanBot(uint number, string name, Pist track) 
                        :base(number, name, track)
       {
           
       }

       public override void Move()
       {
           // %100 surunme
            Position ++;
       }
        
       public override string ToString() => $"Contestant {this.Number} : {this.Name} (SalyanBot)";
    }

    
}