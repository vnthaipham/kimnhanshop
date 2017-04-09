namespace KimNhanShop.Model.Abstract
{
    public abstract class Switchable : ISwitchable
    {
        public abstract bool Status { get; set; }
    }
}