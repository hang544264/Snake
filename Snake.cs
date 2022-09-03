using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake
    {
        private static Snake instance = null;

        public static Snake Instance()
        {
            if (instance == null)
            {
                instance = new Snake();
            }
            return instance;
        }

        List<Point> body = new List<Point>();

        Direction dir = Direction.Right;
        public void Start()
        { 
            body.Add(new Point(2,4));
            body.Add(new Point(2,3));
            body.Add(new Point(2,2));
        }
        /// <summary>
        /// 判断依据：
        /// 1.蛇头是否撞墙
        /// 2.蛇头是否撞上身体
        /// </summary>
        /// <returns>true：结束，flase：进行中</returns>
        private bool IsGameOver()
        {
            Point head = body[0];//蛇头的坐标

            //1.蛇头是否撞墙
            if (Map.Instance().GetAt(head) == Map.Wall)
                return true;

            //2.蛇头是否撞上身体
            for (int i = 1;i < body.Count; i++)
            {
                if (body[i] == head)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// 处理转向判定
        /// 只能往蛇的前进方向的侧方向
        /// 1.获取按键输入
        /// 2.判定是否移动
        /// 3.改变dir
        /// </summary>
        private void Turn()
        {
            //1.获取按键输入
            if (Console.KeyAvailable)
            {
                ConsoleKey key =  Console.ReadKey(true).Key;

                //2.判定是否移动
                if (key == ConsoleKey.LeftArrow && dir != Direction.Right)
                {
                    dir = Direction.Left;
                }
                else if (key == ConsoleKey.RightArrow && dir != Direction.Left)
                {
                    dir = Direction.Right;
                }
                else if (key == ConsoleKey.UpArrow && dir != Direction.Down)
                {
                    dir = Direction.up;
                }
                else if (key == ConsoleKey.DownArrow && dir != Direction.up)
                {
                    dir = Direction.Down;
                }
            }
        }

        /// <summary>
        /// 根据蛇的的移动方向dir在地图上前进
        /// </summary>
        private void Move()
        {
            switch (dir) 
            {
                case Direction.Left:
            }
        }

        /// <summary>
        /// 吃食
        /// 判定蛇头位置是否存在食物，如果有，则：
        /// 1.删除地图上食物的位置
        /// 2.蛇增长
        /// 3.并重新生成
        /// </summary>
        private void Eat()
        {

        }
        public void Update()
        {
            if (IsGameOver())
                return;

            Turn();
            Move();
            Eat();
        }

        public void Draw()
        {

        }
    }
}
