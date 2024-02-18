namespace ConsoleApp1
{
    class Program
    {
        private static readonly int Number1 = 10;
        private static readonly int Number_2 = 20;
        private static readonly int Number_3 = 30;
        private static readonly int Number_4 = 40;
        private string _name;
        private int _age;
        
        public Program(string name, int age)
        {
            _name = name;
            _age = age;
        }

        private Program(string name)
        {
            throw new NotImplementedException();
        }

        public static void Main(string[] args)
        {
           
            Program program = new Program(name:"tim", age:43);
            program.Function_1(Number1);
        }

        private void Function_1(int num1)
        {
            Console.WriteLine($"{num1}, {_name}, {_age}"); 
        }
    }
}

//==============================================================================//

using System;

class Program
{
    private static readonly int Number1 = 1;
    private static readonly int Number2 = 2;
    private static readonly int Number3 = 3;
    private static readonly int Number4 = 4;
    
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Fun_1(Number1);
        
    }

    private void Fun_1(int num1)
    {
        int[] num2 = new int[6] { 1,2,3,4,5,6 };
        var get = num2[2];
        Console.WriteLine($"{num1}");
    }
}

//=============================================================================//

namespace ConsoleApp1;

public class Program
{
    private static readonly int Number1 = 1;
    private static readonly int Number2 = 2;
    private static readonly int Number3 = 3;
    private static readonly int Number4 = 4;

    public int[] get1;
    public int[] get2;
    public int[] get3;
    public int[] get4;
    public int[] get5;
    
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Fun1();
        program.Fun2();
        
    }

    public void Fun1()
    {
        get1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        get2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        get3 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        get4 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        get5 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var run1 = get1[1];
        var run2 = get1[2];
        var run3 = get1[3];
        var run4 = get1[4];
        var run5 = get1[5];
        
    }

    public void Fun2()
    {
        get1[5] = 50;
        get2[4] = 2;
        Console.WriteLine($"{get1[5]}");
        Console.WriteLine($"{get2[4]}");
    }
}

