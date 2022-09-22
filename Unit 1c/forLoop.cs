using System;

public class Program
{

    public void Main()
    {

    	string[] weapons = {"Bolter Pistol", "Bolter Pistol", "Bolter Pistol", "Bolter Pistol", "Bolter Pistol"};

		
		for(var i = 3; i < weapons.Length; i++)
		{
			
			weapons[i] = "Heavy Bolter";
			
		}
		
		foreach(var weapon in weapons)
		{
		
			Console.WriteLine("Your avalible weapons are " + weapon + ".");
			
		}

    }

}