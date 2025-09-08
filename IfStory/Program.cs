



string choice = "";
Console.WriteLine("You wake up in a dark room. You don't remember anything about how you got there.");
Console.WriteLine("You see a door to your left and a window to your right.");
Console.WriteLine("What do you do?");
Console.WriteLine("(1) Jump out of the window");
Console.WriteLine("(2) Go through the door");
Console.WriteLine("Answer with the number of your choice.");
choice = Console.ReadLine();

if (choice == "1")
{
    Console.WriteLine("You open the window and jump before looking down");
    Console.WriteLine("Turns out that was a bad idea to not look down, you're now rapidly falling 4 stories towards concrete");
    Console.WriteLine("You broke your neck and died on impact :(");
}

else if (choice == "2")
{
    Console.WriteLine("You see a dim corridor before you");
    Console.WriteLine("The walls are covered in old wallpaper and odd stains");
    Console.WriteLine("At the end of the corridor you see a spiral staircase");
    Console.WriteLine("Do you go up or down?");
    choice = Console.ReadLine();
    choice = choice.ToLower();
    if (choice == "up")
    {
        Console.WriteLine("You see a old man with a gray beard sitting in a rocking chair, to his side lays a shotgun");
        Console.WriteLine("His rocking chair points towards a window opposite of you, he doesn't seem to know you're there");
        Console.WriteLine("Do you (1) Reach for his shotgun, or (2) quietly retreat");
        choice = Console.ReadLine();
        if (choice == "1" || choice == "2")
        {
            Console.WriteLine("The floor squeeks and the old man hears you");
            Console.WriteLine("He swiftly grabs his shotgun and shoots you");
        }

    }
    else if (choice == "down")
    {
        Console.WriteLine("You walk down the seemingly neverending staircase until you reach the bottom");
        Console.WriteLine("You see what seems like a small living room with a couch and tv, straight infront of you is the door to freedom");
        Console.WriteLine("But in the middle of the room stands a pitbull");
        Console.WriteLine("Do you walk around it or  go to pet it");
        choice = Console.ReadLine();
        choice = choice.ToLower();

        if (choice == "walk around")
        {
            Console.WriteLine("The pitbull runs towards you, you get scared and have a heartattack");
        }
        else if (choice == "pet" || choice == "pet it")
        {
            Console.WriteLine("You pet the dog, it smiles and walks you too the door where you escape."); //Ended of here
            Console.WriteLine("You survived!");
            Console.ReadLine();
        }

    }
    else
    {
        Console.WriteLine("Didn't understand, the floor collapses and you fall to your death");
    }

}
else
{
    Console.WriteLine("Didn't understand, you stand still until you die of hunger");
}