using System.Globalization;

string [] array = new string [] {"Hellow",  "world", ":-)mhkh"};
int count_elem = 0;

foreach(string str in array){
    if (str.Length <= 3){
    count_elem ++;
    }
}
// Console.WriteLine(count_elem);
if (count_elem == 0){
    Console.WriteLine("[]");
} else{
    string [] newArray = new string [count_elem];
    int number = 0;

    for (int i = 0; i < array.Length; i++){
        if (array[i].Length <= 3){
            newArray[number] = array[i];
            number++;
        }
    }

    foreach(string str in newArray){
        if (str == newArray[count_elem-1]){
            Console.Write(str);
        } else{
            Console.Write(str + ", ");
        }
    }
}