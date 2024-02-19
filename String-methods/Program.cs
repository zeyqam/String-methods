//Parametr olaraq string qebul eden metod yazmalisiz. Hemin metod qebul etdiyi stringi tersine formada ekranda gostersin. (Cavid gelirse , ekranda divaC gorsensin).

//void ReverseString(string input)
//{
//    char[] charArray = input.ToCharArray();
//    Array.Reverse(charArray);
//    string reversedString=new string(charArray);
//    Console.WriteLine("Reversed string: " + reversedString);
//}
//Console.WriteLine("Please enter string: ");
//string input=Console.ReadLine();
//ReverseString(input);
//int[] arr = { 1, 2, 34, 5 };
//arr[1] = 100;
//foreach (var item in arr)
//{
//    Console.WriteLine(item);
//}
//List<int> datas = new() { 1,2,3,4,5 };
//datas.Add(100);
//string name = "Test";
//string newName = name + "salam";
//using System.Text;

//string name = "test";
//name = "salam";
//StringBuilder str = new StringBuilder("Salam");
//str.Append("sagol");
//int age = 100;
//Console.WriteLine(age.GetType());
//Console.WriteLine(age.ToString());
//string surname = "test";
//Console.WriteLine(surname.Length);
//string str = "salam";
//string str2 = " necesiz?";
//string result=string.Concat(str, str2);
//Console.WriteLine(result);
//string result = "";
//string result2=string.Empty;

//var result3 = result2 + "salam";

string text = "   ";
if (string.IsNullOrEmpty(text))
{
    Console.WriteLine("empty");
}
else
{
    Console.WriteLine("fill");
}