namespace Task5;

// ---- Сценарій 1: virtual + override ----
public class Device
{
    public virtual string Describe() => "Device.Describe (базова реалізація)";
}

public class Smartphone : Device
{
    public override string Describe() => "Smartphone.Describe (override)";
}

// ---- Сценарій 2: невіртуальний метод + new ----
public class Printer
{
    public string Describe() => "Printer.Describe (базова реалізація)";
}

public class LaserPrinter : Printer
{
    public new string Describe() => "LaserPrinter.Describe (new)";
}

// ---- Сценарій 3: virtual у базі + new у похідному ----
public class Scanner
{
    public virtual string Describe() => "Scanner.Describe (базова реалізація, virtual)";
}

public class FlatbedScanner : Scanner
{
    public new string Describe() => "FlatbedScanner.Describe (new)";
}
