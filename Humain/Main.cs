namespace Humain
{
    public class Main:IPartieCorps
    {
        public IPartieCorps MainGauche {  get; set; } 
        public IPartieCorps MainDroite { get; set; } 


        public Main()
        {
          
            
        }

        public string Action()
        {
           return $"{MainGauche.Action()} {MainDroite.Action()}" ;
            
           
        }
    }
}
