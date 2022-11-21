// Вид 1 (Ничего не принимаю, ничего не возвращаю)

void Method1()
{
    Console.WriteLine("Автор: Ксюшонок");
}

Method1(); // Вызов метода


// Вид 2 (Что-то принимаю, ничего не возвращаю)

// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }

// Method2("Текст сообщения"); 

// Аргументы могут быть "именоваными", когда мы указываем,
// что и какому аргументу хотим передать
// Method2(msg: "Текст сообщения"); 

void Method21(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
    
}

Method21("Ксюшонок молодец", 4); 
// Для большей конкретики можем использовать Method21(msg: "Текст", count: 4);
// В случае с именоваными аргументами не обязательно соблюдать 
// строгую очерёдность написания: 
// Method21(msg: "Текст", count: 4); == Method21(count: 4, msg: "Текст",);


// Вид 3 (ничего не принимаю, что-то возвращаю)
int Method3()
{
    return DateTime.Now.Year; //Он сам знает год, какой умничка
}

int year = Method3();
Console.WriteLine(year);


// Вид 4 (что-то принимают, что-то возвращают)

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; //Значит, что начало у нас будет пустой строкой
    while(i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}

string res = Method4(count: 10, text: "Чмок ");
Console.WriteLine(res);