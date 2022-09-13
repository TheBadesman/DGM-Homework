using System;

public class Program
{

    public void Main()
    {

        DoMath(10, 15);
		DoMath(20, 19120);

    }

    public void DoMath (int value1, int value2)
    {
        var number = value1 + value2;
        
        Console.WriteLine(number);

    }

}
