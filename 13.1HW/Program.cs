using System;

class Program
{
    public string[] tasks = new string[100];
    public bool[] isCompleted = new bool[100];
    public int taskCount = 0;
    public string choice;
    public void Main()
    {
       
        while (true) 
        {
            Console.WriteLine("Список справ");
            Console.WriteLine("1. Додати справу");
            Console.WriteLine("2. Вивести всі справи");
            Console.WriteLine("3. Відмітити справу як виконану");
            Console.WriteLine("4. Видалити справу");
            Console.WriteLine("Оберіть опцію(1-4): ");
            choice = Console.ReadLine();

          
        }
    }
    public void AddTask()
    {
        Console.Write("Введіть назву справи: ");
        string task = Console.ReadLine();

        if ( taskCount >= tasks.Length)
        {
            Console.WriteLine("Список заповнений. Додати нову справу неможливо");
            return;
        }
        else if(string.IsNullOrEmpty(task))
        {
            Console.WriteLine("Назва справи не може бути пустою");
            return;
        }
        tasks[taskCount] = task;
        isCompleted[taskCount] = false;
        taskCount++;
        Console.WriteLine("Справу додано");
    }
    
}
