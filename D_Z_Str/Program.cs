//Задача 1: Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
/*
char [,] matrix  = {{'М','И','Р',' '},{'Т','Р','У','Д'},{' ','М','А','Й'}};
string GetStringFromMatrix (char [,] matrix)
{
    string str = "";
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            str +=matrix[i,j];
        }
    }
    return str;
}
string res = GetStringFromMatrix(matrix);
Console.WriteLine(res);
*/

//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.
/*
Console.Write("Ведите строку: ");
string str = Console.ReadLine();
string res = str.ToLower();
Console.WriteLine($"Обнизили - {res}");
*/

//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.
/*
char [] StrToChar (string str)
{
    char [] chars = new char [str.Length];
    for (int i = 0; i<str.Length; i++)
    {
        chars[i] = str[i];
    }
    return chars;
}
// void PrintArray (char [] chr)
// {
//     foreach(char e in chr)
//     {
//         Console.Write(e+" ");
//     }
// }

bool CompareMirror (char[] chr)
{
    bool flag = false;
    for (int i = 0; i<chr.Length/2; i++)
    {
        if (chr[i] == chr[chr.Length-1-i])
            flag = true;
        else
            return false;
    }
    return flag;
}
string str = Console.ReadLine();
char[] chr = StrToChar(str);
Console.WriteLine(CompareMirror(chr));

*/