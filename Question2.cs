// See https://aka.ms/new-console-template for more information
Console.WriteLine("İki adet sayı giriniz");
int n = Convert.ToInt32(Console.ReadLine());
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine( n +" adet sayı giriniz");
int [] arr = new int[n];
for(int i = 0; i<arr.Length;i++){
    arr[i]=Convert.ToInt16(Console.ReadLine());
}
Console.WriteLine("Tam bölünen sayılar");
foreach(int i in arr){
    if (i%m==0) Console.WriteLine(i);
}
