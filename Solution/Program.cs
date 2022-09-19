// Из имеющегося массива строк сформировать массив из строк, 
// длина которых меньше, либо равна 3 символа.

void PrintArray(string[] array)
{
    Console.Write("[");
    for(int index = 0; index < array.Length; index++)
    {
        if(index > 0) Console.Write(", ");
        Console.Write(array[index]);
        
    }
    Console.WriteLine("]");
}

string[] FindElements(string[] strArr, string[] newStrArr)
{
    int count = 0;
    for (int i = 0; i < strArr.Length; i++)
    {
        if (strArr[i].Length <= 3)
        {
            newStrArr[count] = strArr[i];
            count++;
        }
    }
      
    return newStrArr;
}


string[] strArr = new string[] {"si", "Tokyo", "+/-", "3,15", "("};
PrintArray(strArr);
string[] newStrArr = new string[strArr.Length];
FindElements(strArr, newStrArr);
newStrArr = string.Join(",", newStrArr).Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
PrintArray(newStrArr);


string[] strArr1 = new string[] {"si456", "Tokyo", "+/-12", "3,15", "zxfg("};
PrintArray(strArr1);
string[] newStrArr1 = new string[strArr1.Length];
FindElements(strArr1, newStrArr1);
newStrArr1 = string.Join(",", newStrArr1).Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
PrintArray(newStrArr1);