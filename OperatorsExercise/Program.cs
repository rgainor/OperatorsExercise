namespace OperatorsExercise;
class Program
{
    static void Main(string[] args)
    {
        ExerciseMethod();
        AreaOfCircleMethod();
    }

    static void ExerciseMethod()
    {
        int a = 17;
        int b = 4;
        int quotient = a / b;
        int remainder = a % b;
        Console.WriteLine($"{a}/{b} = {quotient} remainder {remainder}");
    }
    static double AreaOfCircleMethod()
    {
        Console.WriteLine("What is the radius of your circle?");
        var radius = double.Parse(Console.ReadLine());

        double area = Math.PI * radius *radius;
        Console.WriteLine($"The area of a circle with a radius of {radius} is {area}");
        return area;

    }
}
