using System;

namespace ColorClass
{
    public class Ball
    {
        private Color _color;
        private float _radius;
        private int _count;

        public Ball(Color color, float radius)
        {
            this._color = color;
            this._radius = radius;
            this._count = 0;
        }
        public void Pop()
        {
            Console.WriteLine("You popped the ball!");
            _radius = 0;
        }
        public void Throw()
        {
            if(_radius > 0)
            {
                _count++;
                Console.WriteLine("You throw the ball");
            }
            else
            {
                Console.WriteLine("You try to throw the ball but it has been popped, sorry");
            }
        }
        public int NumberOfThrows()
        {
            return _count;
        }
    }
}
