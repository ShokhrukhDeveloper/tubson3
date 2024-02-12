
System.Console.WriteLine("Son kiritinng: ");
string userInput = System.Console.ReadLine();
int son = Convert.ToInt32(userInput);
int i = son;
int tubson=0;

while (true)
{   
    if (tubson>=3)
    {
        break;
    }

    bool tub = true;
    for (int j = 2; j <= Math.Sqrt(i); j++)
      {
        if (i % j == 0)
        {
            tub = false;
            break;
        }
      }
      if (tub)
      {
        System.Console.WriteLine(i);
        tubson++;
      }
      i++;
}
      

