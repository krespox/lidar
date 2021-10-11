using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Input;

namespace lidar
{
    class RoomVisualize
    {

        protected Dictionary<float, float> points = new Dictionary<float, float>();

        public float area = 0;

        List<float> areaTriangle = new List<float>();
        float a,b,c,d;



        public RoomVisualize()
        {
        }

        public float getHeight() { return b; }
        public float getWidth() { return d; }
        public float getArea() { return area; }

        public void calculatePoints(float distance, float angle)
        {
            double x, y;

            areaTriangle.Add(distance);

            {
              
                x = distance * Math.Cos(angle * 0.0174532925); //radian
                y = distance * Math.Sin(angle * 0.0174532925);
                
                if( !points.ContainsKey(Convert.ToSingle(x)))
                points.Add(Convert.ToSingle(x), Convert.ToSingle(y));

                if (angle == 0)
                {
                    a = distance;
                }
                if (angle == 180)
                {
                    b = distance + a;
                }

                if (angle == 90)
                {
                    c = distance;
                }
                if (angle == 270)
                {
                    d = distance + c;
                }

            }
            
        }

        public void calculateSurfaceArea()
        {
            for(int i = 0; i< areaTriangle.Count - 1;  i++)
            {
                
                area = area + 0.5f * areaTriangle.ElementAt(i) * areaTriangle.ElementAt(i+1) * Convert.ToSingle(Math.Sin(0.45 * 0.0174532925));
 
            }
               
        }
        public void DeleteValues()
        { 
            points.Clear();
        }

        public void drawPoints(Bitmap bitmap, Panel panel)
        {
            var halfX = panel.ClientRectangle.Width / 2;
            var halfY = panel.ClientRectangle.Height / 2;

            using (Graphics d = Graphics.FromImage(bitmap))
            {
                foreach (var point in points)
                {
               
                    SolidBrush brush = new SolidBrush(Color.FromArgb(62,120,138));

                    double x = point.Key * 25.0 + halfX;                         
                    double y = point.Value * 25.0 + halfY;
                    PointF pointR = new PointF(Convert.ToSingle(x), Convert.ToSingle(y));

                    RectangleF rect = new RectangleF(pointR, new System.Drawing.Size(5, 5));
                    d.FillRectangle(brush, rect);    
                  
                }
               
            }

        }
    }

   
    
}
