using System;

public class Program
{

    public void Main()
    {

        DoMath(10);
		DoMath(20);

    }

    public void DoMath (int value)
    {
        var number = value + 2;
        
        Console.WriteLine(number);

    }

}
