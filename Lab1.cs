using System;
					
public class Program
{

	public Weapon autoCannon;

	public void Main()
	{

		autoCannon = new Weapon();

		Console.WriteLine(autoCannon.weaponName + " has a ammoCount of " + autoCannon.ammoCount);

	}
}

public class Weapon
{

	public int ammoCount = 10;
	public string weaponName = "Auto Cannon";
	public float firePower = 15f;


}

