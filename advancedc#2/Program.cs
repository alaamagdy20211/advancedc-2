using System.Collections;
//
namespace advancedc_2
{
    internal class Program
    {


        static void ReverseFirstKElements(Queue<int> queue, int K)
        {
            Stack<int> stack = new Stack<int>();

           
            for (int i = 0; i < K && queue.Count > 0; i++)
            {
                stack.Push(queue.Dequeue());
            }

           
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }

           
            int remainingCount = queue.Count - K;
            for (int i = 0; i < remainingCount; i++)
            {
                queue.Enqueue(queue.Dequeue());
            }
        }

        static List<int> FindSublistWithSum(ArrayList list, int targetSum)
        {
            int currentSum = 0;
            int start = 0;

            for (int end = 0; end < list.Count; end++)
            {
                currentSum += (int)list[end];

                
                while (currentSum > targetSum && start <= end)
                {
                    currentSum -= (int)list[start];
                    start++;
                }

               
                if (currentSum == targetSum)
                {
                    List<int> result = new List<int>();
                    for (int i = start; i <= end; i++)
                    {
                        result.Add((int)list[i]);
                    }
                    return result;
                }
            }

            return new List<int>(); 
        }
        static int[] FindIntersection(int[] arr1, int[] arr2)
        {
        Dictionary<int, int> countMap = new Dictionary<int, int>();
        List<int> result = new List<int>();

        foreach (int num in arr1)
        {
            if (countMap.ContainsKey(num))
            {
                countMap[num]++;
            }
            else
            {
                countMap[num] = 1;
            }
        }

        foreach (int num in arr2)
{
    if (countMap.ContainsKey(num) && countMap[num] > 0)
    {
        result.Add(num);
        countMap[num]--;
    }
}

return result.ToArray();
    }

        static void SearchTargetInStack(Stack<int> stack, int target)
        {
            int count = 0;
            bool found = false;
            Stack<int> tempStack = new Stack<int>();

           
            while (stack.Count > 0)
            {
                int current = stack.Pop();
                count++;

                if (current == target)
                {
                    found = true;
                    break;
                }

                tempStack.Push(current); 
            }

           
            while (tempStack.Count > 0)
            {
                stack.Push(tempStack.Pop());
            }

           
            if (found)
            {
                Console.WriteLine($"Target was found successfully and the count = {count}");
            }
            else
            {
                Console.WriteLine("Target was not found");
            }
        }
        static void oveOddNumbers(ArrayList list)
        {
            ArrayList itemsToRemove = new ArrayList();

            foreach (var item in list)
            {
                if ((int)item % 2 != 0)
                {
                    itemsToRemove.Add(item);
                }
            }

            foreach (var item in itemsToRemove)
            {
                list.Remove(item);
            }
        }
        static int[] RemoveDuplicates(int[] arr)
        {
            return arr.Distinct().ToArray();
        }
        static void ReverseQueue(Queue<int> queue)
        {
            Stack<int> stack = new Stack<int>();

            while (queue.Count > 0)
            {
                stack.Push(queue.Dequeue());
            }

            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }

        static void PrintQueue(Queue<int> queue)
        {
            foreach (var item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        static bool IsBalanced(string input)
        {
            Stack<char> stack = new Stack<char>();

            foreach (char c in input)
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    stack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (stack.Count == 0) return false;

                    char top = stack.Pop();
                    if (!IsMatchingPair(top, c)) return false;
                }
            }

            return stack.Count == 0;
        }

