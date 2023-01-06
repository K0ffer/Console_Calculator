using System.ComponentModel.Design;

public class ConsoleCalculator
{
    public static void Main()
    {
        char work = 'Y';
        while (work == 'Y')
        {
            Console.WriteLine("Enter first num");
            double num1 = num_input();
            Console.WriteLine("Enter second num");
            double num2 = num_input();
            Console.WriteLine("Enter required operation");
            bool check = false;
            while (!(check))
            {
                char oper = Convert.ToChar(Console.ReadLine());
                switch (oper)
                {
                    case '+':
                        Console.WriteLine($"{num1} {oper} {num2} = {num1 + num2}");
                        check = true;
                        break;
                    case '-':
                        Console.WriteLine($"{num1} {oper} {num2} = {num1 - num2}");
                        check = true;
                        break;
                    case '*':
                        Console.WriteLine($"{num1} {oper} {num2} = {num1 * num2}");
                        check = true;
                        break;
                    case '/':
                        divide_by_zero_check(num1, num2, oper, check);
                        break;
                    case ':':
                        divide_by_zero_check(num1, num2, oper, check);
                        check = true;
                        break;
                    default:
                        Console.WriteLine("Error, no existing operation found, try again");
                        break;
                }
            }
            Console.WriteLine("Type 'Y' to calculate new values, anything else to stop");
            work = Convert.ToChar(Console.ReadLine());
        }
    }
    static double num_input()
    {
        double numOut = 0;
        bool check = false;
        while (!(check))
        {
            string numIn = Console.ReadLine();
            if (!(double.TryParse(numIn, out numOut)))
            {
                Console.WriteLine("Incorrect number, try again");
            }
            else
            {
                check = true;
            }
        }
        return numOut;
    }

    static bool divide_by_zero_check(double num1, double num2, char oper, bool check)
    {
        if ((num1 == 0) || (num2 == 0))
        {
            Console.WriteLine("Can't divide by zero, enter new operation");
        }
        else
        {
            Console.WriteLine($"{num1} {oper} {num2} = {num1 / num2}");
            check = true;
        }

        return check;
    }
}