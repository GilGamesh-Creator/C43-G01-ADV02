using System.Collections;

namespace AdvancedC_
{
    class Program
    {
        static void Main()
        {
            #region Question 1
            {
                int[] array = { 11, 5, 3 };
                int[] queries = { 1, 5, 13 };

                foreach (int x in queries)
                {
                    int count = 0;
                    foreach (int num in array)
                    {
                        if (num > x)
                        {
                            count++;
                        }
                    }
                    Console.WriteLine($"Question 1 Output for query {x}: {count}");
                }
            }
            #endregion

            #region Question 2
            {
                int[] array = { 1, 3, 2, 3, 1 };
                bool isPalindrome = true;

                for (int i = 0; i < array.Length / 2; i++)
                {
                    if (array[i] != array[array.Length - 1 - i])
                    {
                        isPalindrome = false;
                        break;
                    }
                }

                Console.WriteLine($"Question 2 Output: {(isPalindrome ? "YES" : "NO")}");
            }
            #endregion

            #region Question 3
            {
                Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
                Stack<int> stack = new Stack<int>();

                while (queue.Count > 0)
                {
                    stack.Push(queue.Dequeue());
                }

                while (stack.Count > 0)
                {
                    queue.Enqueue(stack.Pop());
                }

                Console.WriteLine("Question 3 Output:");
                foreach (int item in queue)
                {
                    Console.WriteLine(item);
                }
            }
            #endregion

            #region Question 4
            {
                string input = "[()]{}";
                Stack<char> stack = new Stack<char>();
                bool isBalanced = true;

                foreach (char c in input)
                {
                    if (c == '[' || c == '(' || c == '{')
                    {
                        stack.Push(c);
                    }
                    else
                    {
                        if (stack.Count == 0)
                        {
                            isBalanced = false;
                            break;
                        }

                        char top = stack.Pop();
                        if ((c == ']' && top != '[') || (c == ')' && top != '(') || (c == '}' && top != '{'))
                        {
                            isBalanced = false;
                            break;
                        }
                    }
                }

                if (stack.Count != 0)
                {
                    isBalanced = false;
                }

                Console.WriteLine($"Question 4 Output: {(isBalanced ? "Balanced" : "Not Balanced")}");
            }
            #endregion

            #region Question 5
            {
                int[] array = { 1, 2, 2, 3, 4, 4, 5 };
                int[] uniqueArray = array.Distinct().ToArray();

                Console.WriteLine("Question 5 Output:");
                foreach (int num in uniqueArray)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion

            #region Question 6
            {
                ArrayList list = new ArrayList { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                ArrayList evenList = new ArrayList();

                foreach (int num in list)
                {
                    if (num % 2 == 0)
                    {
                        evenList.Add(num);
                    }
                }

                Console.WriteLine("Question 6 Output:");
                foreach (int num in evenList)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion

            #region Question 7
            {
                Queue queue = new Queue();
                queue.Enqueue(1);
                queue.Enqueue("Apple");
                queue.Enqueue(5.28);

                Console.WriteLine("Question 7 Output:");
                foreach (var item in queue)
                {
                    Console.WriteLine(item);
                }
            }
            #endregion

            #region Question 8
            {
                Stack<int> stack = new Stack<int>(new[] { 1, 2, 3, 4, 5 });
                int target = 3;
                int count = 0;
                bool found = false;

                foreach (int num in stack)
                {
                    count++;
                    if (num == target)
                    {
                        found = true;
                        break;
                    }
                }

                if (found)
                {
                    Console.WriteLine($"Question 8 Output: Target was found successfully and the count = {count}");
                }
                else
                {
                    Console.WriteLine("Question 8 Output: Target was not found");
                }
            }
            #endregion

            #region Question 9
            {
                int[] array1 = { 1, 2, 3, 4, 4 };
                int[] array2 = { 10, 4, 4 };
                List<int> intersection = new List<int>();

                foreach (int num in array1)
                {
                    if (array2.Contains(num))
                    {
                        intersection.Add(num);
                        array2 = array2.Where((val, idx) => idx != Array.IndexOf(array2, val)).ToArray();
                    }
                }

                Console.WriteLine("Question 9 Output:");
                foreach (int num in intersection)
                {
                    Console.WriteLine(num);
                }
            }
            #endregion

            #region Question 10
            {
                List<int> list = new List<int> { 1, 2, 3, 7, 5 };
                int target = 12;
                int sum = 0;
                List<int> sublist = new List<int>();

                for (int i = 0; i < list.Count; i++)
                {
                    sum = 0;
                    sublist.Clear();
                    for (int j = i; j < list.Count; j++)
                    {
                        sum += list[j];
                        sublist.Add(list[j]);
                        if (sum == target)
                        {
                            Console.WriteLine($"Question 10 Output: [{string.Join(", ", sublist)}]");
                            return;
                        }
                    }
                }

                Console.WriteLine("Question 10 Output: No sublist found");
            }
            #endregion

            #region Question 11
            {
                Queue<int> queue = new Queue<int>(new[] { 1, 2, 3, 4, 5 });
                int k = 3;
                Stack<int> stack = new Stack<int>();

                for (int i = 0; i < k; i++)
                {
                    stack.Push(queue.Dequeue());
                }

                while (stack.Count > 0)
                {
                    queue.Enqueue(stack.Pop());
                }

                for (int i = 0; i < queue.Count - k; i++)
                {
                    queue.Enqueue(queue.Dequeue());
                }

                Console.WriteLine("Question 11 Output:");
                foreach (int item in queue)
                {
                    Console.WriteLine(item);
                }
            }
            #endregion
        }
    }

}
