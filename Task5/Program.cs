using Task5;

Console.OutputEncoding = System.Text.Encoding.UTF8;

static void Show(string variableType, object actual, string result) =>
    Console.WriteLine($"Змінна {variableType.PadRight(15)} | GetType() = {actual.GetType().Name.PadRight(15)} | {result}");

Console.WriteLine("=== Сценарій 1: virtual + override ===");
Device d1 = new Device();
Device d2 = new Smartphone();
Smartphone d3 = new Smartphone();
Show("Device", d1, d1.Describe());
Show("Device", d2, d2.Describe());
Show("Smartphone", d3, d3.Describe());

Console.WriteLine();
Console.WriteLine("=== Сценарій 2: невіртуальний метод + new ===");
Printer p1 = new Printer();
Printer p2 = new LaserPrinter();
LaserPrinter p3 = new LaserPrinter();
Show("Printer", p1, p1.Describe());
Show("Printer", p2, p2.Describe());
Show("LaserPrinter", p3, p3.Describe());

Console.WriteLine();
Console.WriteLine("=== Сценарій 3: virtual у базі + new у похідному ===");
Scanner s1 = new Scanner();
Scanner s2 = new FlatbedScanner();
FlatbedScanner s3 = new FlatbedScanner();
Show("Scanner", s1, s1.Describe());
Show("Scanner", s2, s2.Describe());
Show("FlatbedScanner", s3, s3.Describe());
