namespace Yarisma
{
    class MekanikFil : Robot
    {
        public MekanikFil(uint number, string name, Pist track) 
                        :base(number, name ,track)
       {
           
       } 

        public override string ToString() => $"Contestant {this.Number} : {this.Name} (Mekanik Fil)";
    }
}