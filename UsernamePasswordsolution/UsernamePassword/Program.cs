using System;
public class program
{
    public static void Main()
    {
        string username, password;
        int ctr = 0;

        do
        {
            Console.Write("Enter the username: ");
            username = Console.ReadLine();

            Console.Write("Enter ther password: ");
            password = Console.ReadLine();

            if (username != "Admin" || password != "admin")
                ctr++;
            else
                ctr = 1;

        }
        while ((username != "Admin" || password != "admin") && (ctr != 3));

        if (ctr == 3)
            Console.Write("Sorry you have already tried 3 times");
        else
            Console.Write("Welcome...");
    }
}