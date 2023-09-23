// а как делоеца ооп в сешарп
int num = 0;
int num_first = 0;
int num_second = 0;

Console.WriteLine("enter operation: ");
string operation = Console.ReadLine();

if (operation == "tan" || operation == "!")
{
    Console.WriteLine("enter number: ");
    num = int.Parse(Console.ReadLine());
}
else
{
    try
    {
        Console.WriteLine("enter first number: ");
        num_first = int.Parse(Console.ReadLine());
        Console.WriteLine("enter second number: ");
        num_second = int.Parse(Console.ReadLine());
    }
    catch (FormatException)
    {
        Console.WriteLine("wrong number");
    }
}

bool flag = true;
double sum = 0;
double cont_num = 0;

// смешно, я не нашёл в Math факториал xd
int Factorial(int n)
{
    if (n == 1) 
        return 1;

    return n * Factorial(n - 1);
}

while (true)
{
    switch(operation)
    {
        case "+":
            if (flag)
                sum += num_first + num_second;
            else
                sum += cont_num;
            break;
        case "-":
            if (flag)
                sum += num_first - num_second;
            else
                sum -= cont_num;
            break;
        case "*":
            if (flag)
                sum += num_first * num_second;
            else
                sum *= cont_num;
            break;
        case "/":
            if (flag)
                sum += num_first / num_second;
            else
                sum /= cont_num;
            break;
        case "pow":
            if (flag)
                sum += Math.Pow(num_first, num_second);
            else
                sum += Math.Pow(sum, cont_num);
            break;
        case "sqrt":
            if (flag)
                sum += Math.Sqrt(num);
            else
                sum += Math.Sqrt(cont_num);
            break;
        case "!":
            if (flag)
                sum += Factorial(num);
            else
                sum += Factorial(Convert.ToInt32(cont_num));
            break;        
        case "%":
            if (flag)
                sum += num_first * num_second / 100;
            else
                sum *= cont_num / 100;
            break;
        default: 
            Console.WriteLine("wrong operation");
            break;
    }

    // megasuperultramulti solution
    flag = false;

    Console.WriteLine(sum);

    Console.WriteLine("do you want continue? y/n");
    string cont = Console.ReadLine();
    if (cont == "y")
    {
        try
        {
            Console.WriteLine("enter operation: ");
            operation = Console.ReadLine();
            Console.WriteLine("enter num: ");
            cont_num = int.Parse(Console.ReadLine());
            continue;
        }
        catch (FormatException)
        {
            Console.WriteLine("wrong number");
            break;
        }
    }
    else
    {
        Console.WriteLine($"end solution: { sum }");
        break;
    }
}