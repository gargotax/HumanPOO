namespace Humain
{
    public class Human: IPartieCorps
    {
        public Main MainGauche { get; set; }
        public Main MainDroite { get; set; }
        public Jambes Jambes { get; set; }
        public int Age { get; }
        public string Nom {  get; }


        public Human()
        {

        }

        public string Action()
        {
           return $"{Jambes.Action()} {MainDroite.Action()}" ;
            
        }

        

    }
}