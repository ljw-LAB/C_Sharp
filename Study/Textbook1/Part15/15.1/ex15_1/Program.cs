using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex15_1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Action action = () => { Console.WriteLine("Action"); };
                ActionProxy<Action> proxy = new ActionProxy<Action>(action);
                proxy.Call();
            }

            {
                Action<int> action = (arg) => { Console.WriteLine($"Action<int>: {arg}"); };
                ActionProxy<Action<int>> proxy = new ActionProxy<Action<int>>(action);
                proxy.Call();
            }
        }
    }

    class ActionProxy<T> where T : System.Delegate /* System.MulticastDelegate */
    {
        T _callbackFunc;

        public ActionProxy(T callbackFunc)
        {
            _callbackFunc = callbackFunc;
        }

        public void Call()
        {
            switch (_callbackFunc)
            {
                case Action action:
                    action();
                    break;

                case Action<int> action:
                    action(5);
                    break;
            }
        }
    }
}
