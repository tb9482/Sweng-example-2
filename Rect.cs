using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sweng_example_2
{
    class Rect : IShape
    {

        //hold and return our shape object;
        Graphics g;
        Bitmap bm;      //Bitmap object to handle graphics operations

        int width, height;
        // int evtx, evty, oldx, oldy;

        public Rect(Bitmap b)
        {
            bm = b;
        }
        

        public Graphics SetShape(Pen p, int x, int y, int cirx, int ciry)
        {
            g = Graphics.FromImage(bm);
                
            //calculate dimensions
            width = Math.Abs(x - cirx);
            height = Math.Abs(y - ciry);

            

            if (x < cirx && y > ciry)
                 g.DrawRectangle(p, x, ciry, width, height);
                else if (y < ciry && x > cirx)
                     g.DrawRectangle(p, cirx, y, width, height);
                        else if (x < cirx && y < ciry)
                         g.DrawRectangle(p, x, y, width, height);
                             else
                             g.DrawRectangle(p, cirx, ciry, width, height);

            return g;

        }
        public Graphics FillShape(Brush b, int x, int y, int cirx, int ciry)
        {

            g = Graphics.FromImage(bm);
            //calculate dimensions
            width = Math.Abs(x - cirx);
            height = Math.Abs(y - ciry);

            //Corrects for mouse position
            if (x < cirx && y > ciry)
                g.FillRectangle(b, x, ciry, width, height);
                 else if (y < ciry && x > cirx)
                     g.FillRectangle(b, cirx, y, width, height);
                         else if (x < cirx && y < ciry)
                             g.FillRectangle(b, x, y, width, height);
                                else
                                 g.FillRectangle(b, cirx, ciry,width, height);

            return g;
        }
    }
}
