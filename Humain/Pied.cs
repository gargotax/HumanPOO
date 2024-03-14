namespace Humain
{
    public class Pied:IPartieCorps
    {
        public Orteil Pouce { get; }
        public Orteil Index { get; }
        public Orteil Majeur { get; }
        public Orteil Annulaire { get; }
        public Orteil Auriculaire { get; }

        public string Action()
        {
           return "le pied bouge";
        }
    }
}
