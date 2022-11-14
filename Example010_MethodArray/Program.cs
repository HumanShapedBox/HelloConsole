int[] array = { 111, 52, 31, 4, 18, 16, 7, 18 };

int n = array.Length;
int find = 18;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break; // Прерывает работу программы при первом же совпадении условий поиска
    }
    index++;
    // index = index + 1
    // index +=1;
}