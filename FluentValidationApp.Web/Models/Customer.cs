namespace FluentValidationApp.Web.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public DateTime? BirthDay { get; set; }
        public IList<Adress> Adresses { get; set; }
        // Bunu IList olarak tanımlamam sebebi Customer.Adresses[i].Province
        // olarak kullanmak istememiz yani indeksleme yapabilmek için

        public Gender Gender { get; set; }
    }
}
