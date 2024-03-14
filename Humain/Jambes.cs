namespace Humain
{
    public class Jambes:IPartieCorps
    {
        public IPartieCorps PiedDroit { get; set; }
        public IPartieCorps PiedGauche { get; set; }

        public string Action()
        {
          return $" {PiedDroit.Action()} {PiedGauche.Action()}";

        }
    }
}