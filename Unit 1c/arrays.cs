using System;

public class Program
{

    public void Main()
    {

    	string[] weapons = {"Las gun", "Hell Gun", "Bolter Pistol"};

		string[] weapons = {"Las gun", "Hell Gun", "Bolter Pistol", "Flamer", "Heavy Stubber"};
		
		
		foreach(var weapon in weapons)
		{
		
			Console.WriteLine("Your avalible weapons are " + weapon + ".");
			
		}
		
		Console.WriteLine(weapons[2]);
    
    }

}