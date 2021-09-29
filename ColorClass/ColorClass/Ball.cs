using System;
using System.Collections.Generic;
using System.Text;

namespace ColorClass
{
    public class Ball
    {
        private Color color;
        private float radius;
        private int Count;

        public Ball(Color color, float radius)
        {
            this.color = color;
            this.radius = radius;
            this.Count = 0;
        }
        public void Pop()
        {
            Console.WriteLine("You popped the ball!");
            radius = 0;
        }
        public void Throw()
        {
            if(radius > 0)
            {
                Count++;
                Console.WriteLine("You throw the ball");
            }
            else
            {
                Console.WriteLine("You try to throw the ball but it has been popped, sorry");
            }
        }
        public int NumberOfThrows()
        {
            return Count;
        }
    }
}
