// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir sayı giriniz");
int n = Convert.ToInt32(Console.ReadLine());


Console.WriteLine( n +" adet kelime giriniz");
string [] arr = new string[n];
for(int i = 0; i<arr.Length;i++){
    arr[i]=Console.ReadLine();
}
Array.Reverse(arr);
Console.WriteLine("Kelimelerin tersten sıralanışı");
foreach(string i in arr){
    Console.WriteLine(i);
}
