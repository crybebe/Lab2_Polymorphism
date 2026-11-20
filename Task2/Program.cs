using Task2;

Console.OutputEncoding = System.Text.Encoding.UTF8;

// Кожен блок виводиться окремо — це зручно для скріншотів.
AbstractionDemo.Run();
Pause();

CastingDemo.Run();
Pause();

AggregationDemo.Run();

static void Pause()
{
    Console.WriteLine();
    Console.WriteLine("(скрін цього блоку) Натисніть Enter для переходу далі...");
    Console.ReadLine();
    Console.Clear();
}
