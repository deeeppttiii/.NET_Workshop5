class Program
{
    static void Main(string[] args)
    {
        //  Printer Method Overloading
        Printer printer = new Printer();

        printer.Print("Hello from Dharan");
        printer.Print(8848);
        printer.Print(" Deepti Dhungana", 3);

        //  Teacher Class Inheritance
        Console.WriteLine("--- Teacher Demonstration ---");

        NepaliTeacher nepTeacher = new NepaliTeacher()
        {
            Name = "Mr. Bhandari"
        };

        EnglishTeacher engTeacher = new EnglishTeacher()
        {
            Name = "Mrs. Dhungana"
        };

        // Nepali Teacher
        Console.WriteLine($"Nepali Teacher: {nepTeacher.Name}");
        nepTeacher.Teaching();
        nepTeacher.SalaryInfo();

        // English Teacher
        Console.WriteLine($"English Teacher: {engTeacher.Name}");
        engTeacher.Teaching();    // uses base class method
        engTeacher.SalaryInfo();
    }
}
