using System;
using System.Reflection;

class Program
{
    static string[] tasks = new string[100];
    static bool[] isCompleted = new bool[100];
    static int taskCount = 0;
    public static void Main()
    {

        while (true)
        {
            Console.WriteLine("Список справ");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Вивести всі справи");
            Console.WriteLine("3. Відмітити справу як виконану");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("Оберіть опцію(1-4): ");
            string choice = Console.ReadLine();

            switch(choice)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    DisplayTasks();
                    break;
                case "3":
                    MarkTaskCompleted();
                    break;
            }
        }
    }
    static void AddTask()
    {
        Console.Write("Введіть назву справи: ");
        string task = Console.ReadLine();

        if (taskCount >= tasks.Length)
        {
            Console.WriteLine("Список заповнений. Додати нову справу неможливо");
            return;
        }
        else if (string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Назва справи не може бути пустою");
            return;
        }
        tasks[taskCount] = task;
        isCompleted[taskCount] = false;
        taskCount++;
        Console.WriteLine("Справу додано");
    }
    static void DisplayTasks()
    {
        Console.WriteLine("Ваші справи:");
        if (taskCount == 0)
        {
            Console.WriteLine("Список ваших справ порожній");
            return;
        }
        for (int i = 0; i < taskCount; i++)
        {
            string status = isCompleted[i] ? "Виконано" : "Невиконано";
            Console.WriteLine($"{i + 1}. {tasks[i]} {status}");
        }
    }
    static void MarkTaskCompleted()
    {
        Console.Write("Введіть номер справи для відмітки як виконаної: ");
        string input = Console.ReadLine();
        int index;

        if (taskCount == 0)
        {
            Console.WriteLine("Список справ порожній.");
            return;
        }
        else if (!int.TryParse(input, out index))
        {
            Console.WriteLine("Введіть коректне число");
            return;
        }
        else if (index < 1 || index > taskCount)
        {
            Console.WriteLine("Номер справи виходить за межі списку");
            return;
        }
        isCompleted[index - 1] = true;
        Console.WriteLine("Справу відмічено як виконану");
    }
}
