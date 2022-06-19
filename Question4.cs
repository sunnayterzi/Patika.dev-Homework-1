// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir cümle giriniz");
String n =Console.ReadLine();
string [] arr = n.Split(" ");
string.Join("",arr);
Console.WriteLine(arr.Length+" adet kelime bulunmaktadır");

n=n.Replace(" ","");
Console.WriteLine("Toplam harf sayısı "+ n.Length);
