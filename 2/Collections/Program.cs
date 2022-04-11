using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DemoCollections();
        }

        private static void DemoCollections()
        {
            UseList();
            UseDictionary();
            UseQueue();
            UseStack();
        }

        private static void UseStack()
        {
            var stack = new Stack<string>();

            stack.Push("one");
            stack.Push("two");
            stack.Push("three");

            var lastElement = stack.Pop();
        }

        private static void UseQueue()
        {
            var queue = new Queue<string>();

            queue.Enqueue("one");
            queue.Enqueue("two");
            queue.Enqueue("three");
            queue.Dequeue();

            var element = queue.Peek();
        }

        private static void UseDictionary()
        {
            var dictionary = new Dictionary<int, string>();

            dictionary.Add(1, "one");
            dictionary.Add(2, "two");
            dictionary.Add(3, "three");
            dictionary.Remove(1);
        }

        private static void UseList()
        {
            var list = new List<string>();

            list.Add("one");
            list.AddRange(new List<string>() { "two", "three" });
            list.Remove("two");
        }
    }
}
