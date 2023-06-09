namespace APITesting.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }

        public Beer(int id, string name, string brand)
        {
            Id = id;
            Name = name;
            Brand = brand;
        }
    }
}
