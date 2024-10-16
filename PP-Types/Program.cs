string[] names = {
    "Mickey Mouse", "Minnie Mouse", "Donald Duck", "Goofy", "Pluto", "Daisy Duck", "Simba", "Nala", 
    "Timon", "Pumbaa", "Mufasa", "Ariel", "Flounder", "Sebastian", "Ursula", "Belle", "Beast", "Gaston", 
    "Cinderella", "Prince Charming", "Aurora", "Maleficent", "Rapunzel", "Flynn Rider", "Elsa", "Anna", 
    "Olaf", "Moana", "Maui", "Hercules"
};


void PrintGroups(string[] t, int perLine)
{
    int count = 0;
    foreach (var name in t)
    {
        if (name != t[^1])
        {
            if (count < perLine)
            {
                Console.Write(name + ", ");
                count++;

            }
            else if (count == perLine)
            {
                Console.Write($"\n{name}, ");
                count = 1;
            }
        }
        else
        {
            Console.Write(name + ". ");
        }

    }

}


void PrintColumns(string[] t, int perLine, int width)
{

    int count = 0;

    foreach(var name in t)
    {
        if (count < perLine)
        {
            count++;
            if (name.Length <= width)
            {
                Console.Write(name + new string(' ', (width - name.Length)) + "|");
            }
            else
            {
                Console.Write(name[..width] + "|");
            }
        }

        else if (count == perLine)
        {
            count = 1;
            if (name.Length <= width)
            {
                Console.Write($"\n{name}" + new string(' ', (width - name.Length)) +"|");
            }
            else
            {
                Console.Write($"\n{name[..width]}" + "|");
            }

        }
    }

}


Console.WriteLine("\nPrintGroups(names, 3):\n");
PrintGroups(names, 3);


Console.WriteLine("\nPrintGroups(names, 5):\n");
PrintGroups(names, 5);


Console.WriteLine("\nPrintGroups(names, 7):\n");
PrintGroups(names, 7);


Console.WriteLine("\nPrintGroups(names, 40):\n");
PrintGroups(names, 40);


Console.WriteLine("\n\nPrintColumns(names, 4, 17):\n");
PrintColumns(names, 4, 17);


Console.WriteLine("\n\nPrintColumns(names, 5, 15):\n");
PrintColumns(names, 5, 15);


Console.WriteLine("\n\nPrintColumns(names, 7, 10):\n");
PrintColumns(names, 7, 10);
