using System;
using System.Drawing;

namespace SkalProj_Datastrukturer_Minne
{
    class Program
    {
        /// <summary>
        /// The main method, vill handle the menues for the program
        /// </summary>
        /// <param name="args"></param>

        static void Main()
        {
            while (true)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 2, 3 ,4, 0) of your choice"
                    + "\n1. Examine a List"
                    + "\n2. Examine a Queue"
                    + "\n3. Examine a Stack"
                    + "\n4. CheckParenthesis"
                    + "\n5. RecursiveTests"
                    + "\n6. IterationTests"
                    + "\n0. Exit the application");
                char input = ' '; //Creates the character input to be used with the switch-case below.
                try
                {
                    input = Console.ReadLine()![0]; //Tries to set input to the first char in an input line
                }
                catch (IndexOutOfRangeException) //If the input line is empty, we ask the users for some input.
                {
                    Console.Clear();
                    Console.WriteLine("Please enter some input!");
                }
                switch (input)
                {
                    case '1':
                        ExamineList();
                        break;
                    case '2':
                        ExamineQueue();
                        break;
                    case '3':
                        ExamineStack();
                        break;
                    case '4':
                        CheckParanthesis();
                        break;
                    case '5':
                        RecursiveTest();
                        break;
                    case '6':
                        IterationTest();
                        break;
                    /*
                     * Extend the menu to include the recursive 
                     * and iterative exercises.
                     */
                    case '0':
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter some valid input (0, 1, 2, 3, 4)");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure List
        /// </summary>
        static void ExamineList()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch statement with cases '+' and '-'
             * '+': Add the rest of the input to the list (The user could write +Adam and "Adam" would be added to the list)
             * '-': Remove the rest of the input from the list (The user could write -Adam and "Adam" would be removed from the list)
             * In both cases, look at the count and capacity of the list
             * As a default case, tell them to use only + or -
             * Below you can see some inspirational code to begin working.
            */

            List<string> theList = new List<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Please navigate through the menu by inputting the characters \n(+, -, 0) of your choice, input something right after + or -. Ex +Hello"
                    + "\n+. Add to the list"
                    + "\n-. Remove from the list"
                    + "\n0. Return");
                string ?input = Console.ReadLine();
                char nav = string.IsNullOrEmpty(input) ? ' ' : input[0];
                string value = string.IsNullOrEmpty(input) ? " " : input.Substring(1);

