using static System.Console;  

Clear();
WriteLine("Введите длинну массива: ");  
int length = Convert.ToInt32(ReadLine());   //пользователь задает длину массива 
string[] array = new string[length];

    for (int i = 0; i < array.Length; i++)
{
    WriteLine($"Введите {i+1}-й элемент массива: ");            
    string elem = Convert.ToString(ReadLine());         
    array[i] = elem;
}


