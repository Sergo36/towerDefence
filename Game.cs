using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;

namespace towerDefense
{
    class Game
    {
        private List<GameObject> _gameObject;
        private static Timer _timeRender; 
        private static Thread _threadUpate;
        public Game()
        {
            _timeRender = new Timer(new TimerCallback(render));
            _timeRender.Change(0,1000);
            _threadUpate = new Thread(new ThreadStart(testUpdate));

            _gameObject = new List<GameObject>()
            {
            new GameObject(new Units(100, 50), new Point(0,0), new Point(1,0), 5),
            //new GameObject(new Units(100, 50), new Point(0,0), new Point(-1,0), 10)
            };
        }

        public void start()
        {
            _threadUpate.Start();
        }
        public void testUpdate()
        {
            int i = 0;
            while(i < 5)
            {
                Thread.Sleep(500);
                update();
                i++;
            }
        }

        public void stop()
        {
            _timeRender.Dispose();
        }
        //Методы расчета и вывода надо сделать в разных потоках, что бы вывод был с фикисованным количеством вызовов в секунду
        private void update()
        {
            foreach (var item in _gameObject)
            {
                item.objectUpdate();
            }
        }
        private void render(object timerState)
        {

            foreach (var item in _gameObject)
            {
                Console.WriteLine(item.getPosition());
            }
            
        }

        
    }

   
}