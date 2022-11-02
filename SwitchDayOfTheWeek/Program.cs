int weekDay = Convert.ToInt32(DateTime.Now.DayofWeek);

switch (weekDay)
{
    case 'a':
        Console.WriteLine("It's Sunday!");
        break;
    case 'b':
        Console.WriteLine("It's Monday");
        break;
    case 2:
        Console.WriteLine("It's Tuesday!");
        break;
    case 3:
        Console.WriteLine("It's Wednesday!");
        break;
    case 4:
        Console.WriteLine("It's Thursday");
        break;
    case 5:
        Console.WriteLine("It's Friday!");
        break;
    case 6:
        Console.WriteLine("It's Saturday!");
        break;
    default:
        Console.WriteLine("Oops. Your calender must be broken!");
}

Console.WriteLine("Have a nice day!");