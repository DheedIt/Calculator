using System;
using Calculator.Classes;
using Calculator.Menu;
internal class Program
{
    static void Main(string[] args)
    {
        try
        {
            Start();
        }
        catch (Exception exep)
        {
            Console.Clear();
             Console.WriteLine(exep.Message);
        }
    }
    public static void Start()
    {
        {
            URequest request = new URequest();
            Menu menu = new Menu();
            ChooseOperation chooseOperation = new ChooseOperation();
            ShowOperations showOperations = new ShowOperations();
            Menu.toWork = new Menu();
            Console.ForegroundColor = ConsoleColor.Yellow;
            bool END = true;
            while (END)
            {
                Console.WriteLine(Menu.toWork.Show(showOperations.Show()).Calculate(request.EnterN()));
                if (request.contueCheck())
                    END = true;
                else break;

            }
        }
    }
}