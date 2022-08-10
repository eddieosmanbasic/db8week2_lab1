string[] students = new string[] {"Orban Reykjavik", "Bella Moricello", "Kevin Smith", "Eddie Osmanbasic"};
string[] hometown = new string[] {"Oslo", "Venice", "Green Bay", "Gross Gerau"};
string[] favoritefood = new string[] {"Sardines", "Pasta", "Cheese Curds", "Doner Kebab"};

bool continueFlag = true;
do
{
    Console.WriteLine("Welcome! Which student would you like to learn about? Enter a number 1-4.");
    int selection = int.Parse(Console.ReadLine());
    bool selectionFlag = false;
    do
    {
        if (selection <= 0)
        {
            Console.WriteLine("That is not a valid entry, please enter a number from 1-4.");
            break;
        }
        else if (selection > students.Length)
        {
            Console.WriteLine("That is not a valid entry, please enter a number from 1-4.");
            break;
        }
        else
        {
            selectionFlag = true;
        }
    } while (!selectionFlag);
    selection = selection - 1;
    for (int i = 0; i < students.Length; i++)
    {
        if (selection == i)
        {
            Console.WriteLine($"You are viewing {students[selection]}'s information.");
            Console.WriteLine("Enter Hometown or Favorite Food");

            bool categoryFlag = false;
            do
            {
                string category = Console.ReadLine();
                string categoryInput = category.Replace(" ", "").ToLower();
                if (categoryInput != "hometown" && categoryInput != "favoritefood")
                {
                    categoryFlag = false;
                    Console.WriteLine("Your input is not valid. Please enter Hometown or Favorite Food.");
                    
                }
                else if (categoryInput == "hometown")
                {
                    Console.WriteLine($"{students[i]}\'s hometown is {hometown[selection]}.");
                    categoryFlag = true;
                }
                else if (categoryInput == "favoritefood")
                {
                    Console.WriteLine($"{students[i]}\'s favorite food is {favoritefood[selection]}.");
                    categoryFlag = true;
                }

            } while (!categoryFlag);
        }
        else
        {
            
        }
    }
    while (selectionFlag)
    {
        Console.WriteLine("Would you like to learn about another student? Please enter y or n.");
        string anotherOne = Console.ReadLine();
        if (anotherOne != "y" && anotherOne != "n")
        {
            selectionFlag = true;
            Console.WriteLine("That was not a valid entry, please try again.");
        }
        else if (anotherOne == "n")
        {
            continueFlag = false;
            selectionFlag = false;
        }
        else if (anotherOne == "y")
        {
            continueFlag = true;
            selectionFlag = false;
        }
    }
} while (continueFlag);