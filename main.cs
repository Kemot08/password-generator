/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
    string małelitery="qwertyuiopasdfghjklzxcvbnm";
    string wielkielitery="QWERTYUIOPASDFGHJKLZXCVBNM";
    string cyfry="1234567890";
    
    Console.WriteLine("Ile ma być wielkich liter");
    int liczbaWielkich=int.Parse(Console.ReadLine());
    
    Console.WriteLine("Ile ma być małych liter");
    int liczbaMałych=int.Parse(Console.ReadLine());
    
    Console.WriteLine("Ile ma być cyfr");
    int liczbaCyfr=int.Parse(Console.ReadLine());
    
    string hasło="";
    
    Random maszynalosująca=new Random();
    
    //generowanie hasla
    for(int i=0;i<liczbaWielkich;i++)
    {
        char znak=wielkielitery[maszynalosująca.Next(wielkielitery.Length)];
        hasło=hasło.Insert(maszynalosująca.Next(hasło.Length+1),znak.ToString());
    };
    
    for(int i=0;i<liczbaMałych;i++)
    {
        char znak=małelitery[maszynalosująca.Next(małelitery.Length)];
        hasło=hasło.Insert(maszynalosująca.Next(hasło.Length+1),znak.ToString());
    };
    
    for(int i=0;i<liczbaCyfr;i++)
    {
        char znak=cyfry[maszynalosująca.Next(cyfry.Length)];
        hasło=hasło.Insert(maszynalosująca.Next(hasło.Length+1),znak.ToString());
    };
    
    Console.WriteLine("hasło to:"+hasło);
  }
}
