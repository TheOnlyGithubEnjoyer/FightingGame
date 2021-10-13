using System;

int HP1 = 100;

int HP2 = 100;

Console.WriteLine("Player 1. Write your name");
string name1;
name1 = Console.ReadLine();

Console.WriteLine("Player 2. Write your name");
string name2;
name2 = Console.ReadLine();

Console.WriteLine(name1 + "'s Health = " + HP1);
Console.WriteLine(name2 + "'s Health = " + HP2);
Console.WriteLine("PRESS ENTER TO KNOCK HIM OUT!");

Console.ReadLine();

while (HP1 > 0 && HP2 > 0)
{

   Random generator = new Random();

    int damage1 = generator.Next(5,35);

    int damage2 = generator.Next(5,35);

    HP1 = HP1-damage2;
    HP2 = HP2-damage1;

    Console.WriteLine(name1 + "'s Health: " + HP1 + "! " + name2 + " Did " + damage2 + " on yoU");
    Console.WriteLine(name2 + "'s Health: " + HP2 + "! " + name1 + " Did " + damage1 + " on you!");
    Console.WriteLine("PRESS ENTER TO ATTACK");
    

    Console.ReadLine();

}

if (HP1 < 0 && HP2 < 0)
{
    Console.WriteLine("Ohhh my! It's a draw. What are the chances.");
}

else if(HP1 <= 0)
{
    Console.WriteLine(name2 + " has beaten " + name1 + " easily! " + "with only " + HP2 + "HP left");
}

else if(HP2 <= 0)
{
    Console.WriteLine(name1 + " has beaten " + name2 + " like a baby " + "with only " + HP1 + "HP left");
}

Console.ReadLine();



