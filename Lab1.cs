using System;
					
public class Program
{

	public Weapon autoCannon;

	public int owned = 1;

	public void Main()
	{

		autoCannon = new Weapon();

		autoCannon.ammoCount++;

		Console.WriteLine(autoCannon.weaponName + " has a ammoCount of " + autoCannon.ammoCount);

		if(owned == 1)
		{
		
			Console.WriteLine(autoCannon.description);

		}

	}
}



public class Weapon
{

	public int ammoCount = 10;
	public string weaponName = "Auto Cannon";
	public float firePower = 15f;
	public string description = "A heavy support weapon normally used by a team of guardsmen, the Auto Cannon useds heavy shells instead of energy cells to punch through both infantry and light to medium-light vehicles";


}

//The class system and the variables assigned to each

public class Guardsmen
{

	public string loadoutHW = "Heavy Weapons";
	public int HealthHW = 5;
	public int AccuracyHW = 60;
	public float HWPerfered = 1.5f;

}

