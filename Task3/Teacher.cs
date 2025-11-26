using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class Teacher
{
    public string Name { get; set; }

    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    // This method CANNOT be overridden
    public void SalaryInfo()
    {
        Console.WriteLine("Teacher salary is confidential.");
    }
}
