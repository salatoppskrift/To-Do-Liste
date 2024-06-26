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
            Console.WriteLine("En to-do liste! What to do, what to do...");
            Console.WriteLine("a) ...\nb) ...\nc) ...\n\nLegg til valg!");

            List<Task> tasks = new List<Task>();

            addTask();

            var input = Console.ReadKey().KeyChar;



            if (input == 'a')
            {
                Console.Clear();
                Console.WriteLine("Legg til en oppgave du skal gjøre!");

                tasks.Add(addTask());
            } else if(input == 'b')
            {
                Console.Clear();
                Console.WriteLine("Legg til en oppgave du skal gjøre!");

                string nextInput = Console.ReadLine();

            } else if(input == 'c')
            {
                Console.Clear();
                Console.WriteLine("Legg til en oppgave du skal gjøre!");

                string nextInput = Console.ReadLine();
            } else
            {
                Console.Clear();
                Console.WriteLine("Det der gav *null* mening.");
            }






            Console.ReadLine();
        }

        static Task addTask()
        {
            string nameInput = Console.ReadLine();
            string descriptionInput = Console.ReadLine();

            Console.WriteLine("Oppgavenavn: " + nameInput);
            Console.WriteLine("Beskrivelse: " + descriptionInput);
            
            return new Task(nameInput, descriptionInput);
        }
    }
}
