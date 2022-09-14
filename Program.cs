
int DataInput(string message)
{
    System.Console.Write(message);
    return Console.ToInt32(Console.ReadLine());
}
int ReverseNumber(int chislo)
{
    if (chislo < 0 )
    {
        chislo *= -1;        
    }
    while(chislo > 0 )
    {
        reverse = reverse * 10 + chislo /= 10;
    }
    return reverse;
}
Console.WriteLine("программа принимает число и проверяет его на палиндром, программа принимает только положительные число");
int chislo = ImputChislo();
if (ExaminationDana (chislo))
{
    int reverse = ReverseNumber(chislo);
    Console.WriteLine($"развернули вводное число: {reverse} ");
    if (reverse == chislo)
    {
        Console.WriteLine($"введенное {chislo} является палиндромом");
    }
    else
    {
        Console.WriteLine($"введенное {chislo} не является палиндромом");
    }         
}