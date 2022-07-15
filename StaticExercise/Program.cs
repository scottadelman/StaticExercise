namespace StaticExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me a temperature in Fahrenheit to convert to Celsius");
            var celsius = TempConverter.FahrenheitToCelsius();
            Console.WriteLine(celsius);
            
            Console.WriteLine("Give me a temperature in Celsius to conver to Fahrenheit");
            var fahrenheit = TempConverter.CelsiusToFahrenheit();
            Console.WriteLine(fahrenheit);
        }

    }
}