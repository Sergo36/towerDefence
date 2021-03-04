using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace towerDefense
{
    class Program
    {
        
        static void Main(string[] args)
        {
            List<GameObject> gameObject = new List<GameObject>()
            {
            new GameObject(new Units(100, 50), new Point(0,0), new Point(1,0), 5),
            //new GameObject(new Units(100, 50), new Point(0,0), new Point(-1,0), 10)
            };

            int i = 0;
            while(i < 5)
            {
                Thread.Sleep(1000);
                update(gameObject);
                render();
                i++;
            }
        }

        
        //Методы расчета и вывода надо сделать в разных потоках, что бы вывод был с фикисованным количеством вызовов в секунду
        static void update(List<GameObject> gameObject)
        {
            foreach (var item in gameObject)
            {
                item.objectUpdate();
                Console.WriteLine(item.getPosition());
            }
        }

        static void render()
        {
            
            
            //Тут выводим на экран
        }

        
    }

   
}
