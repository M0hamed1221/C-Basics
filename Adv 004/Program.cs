namespace Adv_004
{
    internal class Program
    {



        #region Dictionary
        private static Dictionary<string, int> _Note = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase)
        {
        {"mohamed", 26},
        {"khaled",50},
        };



        private static KeyValuePair<string, int>[] NamesAges = new KeyValuePair<string, int>[]
        {

            new KeyValuePair<string, int>("Tarek",14),
            new KeyValuePair<string, int>("Omar",16),
            new KeyValuePair<string, int>("Fatma",14),
            new KeyValuePair<string, int>("Enas",25),


        };
        private static Dictionary<string, int> _KeyValueDictionary = new Dictionary<string, int>(NamesAges);

        #endregion


        #region HashSet
        private static HashSet<int> numbers = new HashSet<int>();
        

        public class Movie
        {
            public Movie(int iD, string title, decimal price)
            {
                ID = iD;
                Title = title;
                this.price = price;
            }

            public int ID { get; set; }
            public string Title { get; set; }

            public decimal price { get; set; }
            public override string ToString()
            {
                   return $"ID = {ID} , Title = {Title} , Price = {price}";
            }
            public override bool Equals(object? obj)
            {
                Movie? movie = obj as Movie;
                if (movie == null) return false;
                return this.ID.Equals(movie?.ID??0)&&this.Title.Equals(movie.Title)&& this.price.Equals(movie.price);
            }
            public override int GetHashCode()
            {
                return HashCode.Combine(ID, Title, price);
            }

        }


        private static HashSet<Movie> _movies = new HashSet<Movie>()
        {
            new Movie(1,"x",1000),
            new Movie(1,"y",1000),
            new Movie(1,"z",1000),

        };

        #endregion
        static void Main(string[] args)
        {
            _Note.Add("ALi", 25);
            Console.WriteLine("-------------------------------------");


            foreach (var note in _Note)
            {
                Console.WriteLine($"Person : {note.Key} and Age = {note.Value}");
            }
            Console.WriteLine("-------------------------------------");

            foreach (var note in _Note.Keys)
            {
                Console.WriteLine($"Person name :{note} ");
            }
            Console.WriteLine("-------------------------------------");

            foreach (var note in _Note.Values)
            {
                Console.WriteLine($"Person Age :{note} ");
            }
            Console.WriteLine("-------------------------------------");
            _Note.TryAdd("ALi", 25);
            Console.WriteLine("-------------------------------------");

            if(!_Note.ContainsKey("ALi"))
            {
                _Note.Add("ALi", 25);
            }
            else
            {
                Console.WriteLine("ALi Exists");
            }
            Console.WriteLine("-------------------------------------");

            bool resl = _Note.TryGetValue("Osama",out int value);
            if (resl)
            {
                Console.WriteLine("Osama");
            }
            else
            {
                Console.WriteLine("Osama Does not exist");
            }
            Console.WriteLine("-------------------------------------");
            numbers.Add(2);
            numbers.Add(4);
            numbers.Add(6);
            numbers.Add(8);
            numbers.Add(10);

            Console.WriteLine("-------------------------------------");
            foreach (var i in numbers)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-------------------------------------");
            foreach(var i in _movies)
            {
                Console.WriteLine(i);
            }
        }
    }
}
