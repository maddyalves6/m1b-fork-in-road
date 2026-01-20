/*
 * 1) player "reaches" fork in road
 * 2) display text narration describing the fork
 * 3) prompt player with a readline to go either left or right
 * 4a) INVALID INPUT: loop back to (3)
 * 4b) CHOSE LEFT: display text narration describing the town they reached
 * 4c) CHOSE RIGHT: display text narration describing the mountain they reached
 */

Console.WriteLine("Before you is a fork in the road, their destinations obscured. There are two paths, one on the left and one on the right");
Console.Write("\nWhich path do you take? (LEFT/RIGHT): ");

String pInput = Console.ReadLine();

while (pInput.ToLower() != "LEFT" && pInput.ToLower() != "RIGHT")
{
    Console.WriteLine("\nIn your confusion picking a direction, you trip and fall. Reorienting yourself, you look once more at the fork.");
    Console.Write("\nWhich path do you take? (either \"LEFT\" or \"RIGHT\"): ");
    pInput = Console.ReadLine();
}

if (pInput.ToLower() == "LEFT")
{
    Console.WriteLine("\nTrekking down the path, your destination reveals itself as a small bustling town. (END)");
}
else if (pInput.ToLower() == "RIGHT")
{
    Console.WriteLine("\nAs you make it further and further along, on the horizon reveals a large mountain. Your journey seems like it won't get easier any time soon... (END)");
}