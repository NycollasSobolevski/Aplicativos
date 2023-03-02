// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string nomesString = "Nycollas Peterson Lucas Felipe Andre";
string nomesString2 = "Nycollas Peterson Lucas Felipe Andre";
string[] nomes = nomesString.Split(" ");
string[] nomes2 = nomesString2.Split(" ");
// Primeira quest
nomes = nomes.Sub(2);
// Segunda quest
nomes = nomes.Add(nomes2);

//foreach (var item in nomes)
//{
//    Console.WriteLine(item);
//}

public static class ListExtension
{
    public static T[] Sub<T>(this T[] array, int position)
    {
        T[] newArray = new T[array.Length-1];
        for (int i = 0; i < newArray.Length; i++)
        {
            if (i >= position)
            {
                if (i < newArray.Length)
                    newArray[i] = array[i + 1];

            }
            else
                newArray[i] = array[i];
        }
        return newArray;
    }

    public static T[] Add<T>(this T[] array, T[] Sarray)
    {

        int tam = array.Length + Sarray.Length;
        T[] newarray = new T[tam];

        for (int i = 0, j = 0; i < tam; i++)
        {
            if (i < array.Length)
            {
                newarray[i] = array[i];
            }
            else
            {
                newarray[i] = Sarray[j];
                j++;
            }
        }
        return newarray;
    }

}
int Factorial(this int number)
{
    if (number == 0)
        return 1;
        
    int res = number;
    for (int i = number - 1; i > 0; i--)
    {
        res = res * i;
    }
    return res;
}

//segunda questao
