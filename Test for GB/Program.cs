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

WriteLine("Начальный массив: ");
Write("[");
PrintArray(array);
Write("]");
WriteLine();
WriteLine("Результат работы программы: ");
WriteLine();
PrintArray(ConvertArray(array,length));
WriteLine();

// ---------------------набор используемых методов----------------------------

void PrintArray(string [] filledArray){
    for(int i = 0; i<filledArray.Length;i++){
        Write(filledArray[i]+" ");
    }
}


string[] ConvertArray(string[] array,int size)
{   
string[] arrayFinal = new string[size];
int length = 3;                                    
int position = 0;

for (int j = 0; j < size; j++)
{
    if (array[j].Length <= length)
    {
        arrayFinal[position] = array[j];
        position++;
    }
}
return arrayFinal;
}
