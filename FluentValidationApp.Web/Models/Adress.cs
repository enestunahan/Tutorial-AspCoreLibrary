namespace FluentValidationApp.Web.Models
{
    public class Adress
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public string Province { get; set; }
        public string PostCode { get; set; }
        public int CustomerId { get; set; }
        public virtual  Customer Customer { get; set; }
        //Burayı virtual yapmamızın sebebi ef core Customer üzerinde tracking(izleme)
        //işlemi gerçekleştirebilsin diye
    }
}
