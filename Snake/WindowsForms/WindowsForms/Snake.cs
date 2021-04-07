using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    class Snake : ISegmentBehavior
    {
        private ArrayList _snake;
        private int Radius {get;}
        // private List<ISegmentBehavior> _snake;

        public Snake()
        {
            Radius = 50;
            _snake = new ArrayList();
            HeadSnake headSnake = new HeadSnake(Direction.RIGHT, 600, 200, Radius, Color.White);

            _snake.Add(headSnake);
             _snake.Add(new SegmentSnake(headSnake.X - Radius * 2, headSnake.Y, Radius, Color.Green));  // 
                 // my code                                                                                                                                                                           // my code
            _snake.Add(new SegmentSnake(headSnake.X - Radius * 4, headSnake.Y, Radius, Color.Green));
            _snake.Add(new SegmentSnake(headSnake.X - Radius * 6, headSnake.Y, Radius, Color.Green));
            _snake.Add(new SegmentTail(headSnake.X - Radius * 8, headSnake.Y, Radius, Color.Green));

        }
        public void Draw(Graphics graphics)
        {
            // my code
            foreach (var item in _snake)
            {
                ((ISegmentBehavior)item).Draw(graphics);
            }
            //foreach (var item in _snake)
            //{
            //    if(item is HeadSnake)
            //    {
            //        ((HeadSnake)item).Draw(graphics);
            //    }
            //    else
            //    {
            //        ((SegmentSnake)item).Draw(graphics);
            //    }
            //}



        }
    }
}
