// See https://aka.ms/new-console-template for more information
Console.WriteLine("What do you want to do?");
Console.WriteLine("1. Read file\n2. Write file");

/*while (true)
{
    string input = Console.ReadLine();
    switch (input)
    {
        case "1":
            // Read File
            Console.WriteLine("Type the name of the file:");
            string fileName = Console.ReadLine();
            //function to read that file. Takes fileName as argument
            bool success = ReadFile(fileName);
            if (!success)
            {
                Console.WriteLine("File does not exist");
                break;
            }
            else
            {
                //Show file in console
                break;
            }
        case "2":
            break;
        default: 
            Console.WriteLine("Incorrect input");
            break;
    }
}

bool ReadFile(string name)
{
    if (File.Exists(name))
    {
        //read the file into a dictionary
        return true;
    }
    else return false;
}*/