// See https://aka.ms/new-console-template for more information
Console.WriteLine("program for Coupan Number!");
var charcheck = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
var stringChars = new char[6];
var random = new Random();
Console.Write("Hi Welcome to Coupan generation system \n Please enter how many number of tickets you want to generate.");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 0) 
{
    Console.WriteLine("You Have entered invalid number ");

}
while (number > 0) 
{
    for (int i = 0; i < stringChars.Length; i++)
    {
        stringChars[i] = charcheck[random.Next(charcheck.Length)];
    }
    
    var coupanString = new String(stringChars);
    Console.WriteLine("Coupan number: "+coupanString);
    number -= 1;
}
Console.ReadKey();