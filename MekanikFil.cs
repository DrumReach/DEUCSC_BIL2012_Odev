namespace Yarisma
{
    class MekanikFil : Robot
    {
        public MekanikFil(uint number, string name) 
                        :base(number, name)
       {
           
       } 

        public override string ToString() => $"Contestant : {this.Number} - {this.Name} (Mekanik Fil)";
    }
}