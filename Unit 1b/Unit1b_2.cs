using System;
					
public class Program
{

    public GameStates gameStates;

	public void Main()
	{
		
        gameStates = new GameStates();

		gameStates.currentStates = GameStates.States.Ending;
		
		gameStates.CheckState();

	}
}

public class GameStates
{

	public enum States
	{
		Starting,
		Playing,
		Ending
	}
	
	public States currentStates = States.Playing;
	
	public void CheckState()
	{
	
		switch(currentStates)
        {

            case States.Starting:
                Console.WriteLine("Starting");
                break;
			case States.Playing:
				Console.WriteLine("Playing");
				break;
			case States.Ending:
				Console.WriteLine("Ending");
				break;
            

        }
		
	}
	
}