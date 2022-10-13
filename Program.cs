
Console.WriteLine("Input data:");
var data1= Console.ReadLine();
var data2 = Console.ReadLine();
var data3 = int.TryParse(data1, out int data);
var data5 = int.TryParse(data2, out int data4);
int b = 0;
var Od = data4;
var Do =data;
if (data<=data4)
{
    Od=data;
    Do=data4;
}
if (data3 && data5)
{
    for (int i =Od; i <= Do; i++)
    {
        b= b+i;
    }
    Console.WriteLine(b);
}
else
    Console.WriteLine("Incorrect input");
