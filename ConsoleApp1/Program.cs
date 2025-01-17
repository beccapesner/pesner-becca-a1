//Step 1: Introduce player to setting and weapons
Console.WriteLine("You have entered the castle of the great Rattlesnake Gizzard, be ware! You have heard the great Rattlesnake Gizzard holds many of his treasures deep in this castle. There is an axe to your [left] and a sword to your [right]. Choose one to help you get through this castle OF DOOM!");

string input = Console.ReadLine();
//Step 2: Check player's response, axe or sword
if (input == "left")
{
    Console.WriteLine("You have chosen the axe. A wise choice!");
}
else if (input == "right")
{
    Console.WriteLine("You have chosen the sword. A wise choice!");
}
//Step 3: Introduce player to hallway with a door with a star or a door with a moon
Console.WriteLine("You continue down the hallway wearily holding your weapon. You pass by many portraits of lords and ladies. You approach two doors at the end of the hall, one with a [star] crest and the other with a [moon] crest. Which door do you dare to open?");

string door = Console.ReadLine();
//Step 4: Check player's response, star or moon door
if (door == "star")
{
    Console.WriteLine("You gain the courage to open the door with the star crest. *creaaaaak* There is a skeleton wielding a sword!");
}
    if (door == "star")
    {
    Console.WriteLine("You attack the skeleton.");
    }
else if (door == "moon")
{
    Console.WriteLine("You gain the courage to open the door with the moon crest.*creaaaaak* This room seems to be safe. You may continue through to the next hallway.");
}
//Step 5: 

