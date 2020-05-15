using System;
using System.Collections.Generic;

namespace OT_2._4_steck_
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 0;// длина стека
            Stack<char> stack = new Stack<char>();
            for (; ;)

            {
                string text = Console.ReadLine();
                foreach (Char a in text)
                    switch (a)
                    {
                        case ')':
                            if (stack.Count == 0 || stack.Pop() != '(')
                            {
                                Console.WriteLine("Лишняя закрывающая скобка ')'");
                                b += 1;
                            }
                            break;
                        case '}':
                            if (stack.Count == 0 || stack.Pop() != '{')
                            {
                                Console.WriteLine("Лишняя закрывающая скобка '}'");
                                b += 1;
                            }
                            break;
                        case ']':
                            if (stack.Count == 0 || stack.Pop() != '[')
                            {
                                Console.WriteLine("Лишняя закрывающая скобка ']'");
                                b += 1;
                            }
                            break;
                        case '>':
                            if (stack.Count == 0 || stack.Pop() != '<')
                            {
                                Console.WriteLine("Лишняя закрывающая скобка '>'");
                                b += 1;
                            }
                            break;
                        case '(':
                        case '{':
                        case '[':
                        case '<':
                            stack.Push(a);
                            break;
                    }
                if (stack.Count > 0)
                {
                    Console.WriteLine("Не найдена закрывающая скобка для " + stack.Pop());
                }
                else if (b > 0)
                {

                }
                else
                {
                    Console.WriteLine("Нет ошибки");
                }
                stack.Clear();
           } 
        }
    }
}
