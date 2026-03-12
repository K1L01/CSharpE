using System.Globalization;
using System.IO.Pipelines;
using System.Security.Cryptography;
using System.Transactions;

public class Exercise1
{
    public static void MainExercise1()
    {
        Console.WriteLine("Hello");
        Console.WriteLine("Kristiyan Ivanov!");
    }
}
public class Exercise2
{
    public static void MainExercise2()
    {
        Console.WriteLine(15+17);
    }
}
public class Exercise3
{
    public static void MainExercise3()
    {
        Console.WriteLine(169/13);
    }
}
public class Exercise4
{
    public static void MainExercise4()
    {
        int res1 = -1 + 4 * 6;
        int res2 = (35+ 5)% 7;
        int res3 = 14+ -4*6/11;
        int res4 = 2 + 15/6 * 1 - 7 % 2;
        Console.WriteLine($"{res1}\n{res2}\n{res3}\n{res4}");
    }
}
public class Exercise5
{
    public static void MainExercise5()
    {
        int number1, number2, temp;
        
        Console.Write("Input the First Number: ");
        number1 = int.Parse(Console.ReadLine());
        Console.Write("Input the Second Number: ");
        number2 = int.Parse(Console.ReadLine());
        
        temp = number1;
        number1 = number2;
        number2 = temp;
        Console.Write("After Swapping");
        Console.Write($"\nFirst Number is: {number1}");
        Console.Write($"\nSecond Number is: {number2}");
        
        Console.Read(); //Keep the console open till key is pressed.
    }
}
public class Exercise6
{
    public static void MainExercise6()
    {
        int num1,num2,num3,result; 
        Console.Write("\nInput Number#1 for multiply: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Number#2 for multiply: ");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input Number#3 for multiply: ");
        num3 = Convert.ToInt32(Console.ReadLine());
        result = num1 * num2 * num3;
        Console.Write($"The Result: {num1} x {num2} x {num3} = {result}");
        Console.Read(); // zzz
        Console.Read(); // Testing purposes
    }
}
public class Exercise7
{
    public static void MainExercise7()
    {
        Console.Write("Input#1: ");
        int input1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input#2: ");
        int input2 = Convert.ToInt32(Console.ReadLine());

        Console.Write($"{input1} + {input2} = {input1 + input2}");
        Console.Write($"\n{input1} - {input2} = {input1 - input2}");
        Console.Write($"\n{input1} x {input2} = {input1 * input2}");
        Console.Write($"\n{input1} / {input2} = {input1 / input2}");
        Console.Write($"\n{input1} mod {input2} = {input1 % input2}");
        
        // Prompting the user to enter the first number
        Console.Write("\nEnter a number: ");
        // Reading the first number entered by the user and converting it to an integer
        int num1 = Convert.ToInt32(Console.ReadLine());

        // Prompting the user to enter the second number
        Console.Write("Enter another number: ");
        // Reading the second number entered by the user and converting it to an integer
        int num2 = Convert.ToInt32(Console.ReadLine());

        // Displaying addition of the two numbers
        Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);

        // Displaying subtraction of the two numbers
        Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);

        // Displaying multiplication of the two numbers
        Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);

        // Displaying division of the two numbers
        Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);

        // Displaying modulus (remainder) of the two numbers
        Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
    }
}
public class Exercise8
{
    public static void MainExercise8()
    {
        Console.Write("Enter a number to multiply: ");
        int x = Convert.ToInt32(Console.ReadLine());
        int result;
        result = x * 1;
        Console.Write("{0} x {1} = {2}", x, 1, result);
        result = x * 2;
        Console.Write("\n{0} x {1} = {2}", x, 2, result);
        result = x * 3;
        Console.Write("\n{0} x {1} = {2}", x, 3, result);
        result = x * 4;
        Console.Write("\n{0} x {1} = {2}", x, 4, result);
        result = x * 5;
        Console.Write("\n{0} x {1} = {2}", x, 5, result);
        result = x * 6;
        Console.Write("\n{0} x {1} = {2}", x, 6, result);
        result = x * 7;
        Console.Write("\n{0} x {1} = {2}", x, 7, result);
        result = x * 8;
        Console.Write("\n{0} x {1} = {2}", x, 8, result);
        result = x * 9;
        Console.Write("\n{0} x {1} = {2}", x, 9, result);
        result = x * 10;
        Console.Write("\n{0} x {1} = {2}", x, 10, result);
       
    }

}
// git is hard.. -git add "filename"."filetype", git commit -m "comment", git push.
public class Exercise9
{
    public static void Main()
    {
        Console.Write("Enter the First number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the Second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the third number: ");
        int num3 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the four number: ");
        int num4 = Convert.ToInt32(Console.ReadLine());
        int averageNum = (num1 + num2 + num3 + num4)/4;
        Console.Write("The average number of {0}, {1}, {2}, {3} is {4}",
         num1, num2, num3, num4, averageNum);
        Console.Write("\nPress any key to close the window.");
        Console.Read();
    }
}