        static bool IsMatchingPair(char open, char close)
        {
            return (open == '(' && close == ')') ||
                   (open == '{' && close == '}') ||
                   (open == '[' && close == ']');
        }
        static void Main(string[] args)
        {

            #region q
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Enter {n} numbers separated by spaces:");
            //int[] arr = Console.ReadLine().Trim().Split().Select(int.Parse).ToArray();

            //bool isPalindrome = true;
            //for (int i = 0; i < n / 2; i++)
            //{
            //    if (arr[i] != arr[n - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}

            //Console.WriteLine(isPalindrome ? "YES" : "NO");
            #endregion
            #region
            //Queue<int> queue = new Queue<int>();

            //Console.WriteLine("Enter the number of elements in the queue:");
            //int n =int.Parse(Console.ReadLine());

            //Console.WriteLine($"Enter {n} elements separated by spaces:");
            //string[] input = Console.ReadLine().Split();
            //foreach (string element in input)
            //{
            //    queue.Enqueue(int.Parse(element));
            //}

            //Console.WriteLine("Original Queue:");
            //PrintQueue(queue);

            //ReverseQueue(queue);

            //Console.WriteLine("Reversed Queue:");
            //PrintQueue(queue);
            #endregion
            #region
            //Console.WriteLine("Enter a string of parentheses:");
            //string input = Console.ReadLine();

            //bool isBalanced = IsBalanced(input);
            //Console.WriteLine(isBalanced ? "Balanced" : "Not Balanced");
            #endregion
            #region
            //Console.WriteLine("Enter the size of the array:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Enter {n} elements separated by spaces:");
            //int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            //int[] uniqueArray = RemoveDuplicates(arr);

            //Console.WriteLine("Array after removing duplicates:");
            //Console.WriteLine(string.Join(" ", uniqueArray));
            #endregion
            #region
            //   Console.WriteLine("Enter the size of the ArrayList:");
            //   int n = int.Parse(Console.ReadLine());

            //   ArrayList list = new ArrayList();

            //   Console.WriteLine($"Enter {n} elements separated by spaces:");
            //   string[] input = Console.ReadLine().Split();
            //   foreach (string element in input)
            //   {
            //       list.Add(int.Parse(element));
            //   }

            //oveOddNumbers(list);

            //   Console.WriteLine("ArrayList after removing odd numbers:");
            //   foreach (var item in list)
            //   {
            //       Console.Write(item + " ");
            //   }
            #endregion
            #region
            //Queue queue = new Queue();

            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            //Console.WriteLine("Queue elements:");
            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region
            //Stack<int> stack = new Stack<int>();

            //Console.WriteLine("Enter the number of elements to push onto the stack:");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine($"Enter {n} integers separated by spaces:");
            //string[] input = Console.ReadLine().Split();
            //foreach (string element in input)
            //{
            //    stack.Push(int.Parse(element));
            //}

            //Console.WriteLine("Enter the target integer to search for:");
            //int target = int.Parse(Console.ReadLine());

            //SearchTargetInStack(stack, target);
            #endregion

            #region
            //Console.WriteLine("Enter the size of the first array:");
            //int n1 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Enter {n1} elements for the first array separated by spaces:");
            //int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //Console.WriteLine("Enter the size of the second array:");
            //int n2 = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Enter {n2} elements for the second array separated by spaces:");
            //int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            //int[] intersection = FindIntersection(arr1, arr2);

            //Console.WriteLine("Intersection of the two arrays:");
            //Console.WriteLine(string.Join(" ", intersection));
            #endregion
            #region
            //Console.WriteLine("Enter the array ");
            //string input = Console.ReadLine().Trim('[', ']');
            //string[] elements = input.Split(',');

            //ArrayList list = new ArrayList();
            //foreach (string element in elements)
            //{
            //    list.Add(int.Parse(element.Trim()));
            //}

            //Console.WriteLine("Enter the target sum:");
            //int targetSum = int.Parse(Console.ReadLine());

            //List<int> result = FindSublistWithSum(list, targetSum);

            //if (result.Count > 0)
            //{
            //    Console.WriteLine("Output: ");
            //    Console.WriteLine("[" + string.Join(", ", result) + "]");
            //}
            //else
            //{
            //    Console.WriteLine("No contiguous sublist sums up to the target.");
            //}
            #endregion

            #region
            Console.WriteLine("Enter the queue :");
            string input = Console.ReadLine().Trim('[', ']');
            string[] elements = input.Split(',');

            Queue<int> queue = new Queue<int>();
            foreach (string element in elements)
            {
                queue.Enqueue(int.Parse(element.Trim()));
            }

            Console.WriteLine("Enter the value of K:");
            int K = int.Parse(Console.ReadLine());

            ReverseFirstKElements(queue, K);

            Console.WriteLine("Output:");
            Console.WriteLine("[" + string.Join(", ", queue) + "]");
        

        #endregion
    }
}
}
