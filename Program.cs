﻿//This is da big calculator
//Currently, negative powers and divisions are normal sized not BIG

using System.Numerics;

char op;
BigInteger ans;
decimal num1;
decimal num2;
decimal num3;
decimal num4;
//decimal num5;
double num6;
double num7;
string rip;
program();
void program()
{
    Console.WriteLine("Enter an operator{+ - / *} or p (for power) or f (for factorial) or s (for square root)");
    rip = Console.ReadLine();
    if (rip != null && (rip == "+" || rip == "-" || rip == "*" || rip =="/" || rip == "p" || rip == "f"|| rip == "s"))
    {
    op = Convert.ToChar(rip);
    }
    else
    {
        program();
    }
    switch (op)
    {
        case '+':
            Console.WriteLine("Enter The First Number");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = Convert.ToDecimal(Console.ReadLine());
            //ans =  (BigInteger) num1 + (BigInteger) num2;
            Console.WriteLine(num1 + num2);
            break;
        case '-':
            Console.WriteLine("Enter The First Number");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = Convert.ToDecimal(Console.ReadLine());
            //ans = (BigInteger)num1 - (BigInteger)num2;
            Console.WriteLine(num1 - num2);
            break;
        case '*':
            Console.WriteLine("Enter The First Number");
            num1 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num2 = Convert.ToDecimal(Console.ReadLine());
            if (num1 % 1 == 0 && num2 % 1 == 0)
            {
                ans = (BigInteger)num1 * (BigInteger)num2;
                Console.WriteLine(ans);
            }
            else
            {
                Console.WriteLine(num1 * num2);
            }
            break;
        case '/':
            Console.WriteLine("Enter The First Number");
            num3 = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Enter The Second Number");
            num4 = Convert.ToDecimal(Console.ReadLine());
            //ans = (BigInteger)decimal.Divide(num3, num4);
            //ans = BigInteger.Divide((BigInteger)num3, (BigInteger)num4);
            //Console.WriteLine(ans);
            //It's not big it's just normal
            Console.WriteLine(num3 / num4); ;
            break;
        case 'p':
            Console.WriteLine("Enter The Base Number");
            num6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter The Power");
            num7 = Convert.ToDouble(Console.ReadLine());
            ans = 1;
            if (num7 >= 0 && num6 % 1 != 0)
            {
                num6 = Math.Pow(num6, num7);
                Console.WriteLine(num6);
            }
            if (num7 < 0 && num6 % 1 != 0)
            {
                num6 = Math.Pow(num6, num7);
                Console.WriteLine(num6);
            }
            if (num7 >= 0 && num6 % 1 == 0)
            {
                
                for (int i = 1; i <= num7; i++)
                {
                   ans = ans * (BigInteger)num6;
                }
                Console.WriteLine(ans);
            }
            if (num7 < 0 && num6 % 1 == 0)
            {
                //simple power not BIG
                num6 = Math.Pow(num6, num7);
                Console.WriteLine(num6);
            }

            break;
        case 'f':
            Console.WriteLine("Enter The Number You Want Its Factorial");
            num1 = Convert.ToInt32(Console.ReadLine());
            ans = 1;
            for (int i = 1; i <= num1; i++)
            {
                ans = ans * i;
            }
            Console.WriteLine(ans);
            break;
        case 's':
            Console.WriteLine("Enter The Number You Want Its Square Root");
            num6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(Math.Sqrt(num6));
            break;
        default:
            break;
    }
    Console.WriteLine("Enter 1 to continue or anything else to exit");
    if (Console.ReadLine() == "1")
    {
        program();
    }
    else
    {
        Environment.Exit(0);
    }
}