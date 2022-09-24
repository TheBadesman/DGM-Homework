using System;

public class Program
{

        public FireSupport fireSupport;

    public void Main()
    {

        //the call of the loop, and then getting it to run
        fireSupport = new FireSupport();

        fireSupport.artillery();

    }

}

public class FireSupport
{

    // the main while loop
    public void artillery()
    {

        int shells = 1;

        while(shells <= 13)
        {

            Console.WriteLine(shells + " shells fired");
            shells++;

            if(shells == 14)
            {

                //I would add a var here to do time, but I don't know how to get it to count down right
                Console.WriteLine("All shells have fire, Batterys will be back on line in 3 minutes");

            }

        }

    }

}