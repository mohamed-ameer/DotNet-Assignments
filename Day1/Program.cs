namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region ask username
            Console.WriteLine("First Assignment");
            string firstName = default;
            string lastName = default;
            Console.Write("please write your first-name: ");
            firstName = Console.ReadLine();
            Console.Write("please write your last-name: ");
            lastName = Console.ReadLine();

            Console.WriteLine($"your name is \"{firstName} {lastName}\" and it contains {firstName.Length + lastName.Length} charachter");
            #endregion
            Console.WriteLine("=====================================================================");
            #region simple calulator
            Console.WriteLine("Second Assignment");
            //prepare inputs variables
            float first_operand = default;
            float second_operand = default;
            float result = default;
            char exit = 'n';
            string operation = default;
            do
            {
                //read inputs from user
                getfirstnumber:
                Console.Write("enter the first number: ");
                //first_operand = float.Parse(Console.ReadLine());
                if (!float.TryParse(Console.ReadLine(), out  first_operand)) {
                    Console.WriteLine("you must enter number");
                    goto getfirstnumber;
                };
                getsecondnumber:
                Console.Write("enter the second number: ");
                if (!float.TryParse(Console.ReadLine(), out second_operand))
                {
                    Console.WriteLine("you must enter number");
                    goto getsecondnumber;
                };
                Console.WriteLine(@"choose operator :
type 'sum' to do + operation
type 'sub' to do - operation
type 'mult' to do * operation
type 'div' to do / operation");
            retry:
                operation = Console.ReadLine();
                switch (operation)
                {
                    case "sum":
                        result = first_operand + second_operand;
                        Console.WriteLine($"{first_operand} + {second_operand} = {result}");
                        break;
                    case "sub":
                        result = first_operand - second_operand;
                        Console.WriteLine($"{first_operand} - {second_operand} = {result}");
                        break;
                    case "mult":
                        result = first_operand * second_operand;
                        Console.WriteLine($"{first_operand} * {second_operand} = {result}");
                        break;
                    case "div":
                        result = first_operand / second_operand;
                        Console.WriteLine($"{first_operand} / {second_operand} = {result}");
                        break;
                    default:
                        Console.WriteLine(@"there is no operation with this name
type 'sum' to do + operation
type 'sub' to do - operation
type 'mult' to do * operation
type 'div' to do / operation");
                        goto retry;
                        break;
                }
                Console.Write("do you want to exit (y/n)?: ");
                exit = char.Parse( Console.ReadLine());

            }while(exit == 'n');


            #endregion

            
        }
    }
}
