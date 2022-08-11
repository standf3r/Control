void stringArrayInNewArray(string[] stringArray, int n)
{
    for (int i = 0; i < stringArray.Length; i++) // вывод в консоль первоначального массива
    {
        Console.Write(stringArray[i] + " ");
    }
    Console.Write(" => ");
        
    string tempStr; // перменная для присваивания элемента массива строки
    char[] tempChars; // переменная для присваивания символов из массива строки (знаков)
    for (int i = 0; i < stringArray.Length; i++) // формирование нового массива и вывод его в консоль
    {
        tempStr = stringArray[i]; // присваивание i элемента
        tempChars = tempStr.ToCharArray(); // присваивание знаков элемента
        if (tempChars.Length <= n) // условие сравнения количества знаков в элементе строки
        {
        Console.Write(stringArray[i] + " "); // вывод в консоль
        }    
    }
    Console.WriteLine();
}
