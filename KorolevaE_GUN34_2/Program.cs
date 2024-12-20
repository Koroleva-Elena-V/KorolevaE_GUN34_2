//class Program
//{
//    static void Main(string[] args)
//    {
//        //if (!Int32.TryParse(Console.ReadLine(), out var a)) 
//        //{ 
//        //    Console.WriteLine("Not a number!");
//        //    return;
//        //}

//        //if (!Int32.TryParse(Console.ReadLine(), out var b))
//        //{
//        //    Console.WriteLine("Not a number!");
//        //    return;
//        //}


//        //var s = Console.ReadLine();
//        //var boolVar = true;

//        //if (s.Length == 0 || s.Length > 1 && !boolVar)
//        //{
//        //    Console.WriteLine("Wrong sign!");
//        //    return;
//        //}

//        //switch (s[0])
//        //{
//        //    case '+':
//        //        Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
//        //        break;
//        //    case '-':
//        //        Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
//        //        break;
//        //    case '*':
//        //        Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
//        //        break;
//        //    case '/':
//        //        Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
//        //        break;
//        //    case '%':
//        //        Console.WriteLine("Result of {0} % {1} = {2}", a, b, a % b);
//        //        break;
//        //    default: 
//        //        Console.WriteLine("Wrong sign!");
//        //        break;

//    }
//}


class Program
{
            static void Main(string[] args)
        {
              // В калькуляторе пользователю предлагается ввести первое число, затем второе + проверка
             Console.WriteLine("Enter the first number:");
            if (!Int32.TryParse(Console.ReadLine(), out var a))
            {
                Console.WriteLine("Error! Invalid input for the first number.");
                return;
            }
                        
            Console.WriteLine("Enter the second number:");
            if (!Int32.TryParse(Console.ReadLine(), out var b))
            {
                Console.WriteLine("Error! Invalid input for the second number.");
                return;
            }

            // предложить пользователю ввести оператор
             Console.WriteLine("Enter the operator (&, |, or ^):");
            string s = Console.ReadLine();

            // Проверка оператора
            if (s != "&" && s != "|" && s != "^")
            {
                Console.WriteLine("Error! Invalid operator.");
                return;
            }

             // выводится результат побитовой операции
              int total = 0;
            switch (s)
            {
                case "&":
                    total = a & b;
                    break;
                case "|":
                    total = a | b;
                    break;
                case "^":
                    total = a ^ b;
                    break;
            }

                Console.WriteLine("Decimal: " + total);
                Console.WriteLine("Binary:  " + Convert.ToString(total, 2));
                Console.WriteLine("Hexadecimal:  " + Convert.ToString(total, 16));
        }
    
}