using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sweng_example_2
{

    //creates and ellipse or circle objects when called.
    //only the IShape interface is called. Shape is created via polymorphism
    class Ellipse : IShape
    {

        //hold and return our shape object;
        Graphics g;
        Bitmap bm;      //Bitmap object to handle graphics operations

        int width, height;
        // int evtx, evty, oldx, oldy;

        public Ellipse(Bitmap b)
        {
            bm = b;
        }

        public virtual Graphics FillShape(Brush b, int x, int y, int cirx, int ciry)
        {
           /* Activate method if required by future programming, 
            * else keep virtual until required.
            * Remove comments before use*/
            
            g = Graphics.FromImage(bm);

            //calculate dimensions
           width = Math.Abs(x - cirx);
           height = Math.Abs(y - ciry);

            if (x < cirx && y > ciry)
                g.FillEllipse(b, x, ciry, width, height);
                    else if (y < ciry && x > cirx)
                        g.FillEllipse(b, cirx, y, width, height);
                            else if (x < cirx && y < ciry)
                             g.FillEllipse(b, x, y, width, height);
                                else
                                 g.FillEllipse(b, cirx, ciry, width, height);

            return g;
           
        }

        Graphics IShape.SetShape(Pen p, int x, int y, int cirx, int ciry)
        {
            g = Graphics.FromImage(bm);

            //calculate dimensions
            width = Math.Abs(x - cirx);
            height = Math.Abs(y - ciry);

            //corrects for mouse location
            if (x < cirx && y > ciry)
                g.DrawEllipse(p, x, ciry, width, height);
                    else if (y < ciry && x > cirx)
                     g.DrawEllipse(p, cirx, y, width, height);
                        else if (x < cirx && y < ciry)
                            g.DrawEllipse(p, x, y, width, height);
                                else
                                 g.DrawEllipse(p, cirx, ciry, width, height);
             return g;
        }
    }
}
