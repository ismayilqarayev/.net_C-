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

    public int[] massiv1;
    public int[] massiv2;
    public int[] massiv3;
    public int[] massiv4;
    public int[] massiv5;
    
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Fun1();
        program.Fun2();
        
    }

    public void Fun1()
    {
        massiv1 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        massiv2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        massiv3 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        massiv4 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        massiv5 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        var run1 = massiv1[1];
        var run2 = massiv2[2];
        var run3 = massiv3[3];
        var run4 = massiv4[4];
        var run5 = massiv5[5];
        
    }

    public void Fun2()
    {
        massiv1[5] = 50;
        massiv2[4] = 2;
        Console.WriteLine($"{massiv1[5]}");
        Console.WriteLine($"{massiv2[4]}");
    }
}

