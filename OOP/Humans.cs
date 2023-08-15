

namespace OOP
{
    public class Humans
    {
        //fields
        public int Age { get; set; }
        List<string> names;
        //methods
        public Humans()
        {
            names = new List<string>();
        }
        public void Introduce()
        {
           // Console.WriteLine($"Hello I'm {names}");
        }
        public void addName(string newname)
        {
            names.Add(newname);
            Console.WriteLine(names[0]);
        }
    }
}
