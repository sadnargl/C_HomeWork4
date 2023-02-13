int f = InputFigureFromConsole ("Введите число: ");
int zum = 0;
f = Math.Abs(f); //чтобы захватить числа со знаком минус
for (int j = 0; j <= f.ToString().Length-1; j++)
    {
zum = zum + (int)char.GetNumericValue(f.ToString()[j]); //час рожал эту строчку
    }
Console.WriteLine ($"Сумма цифр числа {f} равна {zum}");

int InputFigureFromConsole (string invitation)
{
    Console.Write (invitation);
    int i;
    while (!int.TryParse (Console.ReadLine(), out i))
    {
        Console.WriteLine ("Ошибка ввода числа");
        Console.Write (invitation);
    }
    return i;
}