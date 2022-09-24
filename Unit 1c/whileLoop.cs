using System;

public class Program
{

    public void Main()
    {

    int ammo = 10;
    while(ammo > 0)
    {

        Console.WriteLine("You still have ammo " + ammo + " left.");
        ammo--;

    }
    
    int squad3 = 5;
    do
    {
        
        Console.WriteLine("Squad 3 has " + squad3 + " remaining");
        squad3--;

    }
    while(squad3 != 0);
	
	}

}