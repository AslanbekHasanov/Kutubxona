namespace Kutubxona.Model
{
    public class User
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public Book UserBook { get; set; }
        public Car UserCar { get; set; }
    }
}
