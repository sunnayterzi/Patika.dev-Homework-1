﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bir sayı giriniz");
int n = Convert.ToInt32(Console.ReadLine());

for(int i = 0; i<=n;i++){
    if (i%2==0) Console.WriteLine(i);
}
