using System;

public class SpitUp //version 0.2.1
{
    public static void Main()
    {
        int i, u;
        string gulpIn;
        i = 1;
        u = 11;
        while ( i < 12 )
        {
            i = i + 1;
            Console.WriteLine("Input a line of text. You have "
                 + u + " lines of text left.") ;
            gulpIn = Console.ReadLine();
            Console.WriteLine("Your text is:" + gulpIn);
            u = u - 1;

        }
    }
}
