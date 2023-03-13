class Program {
    static void Main(string[] args) {

        Console.Write("Input x1 : ");
        float x1 = float.Parse(Console.ReadLine());

        Console.Write("Input y1 : ");
        float y1 = float.Parse(Console.ReadLine());

         Console.Write("Input w1 : ");
        float w1 = float.Parse(Console.ReadLine());

         Console.Write("Input h1 : ");
        float h1 = float.Parse(Console.ReadLine());

         Console.Write("Input x2 : ");
        float x2 = float.Parse(Console.ReadLine());

         Console.Write("Input y2 : ");
        float y2 = float.Parse(Console.ReadLine());

         Console.Write("Input w2 : ");
        float w2 = float.Parse(Console.ReadLine());

         Console.Write("Input h2 : ");
        float h2 = float.Parse(Console.ReadLine());

        if ((x1*y2*h1*w1-x2*y2*h2*w2 >= 0 ) && (x1*y2*h1*w1-x2*y2*h2*w2 <=8)) {
            Console.WriteLine("Too Much Overlapping");
                } else if ((x1*y1*h1*w1-x2*y2*h2*w2 >= 0 ) || (x1*y1*h1*w1-x2*y2*h2*w2 <=8)) {
                    Console.WriteLine("Not Much Overlapping");
                 } else if (!(x1*y1*h1*w1 >= 0 )) {
                    Console.WriteLine("NO Overlapping");
                } else if (!(x2*y2*h2*w2 >= 0)) {
                    Console.WriteLine("NO Overlapping");
        }
    }
}