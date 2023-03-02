// Опросник. Пользователь выбирает 1 из вариантов ответов. В конце программа подсчитывает количество верных.

// Start();
// void Start()
// {
// while(true)
// {
// System.Console.WriteLine("1) Question #1:");
// System.Console.WriteLine("2) Question #2:");
// System.Console.WriteLine("3) Question #3:");
// System.Console.WriteLine("4) Question #4:");

// System.Console.WriteLine("0) End:");


// int NumTask = EnterNumber("task");

// switch (NumTask)
// {
//     case 0: return; break;

//     default:


//     case 1:

//     case 2:

//     case 3:
//     Console.Clear();
// }
// }
// }


string[,] array =
{
    {"Which of the following programs are antivirus?", "MS Word", "Dr.Web", "Chrome", "PDFreader", "Dr.Web"},
    {"What type of graphics does not exist?", "Raster", "Vector", "Cloud", "Three-dimensional", "Cloud"},
    {"When did the term information technology in its modern meaning appear?", "In 1893", "In 1990", "In 1958", "In 1902", "In 1958"},
    {"In what year was IBM released the first hard disk in history?", "In 1956", "In 1958", "In 1955", "In 1957", "In 1956"},
    {"Which search engine was the most popular in 2011?", "Yahoo!", "Google", "Bing", "Yandex", "Google"},
    {"Is the country the leader in the number of supercomputers?", "China", "USA", "Japan", "Russia", "China"},
    {"Which Internet browser doesn't exist?", "MS PowerPoint", "Opera", "Google Chrome", "Internet Explorer", "MS PowerPoint"},
    {"Which of the keyboard keys belong to the functional group?", "F1-F12", "CTRL, ALT, Shift", "Windows","Tab",  "F1-F12"},
    {"What data transfer rate can broadband communication over power lines provide?", "200 MBit/s", "1 MBit/s", "100 MBit/s", "10 MBit/s", "100 MBit/s"},
};

int count = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    System.Console.WriteLine(array[i, 0]);
    System.Console.WriteLine();
    for (int j = 1; j < array.GetLength(1) - 1; j++)
    {
        System.Console.WriteLine($"{j}) {array[i, j]};");

    }
    int answer = EnterAnswer("Enter answer: ");
    if (Comparesment(answer, i)) count++;
    System.Console.WriteLine();
    System.Console.WriteLine();
    
}

System.Console.WriteLine($"Quantity of correct answers = {count}");


int EnterAnswer(string text) // функция для ввода целочисленного значения пользователем
{
    Console.Write($"{text}: ");
    int result;
    while (true)
    { 
        string enterNumber = Console.ReadLine();
        if (int.TryParse(enterNumber, out result) && result <= 4 && result > 0)
            return result;

        System.Console.WriteLine($"Error. {text}");
    }
    return 0;
}

bool Comparesment (int value, int index)
{
    return array[index, value] == array [index, array.GetLength(1)-1];
}