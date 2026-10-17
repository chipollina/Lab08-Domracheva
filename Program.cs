// Задание 1 
// PrintHeader("Отчёт");
// PrintHeader("Итоги");
// Задание 2.1
// Console.WriteLine(Max(4, 5));
// Console.WriteLine(Max(-4, 10));
// Console.WriteLine(Max(-1, -10));
// Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));
// Задание 3
// Console.WriteLine(Average(m));
// Console.WriteLine(CountGreater(m, 100));
// Задание 4
// Console.WriteLine($"{0} C = {ToFahrenheit(0)} F");
// Console.WriteLine($"{100} C = {ToFahrenheit(100)} F");
// Console.WriteLine($"{37} C = {ToFahrenheit(37)} F");
// Задание 5
// Console.WriteLine(Factorial(5));
// for (int i = 2; i <= 50; i++)
//     if (IsPrime(i)){
//         Console.Write(i + " ");}
// Задание 6
// int num1 = ReadPositive("Введите первое положит. число: ");
// int num2 = ReadPositive("Введите второе положит. число: ");
// Console.WriteLine($"Сумма = {num1 + num2}");
// Дополнительное задание
// Console.WriteLine(Gcd(48, 18));
// Console.WriteLine(Lcm(4, 6));



// Задание 1
static void PrintLine()
{
    Console.WriteLine("^_^");
}
static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine(title);
    PrintLine();
}


// Задание 2.1
static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}


// Задание 2.2
static bool IsEven(int n)
{
    return n % 2 == 0;
}


// Задание 3
static double Average(int[] arr)
{
    int sum = 0;
    int kol = 0;
    foreach (int i in arr){
        sum += i;
        kol++;}
    return (double)sum / kol;
}
static int CountGreater(int[] arr, int limit)
{
    int a = 0;
    foreach (int i in arr){
        if (i > limit){
            a++;}}
    return a;        
}
int[] m = { 120, 45, 300, 80, 15, 210 };



// Задание 4
static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}



// Задание 5
static long Factorial(int n)
{
    int k = 1;
    for (int i = 1; i <= n; i++)
    {
        k *= i;
    }
    return k;
}
static bool IsPrime(int n)
{
    if (n < 2){
        return false;}
    int l = 0;
    for (int i = 1; i <= n; i++){
        if (n % i == 0){
            l++;}
    }
    return l == 2;
}




// Задание 6
static int ReadPositive(string message)
{
    int num = 0;
    bool v = false;
    while (v == false){
        Console.Write(message);
        string input = Console.ReadLine();
        if (int.TryParse(input, out num) && num > 0)
        {
            v = true;}
        else{
            Console.WriteLine("Нужно ввести положительное число");}
    }
    return num;
}



// Итоговая задача. «Меню-калькулятор»
while (true)
{
    Console.WriteLine("1 - сумма двух чисел");
    Console.WriteLine("2 - большее из двух чисел");
    Console.WriteLine("3 - факториал");
    Console.WriteLine("0 - выход");
    string str = Console.ReadLine();
    switch (str)
    {
        case "1":
            int a = ReadPositive("введите первое число: ");
            int b = ReadPositive("введите второе число: ");
            Console.WriteLine(Sum(a, b));
            break;
        case "2":
            int c = ReadPositive("введите первое число: ");
            int d = ReadPositive("введите второе число: ");
            Console.WriteLine(Max(c, d));
            break;
        case "3":
            int f = ReadPositive("Ведите число: ");
            Console.WriteLine(Factorial(f));
            break;
        case "0":
            return;
        default:
            Console.WriteLine("нет такого пункта");
            break;
    }
}
static int Sum(int a, int b){
    return a + b;}
    

// Дополнительное задание★★★ 
static int Gcd(int a, int b)
{
    while (b != 0)
    {
        int t = b;
        b = a % b;
        a = t;
    }
    return a;
}
static int Lcm(int a, int b)
{
    return a / Gcd(a, b) * b;
}
