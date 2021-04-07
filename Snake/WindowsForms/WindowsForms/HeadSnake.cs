using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms
{
    
    class HeadSnake : Segment, ISegmentBehavior
    {
        private Direction _direction;
        public HeadSnake() : base()
        {
            _direction = Direction.UP;
        }
        public HeadSnake(Direction direction, int x, int y, int radius, Color color) : base(x, y, radius, color)
        {
            _direction = direction;
        }
        public void Draw(Graphics graphics)
        {
            Bitmap myBitmap = new Bitmap(Resource.snake);
            Color backColor = myBitmap.GetPixel(1, 1);
            myBitmap.MakeTransparent(backColor);
            
            switch (_direction)
            {
                case Direction.UP:
                    myBitmap = RotateImage(myBitmap, 180);
                    break;
                case Direction.RIGHT:
                    myBitmap = RotateImage(myBitmap, 270);
                    break;
                case Direction.DOWN:
                    myBitmap = RotateImage(myBitmap, 0);
                    break;
                case Direction.LEFT:
                    myBitmap = RotateImage(myBitmap, 90);
                    break;
            }
            Radius = Radius * 2;
            graphics.DrawImage(                
                myBitmap, new Rectangle(X - Radius + Radius/2, Y - Radius, Radius * 2, Radius * 2)   // my code
            //myBitmap, new Rectangle(X - Radius, Y - Radius, Radius * 2, Radius * 2)
            ); 
        }
        private Bitmap RotateImage(Bitmap bmp, float angle)
        {
            Bitmap rotatedImage = new Bitmap(bmp.Width, bmp.Height);
            rotatedImage.SetResolution(bmp.HorizontalResolution, bmp.VerticalResolution);

            using (Graphics g = Graphics.FromImage(rotatedImage))
            {
                // Set the rotation point to the center in the matrix
                g.TranslateTransform(bmp.Width / 2, bmp.Height / 2);
                // Rotate
                g.RotateTransform(angle);
                // Restore rotation point in the matrix
                g.TranslateTransform(-bmp.Width / 2, -bmp.Height / 2);
                // Draw the image on the bitmap
                g.DrawImage(bmp, new Point(0, 0));
            }

            return rotatedImage;
        }
    }
}
