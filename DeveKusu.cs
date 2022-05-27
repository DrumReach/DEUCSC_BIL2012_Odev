namespace Yarisma
{
    class DeveKusu : Animal
    {
        public DeveKusu(uint number, string name) 
                        :base(number, name)
       {
           
       }

       public override string ToString() => $"Contestant {this.Number} : {this.Name} (Deve Kusu)";
    }
}