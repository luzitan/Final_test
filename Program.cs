using System.Globalization;

string [] array = new string [] {"Hellow", "2",  "world", ":-)"};
int count_elem = 0;

foreach(string str in array){
    if (str.Length <= 3){
    count_elem ++;
    }
}
// Console.WriteLine(count_elem);
string [] newArray = new string [count_elem];
int number = 0;

for (int i = 0; i < array.Length; i++){
    if (array[i].Length <= 3){
        newArray[number] = array[i];
        number++;
    }
}
