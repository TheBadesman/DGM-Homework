using System;
					
public class Program
{

	public WeaponAC autoCannon;

	public WeaponOperations myDescription;

	public void Main()
	{

		myDescription = new WeaponOperations();

		autoCannon = new WeaponAC();

		autoCannon.ammoCount++;

		Console.WriteLine(autoCannon.weaponName + " has a Ammo Count of " + autoCannon.ammoCount);

		myDescription.WeaponDes(true,"A heavy support weapon normally used by a team of guardsmen, the Auto Cannon useds heavy shells instead of energy cells to punch through both infantry and light to medium-light vehicles");

	}

}



public class WeaponAC
{

	public int ammoCount = 10;
	public string weaponName = "Auto Cannon";
	public float firePower = 15f;

}

//The class system and the variables assigned to each

public class Guardsmen
{

	public string loadoutHW = "Heavy Weapons";
	public int HealthHW = 5;
	public int AccuracyHW = 60;
	public float HWPerfered = 1.5f;

}

public class WeaponOperations
{

	public void WeaponDes (bool owned,string des)
	{

		if(owned == true)
		{
	
			Console.WriteLine(des);

		}
		else
		{
			Console.WriteLine("Your squad does not currently have this weapon avalible");
		}

	}

}
