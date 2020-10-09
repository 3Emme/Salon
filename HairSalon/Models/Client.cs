namespace HairSalon.Models
{
    public class HairSalon
    {
        public int ClientId {get;set;}
        public string ClientName {get;set;}
        public string ClientDetails {get;set;}
        public int StylistId {get;set;}
        public virtual Stylist Stylist {get;set;}

        public Client()
        {
          //
        }
    }
}