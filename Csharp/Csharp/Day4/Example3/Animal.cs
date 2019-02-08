namespace Csharp.Day4.Example3
{
    internal class Animal
    {
        public string Name { get; set; }
        public double Length { get; set; }
        public double Width { get; set; }
        public int ID { get; set; }

        public Animal(string name = "cat",
                double length = .8,
                double width = 20)
        {
            Name = name;
            Width = width;
            Length = length;
        }

        public override string ToString()
        {
            return string.Format("{0} lenght {1} and is {2} cm",
               Name,Length,Width);
        }

    }
}