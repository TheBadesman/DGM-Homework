using System;

public class Program
{

    public ForLoop forLoop;

    public void Main()
    {

        forLoop = new ForLoop();

        forLoop.squadsRemaning();

    }

}

public class ForLoop
{

    public void squadsRemaning()
    {

        string[] squads= {"Imperial conscripts","Imperial conscripts","Imperial conscripts"};

        for(var i = 2; i < squads.Length; i++)
        {

            squads[i] = "Imperial Guardsmen";
            Console.WriteLine(squads[2]);

        }

    }

}