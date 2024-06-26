namespace ppMAndreasOgMartin
{
    /* Lag en to-do app! Du skal kunne legge til oppgaver,
     * slette dem og gå inn på en task for å se beskrivelse eller
     * flere detaljer
    */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Task> tasks = new List<Task>();
            Console.WriteLine("En to-do liste! What to do, what to do...");

            while (true)
            {
                Console.Clear();
                PrintTasks(tasks);
                Console.WriteLine("a) Legg til oppgave\nb) Se oppgave beskrivelse \nc) Slett en oppgave\n\nLegg til valg!");

                var input = Console.ReadKey().KeyChar;

                if (Char.IsDigit(input))
                {
                    int selection = LessThanZeroOrBiggerThanTasks(input, tasks);
                    if (selection == -1)
                    {
                        Console.WriteLine("Invalid task");
                    }
                    else
                    {
                        tasks[selection].ToggleComplete();
                    }
                    continue;
                }

                if (input == 'a')
                {
                    Console.Clear();
                    Console.WriteLine("Legg til en oppgave du skal gjøre!");

                    tasks.Add(addTask());
                }
                else if (input == 'b')
                {
                    Console.Clear();
                    PrintTasks(tasks);
                    Console.WriteLine("Se en oppgaves beskrivelse");
                    int selection = LessThanZeroOrBiggerThanTasks(Console.ReadKey().KeyChar, tasks);
                    if (selection == -1)
                    {
                        Console.WriteLine("Invalid task");
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine(tasks[selection].GetDescription());
                    }

                    Console.ReadLine();
                }
                else if (input == 'c')
                {
                    Console.Clear();
                    PrintTasks(tasks);
                    Console.WriteLine("Slett oppgave");
                    int selection = LessThanZeroOrBiggerThanTasks(Console.ReadKey().KeyChar, tasks);
                    if (selection == -1)
                    {
                        Console.WriteLine("Invalid task");
                    }
                    else
                    {
                        Console.Clear();
                        string name = tasks[selection].GetName();
                        tasks.RemoveAt(selection);
                        Console.WriteLine($"Slettet oppgave \"{name}\"");
                    }

                    Console.ReadLine();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Det der gav *null* mening.");
                }
            }
        }

        static void PrintTasks(List<Task> tasks)
        {
            for (int i = 0; i < tasks.Count(); i++)
            {
                Console.WriteLine(i + ". [" + (tasks[i].GetCompleted() ? "x" : " ") + "] " + tasks[i].GetName());
            }
        }

        static int LessThanZeroOrBiggerThanTasks(char input, List<Task> tasks)
        {
            int selection = input - '0';
            if (selection < 0 || selection >= tasks.Count())
            {
                return -1;
            }

            return selection;
        }

        static Task addTask()
        {
            Console.WriteLine("Oppgave navn:");
            string nameInput = Console.ReadLine();
            Console.WriteLine("Oppgave beskrivelse:");
            string descriptionInput = Console.ReadLine();

            Console.WriteLine("Oppgavenavn: " + nameInput);
            Console.WriteLine("Beskrivelse: " + descriptionInput);

            return new Task(nameInput, descriptionInput);
        }
    }
}
