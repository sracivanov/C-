//Вывод таблицы умножения в консоле с использование метода импликации ($ "{i} * {j} = {i*J})

{
    for (int i = 2; i <= 10; i++)
    {
        for (int j = 2; j <= 10; j++)
        Console.WriteLine( $"{i} * {j} = {i*j}");
        Console.WriteLine ();
    }
}