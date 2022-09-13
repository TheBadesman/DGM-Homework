using System;

public class Program
{
	public Operations myOperations;
	

    public void Main()
    {
		
		myOperations = new Operations();

        myOperations.DoMath(10, 15);
		myOperations.DoMath(20, 19120);
        myOperations.compare(19, 7);
		myOperations.CheckPassword("01817");
		myOperations.CheckPassword("01812");

    }

}


public class Operations
{

	    public void DoMath (int value, int value2)
    {
        var number = value + value2;
        
        Console.WriteLine(number);

    }

    public void compare (int value, int value2)
    {

        if(value > value2)
        {
            Console.WriteLine("Value 1 is greater");
        }
        else
        {

            Console.WriteLine("value 1 is not greater");

        }

    }
	
	public void CheckPassword(string password)
	{
	
		if(password == "01812")
		{
		
			Console.WriteLine("Welcome Dave");
			
		}
		else
		{
		
			Console.WriteLine("I can't do that Dave");
			
		}
		
		
	}
	
}