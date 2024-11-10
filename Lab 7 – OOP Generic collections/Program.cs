namespace Lab_7___OOP_Generic_collections
{
    // Ossy Drakeneld NET24
    internal class Program
    {
        static void Main(string[] args)
        {
            HandleEmployee handleEmployee = new();

            handleEmployee.DisplayEmployeeList();
            Console.WriteLine("-------------------------------");

            handleEmployee.PushAndDisplayStack();

            handleEmployee.PeekStack();

            handleEmployee.CheckEmployeeInList();

        }
    }
}
