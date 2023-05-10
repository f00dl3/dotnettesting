using System;
using System.Text;

class Program {

    public interface IComparable<in T> {
        int CompareTo(T? other);
    }

    internal static void colorSamples() {
        Color c1 = Color.Red;
        Console.WriteLine(c1);
    }

    public record Position(int X, int Y);

    static void tableNumbers() {

        for(int i = 0; i < 100; i += 10) {
            for(int j = i; j < i + 10; j++) {
                Console.Write($" {j}");
            }
            Console.WriteLine();
        }

    }

    static void weekend() {
        DaysOfWeek weekend = DaysOfWeek.Saturday | DaysOfWeek.Sunday;
        Console.WriteLine(weekend);
    }

    public record Person(string FirstName, string LastName) : IComparable<Person> {
        public int CompareTo(Person? other) {
            int compare = LastName.CompareTo(other?.LastName);
            if(compare is 0) { return FirstName.CompareTo(other?.FirstName); }
            return compare;
        }
    }

    static void GetPeople() {

        Person p1 = new("Emily", "S");
        Person p2 = new("Anthony", "S");
        Person p3 = new("Fletcher", "S");
        
        Person[] people = { p1, p2, p3 };
        try { Array.Sort(people); } catch (Exception e) { }
        foreach(var p in people) { Console.WriteLine(p); }

    }

    static void Method() => Console.WriteLine("Method reached!");
    
    static void Main(string[] args) {

        int? x1 = null;
        Position position = new Position(35, 17);

        uint binary1 = 0b_1111_1110_1101_1100_1101_1000_0001;

        Console.WriteLine(binary1);

        foreach(var arg in args) {
            Console.WriteLine(arg);
            if(!x1.HasValue) { x1 = 0; } else { x1++; }
        }

        for(int i = 0; i < 10; i++) {
            string? whatToWrite = (i-x1).ToString();
            StringBuilder? sb = new (whatToWrite);
            string? whatToWriteFromSb = sb.ToString();
            Console.Write(whatToWriteFromSb);
        }
        Console.WriteLine();
        
        Method();
        tableNumbers();
        colorSamples();
        weekend();
        GetPeople();

    }

}