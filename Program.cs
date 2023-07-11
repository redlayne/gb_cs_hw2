Random rand = new Random();

void Break()
{
    Console.WriteLine();
    Console.WriteLine(new string('*', 50));
    Console.WriteLine();
}

void SecondDigitTask10()
{
    int num1 = rand.Next(100, 1000);
    int num2 = rand.Next(100, 1000);
    int num3 = rand.Next(100, 1000);

    int result1 = ((num1 / 10) % 10);
    int result2 = ((num2 / 10) % 10);
    int result3 = ((num3 / 10) % 10);

    Console.WriteLine("Second digits");
    Console.WriteLine(num1 + " -> " + result1);
    Console.WriteLine(num2 + " -> " + result2);
    Console.WriteLine(num3 + " -> " + result3);
}

void ThirdDigitTask13()
{
    int Reduction(int mynumber) // локальная функция! Как тебе такое, Илон Маск?!
    {
        if (mynumber / 100 == 0) return (-1); // первая проверка отдельно, чтобы не считать ее в цикле много раз

        int temp = mynumber;
        while (temp / 1000 > 0) temp = temp / 10; 
        return (temp%10);
    }

    int bignum1 = rand.Next(1000, 10000000);
    int bignum2 = rand.Next(1, 100);
    int bignum3 = rand.Next(1, 1000);
    
    Console.WriteLine("Third digits");

    if (Reduction(bignum1) > -1) Console.WriteLine(bignum1 + "  ->  " +  Reduction(bignum1)); else Console.WriteLine(bignum1 + "  -> No 3rd digit");
    if (Reduction(bignum2) > -1) Console.WriteLine(bignum2 + "  ->  " +  Reduction(bignum2)); else Console.WriteLine(bignum2 + "  -> No 3rd digit");
    if (Reduction(bignum3) > -1) Console.WriteLine(bignum3 + "  ->  " +  Reduction(bignum3)); else Console.WriteLine(bignum3 + "  -> No 3rd digit");
}

void WeekendTask15()
{   
    string[] Week = new string[] {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"}; //  по идее надо делать вне функции, чтобы не гонять конструктор каждый раз (?)

    Console.Write("input a number of the day ");
    int daynumber = Convert.ToInt32(Console.ReadLine());
    
    while (daynumber < 1 || daynumber > 7)
    {
        Console.Write("No such day in a week! Try another number ");
        daynumber = Convert.ToInt32(Console.ReadLine());
    }
    
    string isweekend;
    if (daynumber > 5) isweekend = "weekend"; else isweekend = "working day";
    
    Console.WriteLine($"Day number {daynumber} is a {Week[daynumber-1]}, it is a {isweekend}");
}

Console.Clear();

SecondDigitTask10();
Break();

ThirdDigitTask13();
Break();

WeekendTask15();
Break();