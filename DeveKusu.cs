namespace Yarisma
{
    class DeveKusu : Animal
    {
        public DeveKusu(uint number, string name, Pist track) 
                        :base(number, name, track)
       {
           
       }

       public override string ToString() => $"Contestant {this.Number} : {this.Name} (Deve Kusu)";
    }
}