                switch (nav)
                {
                    case '+':
                        theList.Add(value);
                        Console.WriteLine(theList.Capacity);
                        break;
                    case '-':
                        theList.Remove(value);
                        Console.WriteLine(theList.Capacity);
                        break;
                    case '0':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Use only +, - or 0");
                        break;
                }
            }

            /* ===================== SVAR PÅ FRÅGOR =====================
             * 2/3. Listans kapacitet ökar när tillräcklickt många nya element läggs till, i början är det 4 värden som får plats i listan men lägger man 
             * till fler element ökar det till 8, 12, 16 osv.
             * 4. Anledning till varför capacity inte ökar varje gång ett element läggs till är, så som jag förstår det, att det är kostsamt att skapa nya listor då 
             * man behöver kopiera den gamla listan till en ny lista. Därav vill man göra det mer sällan.
             * 5. Kapaciteten minskar inte när man tar bort element ur listan.
             * 6. Om man vet hur många element som ska in i listan är det bättre att använda en array eftersom, som jag tidigare nämnde, är det kostsamt
             * att skapa och kopiera över listor hela tiden.
            */
        }

        /// <summary>
        /// Examines the datastructure Queue
        /// </summary>
        static void ExamineQueue()
        {
            /*
             * Loop this method untill the user inputs something to exit to main menue.
             * Create a switch with cases to enqueue items or dequeue items
             * Make sure to look at the queue after Enqueueing and Dequeueing to see how it behaves
            */

            Queue<string> theQueue = new Queue<string>();
            bool running = true;

            while (running)
            {
                Console.WriteLine("Please navigate through the menu by inputting the character \n(+, -, 1, 0) of your choice"
                    + "\n+. Add to queue"
                    + "\n-. Remove from queue"
                    + "\n1. Display queue"
                    + "\n0. Return");
                string ?input = Console.ReadLine();
                char nav = string.IsNullOrEmpty(input) ? ' ' : input[0];

                switch (nav)
                {
                    case '+':
                        Console.Write("Write the name of the customer: ");
                        string ?name = Console.ReadLine();

                        if (name == null)
                        {
                            Console.WriteLine("You need to type something");
                            break;
                        }

                        theQueue.Enqueue(name);
                        Console.WriteLine($"{name} gets in line");
                        break;
                    case '-':
                        Console.WriteLine($"{theQueue.First()} is dispatched and leaves the queue");
                        theQueue.Dequeue();
                        break;
                    case '1':
                        foreach (string value in theQueue)
                        {
                            Console.WriteLine($"{value} is standing in line");
                        }
                        break;
                    case '0':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Use only +, -, 1 or 0");
                        break;
                }
            }
        }

        /// <summary>
        /// Examines the datastructure Stack
        /// </summary>
        static void ExamineStack()
        {
            /*
             * Loop this method until the user inputs something to exit to main menue.
             * Create a switch with cases to push or pop items
             * Make sure to look at the stack after pushing and and poping to see how it behaves
            */

            //Stack<string> theStackQueue = new Stack<string>();
            //bool running = true;

            //while (running)
            //{
            //    Console.WriteLine("Please navigate through the menu by inputting the number \n(+, -, 1, 0) of your choice"
            //        + "\n+. Add to queue"
            //        + "\n-. Remove from queue"
            //        + "\n1. Display queue"
            //        + "\n0. Return");
            //    string ?input = Console.ReadLine();
            //    char nav = string.IsNullOrEmpty(input) ? ' ' : input[0];

            //    switch (nav)
            //    {
            //        case '+':
            //            Console.WriteLine("Write the name of the customer");
            //            string ?name = Console.ReadLine();

            //            if (name == null)
            //            {
            //                Console.WriteLine("You need to type something");
            //                break;
            //            }

            //            theStackQueue.Push(name);
            //            Console.WriteLine($"{name} Ställer sig i kön");
            //            break;
            //        case '-':
            //            Console.WriteLine($"{theStackQueue.First()} blir expedierad och lämnar kön");
            //            theStackQueue.Pop();
            //            break;
            //        case '1':
            //            foreach (string value in theStackQueue)
            //            {
            //                Console.WriteLine($"{value} står i kön");
            //            }
            //            break;
            //        case '0':
            //            running = false;
            //            break;
            //        default:
            //            Console.WriteLine("Use only + or -");
            //            break;
            //    }
            //}

            bool running = true;

            while (running)
            {
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 0) of your choice"
                    + "\n1. Reverse string with stack"
                    + "\n0. Return");
                string? input = Console.ReadLine();
                char nav = string.IsNullOrEmpty(input) ? ' ' : input[0];

                switch (nav)
                {
                    case '1':
                        Console.Write("Write a sentence: ");
                        string ?sentence = Console.ReadLine();

                        if (string.IsNullOrEmpty(sentence))
                        {
                            Console.Write("You have to write something...");
                            break;
                        }

                        Stack<char> reverseString = new Stack<char>();

                        foreach (char c in sentence)
                        {
                            reverseString.Push(c);
                        }

                        foreach (char c in reverseString)
                        {
                            Console.Write(c);
                        }
                        Console.WriteLine();
                        break;
                    case '0':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Use only 1 or 0");
                        break;
                }
            }
        }

        static void CheckParanthesis()
        {
            /*
             * Use this method to check if the paranthesis in a string is Correct or incorrect.
             * Example of correct: (()), {}, [({})],  List<int> list = new List<int>() { 1, 2, 3, 4 };
             * Example of incorrect: (()]), [), {[()}],  List<int> list = new List<int>() { 1, 2, 3, 4 );
             */

            bool running = true;

            while (running)
            {
                Stack<char> brackets = new Stack<char>();
                Console.WriteLine("Please navigate through the menu by inputting the number \n(1, 0) of your choice"
                    + "\n1. Add some parentheses"
                    + "\n0. Return");
                string? input = Console.ReadLine();
                char nav = string.IsNullOrEmpty(input) ? ' ' : input[0];

                switch (nav)
                {
                    case '1':
                        bool valid = true;
                        Console.Write("Write some parentheses: ");
                        string ?bracketsInput = Console.ReadLine();

                        if (string.IsNullOrEmpty(bracketsInput))
                        {
                            Console.WriteLine("You need to type something");
                            break;
                        }

                        foreach (char c in bracketsInput)
                        {
                            if (c == '(' || c == '{' || c == '[')
                            {
                                brackets.Push(c);
                            }
                            else if (c == ')' || c == '}' || c == ']')
                            {
                                if (brackets.Count <= 0)
                                    valid = false;

                                char open = brackets.Pop();

                                if (c == '}' && open != '{' ||
                                    c == ')' && open != '(' ||
                                    c == ']' && open != '[')
                                    valid = false;
                            }
                        }

                        if (brackets.Count > 0)
                            valid = false;

                        string output = valid ? "well formed" : "not well formed";

                        Console.WriteLine($"{bracketsInput} {output}");
                        break;
                    case '0':
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Use only + or -");
                        break;
                }
            }
        }

        static void RecursiveTest()
        {
            Console.WriteLine($"Recursive(1) - {RecursiveEven(1)}");
            Console.WriteLine($"Recursive(3) - {RecursiveEven(3)}");
            Console.WriteLine($"Recursive(5) - {RecursiveEven(5)}");
            Console.Write($"Fibonacci - 0 ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{FibonacciRecursive(i)} ");
            }
            Console.WriteLine("");
        }

        static int RecursiveEven(int n)
        {
            if (n == 1)
            {
                return 2;
            }
            return (RecursiveEven(n - 1) + 2);
        }

        static int FibonacciRecursive(int n)
        {
            if (n < 2)
                return 1;

            return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
        }

        static void IterationTest()
        {
            Console.WriteLine($"Iteration(1) - {IterationEven(1)}");
            Console.WriteLine($"Iteration(3) - {IterationEven(3)}");
            Console.WriteLine($"Iteration(5) - {IterationEven(5)}");
            Console.Write($"Fibonacci Sequence: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{FibonacciIterative(i)} ");
            }
            Console.WriteLine("");
        }

        static int IterationEven(int n)
        {
            int result = 2;

            for (int i = 0; i < n - 1; i++)
            {
                result += 2;
            }

            return result;
        }

        static int FibonacciIterative(int n)
        {
            int a = 0;
            int b = 1;
            int temp;

            for (int i = 0; i < n; i++)
            {
                temp = a;
                a = b;
                b = temp + b;
            }

            return a;
        }
    }
}

