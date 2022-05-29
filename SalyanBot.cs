namespace Yarisma
{
    class SalyanBot : Robot
    {

       public SalyanBot(uint number, string name) 
                        :base(number, name)
       {
           
       } 
        
       public override string ToString() => $"Contestant {this.Number} : {this.Name} (SalyanBot)";
    }

    
}