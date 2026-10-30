using System;

class Program
{
    // ============================================
    //              STATIC STACK (ARRAY)
    // ============================================
    class StaticStack
    {
        private int[] stack;
        private int top;
        private int max;

        public StaticStack(int size)
        {
            max = size;
            stack = new int[max];
            top = -1;
        }

        public bool IsFull()
        {
            return top == max - 1;
        }

        public bool IsEmpty()
        {
            return top == -1;
        }

        public void Push(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is full. Cannot push.");
                return;
            }
            stack[++top] = value;
            Console.WriteLine($"Pushed: {value}");
        }

        public void Pop()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty. Cannot pop.");
                return;
            }
            Console.WriteLine($"Popped: {stack[top--]}");
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }
            Console.WriteLine($"Top element: {stack[top]}");
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack elements:");
            for (int i = top; i >= 0; i--)
                Console.WriteLine(stack[i]);
        }
    }

    // ============================================
    //              STATIC QUEUE (ARRAY)
    // ============================================
    class StaticQueue
    {
        private int[] queue;
        private int front, rear, max;

        public StaticQueue(int size)
        {
            max = size;
            queue = new int[max];
            front = 0;
            rear = -1;
        }

        public bool IsFull()
        {
            return rear == max - 1;
        }

        public bool IsEmpty()
        {
            return front > rear;
        }

        public void Enqueue(int value)
        {
            if (IsFull())
            {
                Console.WriteLine("Queue is full. Cannot enqueue.");
                return;
            }
            queue[++rear] = value;
            Console.WriteLine($"Enqueued: {value}");
        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty. Cannot dequeue.");
                return;
            }
            Console.WriteLine($"Dequeued: {queue[front++]}");
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }
            Console.WriteLine($"Front element: {queue[front]}");
        }

        public void Display()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Queue is empty.");
                return;
            }

            Console.WriteLine("Queue elements:");
            for (int i = front; i <= rear; i++)
                Console.WriteLine(queue[i]);
        }
    }

    // ============================================
    //                    MAIN MENU
    // ============================================
    static void Main()
    {
        StaticStack stack = new StaticStack(5);
        StaticQueue queue = new StaticQueue(5);

        int option;

        do
        {
            Console.WriteLine("\n============= STATIC STACK & QUEUE =============");
            Console.WriteLine("1. Push (Stack)");
            Console.WriteLine("2. Pop (Stack)");
            Console.WriteLine("3. Peek (Stack)");
            Console.WriteLine("4. Display Stack");
            Console.WriteLine("5. Enqueue (Queue)");
            Console.WriteLine("6. Dequeue (Queue)");
            Console.WriteLine("7. Peek (Queue)");
            Console.WriteLine("8. Display Queue");
            Console.WriteLine("9. Exit");
            Console.Write("Choose an option: ");

            option = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (option)
            {
                case 1:
                    Console.Write("Enter a number to push: ");
                    stack.Push(int.Parse(Console.ReadLine()));
                    break;

                case 2:
                    stack.Pop();
                    break;

                case 3:
                    stack.Peek();
                    break;

                case 4:
                    stack.Display();
                    break;

                case 5:
                    Console.Write("Enter a number to enqueue: ");
                    queue.Enqueue(int.Parse(Console.ReadLine()));
                    break;

                case 6:
                    queue.Dequeue();
                    break;

                case 7:
                    queue.Peek();
                    break;

                case 8:
                    queue.Display();
                    break;

                case 9:
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }

        } while (option != 9);
    }
}
