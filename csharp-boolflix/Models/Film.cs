namespace csharp_boolflix.Models
{
    public class Film
    {
        public int FilmId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Image { get; set; }
        public int Duration { get; set; }

        public Film()
        {

        }
        public Film(string name, int age, string image, int duration)
        {
            Name = name;
            Age = age;
            Image = image;
            Duration = duration;
        }
    }
}
