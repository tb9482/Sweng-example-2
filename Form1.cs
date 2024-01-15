using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sweng_example_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //this.AutoSize = true;
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);  //sets the paint area white
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

        }
        //create the shape object. All shapes are rendered from this interface.

        IShape S;

        //declare variables

        Bitmap bm;
        Point px, py;

        //bool values to determine is drawing is in progress or if a fill is desired.

        bool draw = false;
        bool fill = false;

        Graphics g;
        Pen p = new Pen(Color.Black, 2);
        Pen erase = new Pen(Color.White, 10);  //"White Pen to match backround acts as an eraser

        Brush fillin;                           //brush object for fill option

        /*The following variables allow for shape generation on the imposed bitmap 
            index acts as a switch that will change the desired shape.
            the individual variables are point variables. cirx, ciry, sqx, sqy are for 
            the special dimensions used for shapes such as ellipses and rectangles. */

        int index = 5;                         //default shape is a line
        int x, y, cirx, ciry, sqx,sqy;


        //The following are for color control using the sliders set to RGB values. 
        private int rvalue = 100, gvalue = 150, bvalue = 200;
        
        
        //version 2 code. replaced by polymorphic class IShape
                         //Rect r;

        


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
            S = new Rect(bm);
             //r = new Rect(bm);
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private Color RenderColor(int Rval,int Gval,int Bval)
        {

            //method to create render color and transparency from the sliders

            Color c = Color.FromArgb(Rval, Gval, Bval);
            return c;
        }
        private void pic_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            // set the pen color 

            p.Color = RenderColor(rvalue, gvalue, bvalue);
            

            if (draw)
            {
                if (index == 3)
                {

                   // S.SetShape(p, x, y, cirx, ciry);
                    g.DrawEllipse(p, cirx, ciry, sqx, sqy);

            
                }
                if (index == 4)
                {
                    sqx = rectwidth(x, cirx);
                    sqy = rectheight(y, ciry);

                               
                    //Revision 3 object call but causes a image issue on the bitmap.
                    //keep until issue is resolved or use conventional method.

                                 //r.SetShape(p, x, y, cirx, ciry);

                   if (x < cirx && y > ciry)
                       g.DrawRectangle(p, x, ciry, sqx, sqy);
                         else if (y < ciry && x > cirx)
                            g.DrawRectangle(p, cirx, y, sqx, sqy);
                                else if (x < cirx && y < ciry)
                                 g.DrawRectangle(p, x, y, sqx, sqy);
                                    else
                                        g.DrawRectangle(p, cirx, ciry, sqx, sqy);
                   
                }
                if (index == 5)
                {
                    g.DrawLine(p, cirx, ciry, x, y);
                }
            }
        }

        private void trackBar_red_Scroll(object sender, EventArgs e)
        {
            //store the red slider value
            rvalue = trackBar_red.Value;
            trackBar_red.BackColor = Color.FromArgb(rvalue, 0, 0);
        }

        private void checkBox_fill_CheckedChanged(object sender, EventArgs e)
        {
            //sets the fill boolean to true if checkbox is set
            if (checkBox_fill.Checked == true)
                fill = true;
            else
                fill = false;
        }

       

        private void trackBar_grn_Scroll(object sender, EventArgs e)
        {
            //store the green slider value
            gvalue = trackBar_grn.Value;
            trackBar_grn.BackColor = Color.FromArgb(0, gvalue,0);
        }

        private void trackBar_blue_Scroll(object sender, EventArgs e)
        {
            //store the blue slider value and update the slider back color
            bvalue = trackBar_blue.Value;
            trackBar_blue.BackColor = Color.FromArgb(0, 0, bvalue);
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            draw = true;
            py = e.Location;

            cirx = e.X;
            ciry = e.Y;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
           draw = false;

            fillin = new SolidBrush(Color.FromArgb( rvalue, gvalue, bvalue));

            x = e.X;
            y = e.Y;

            

            if (index == 3)
            {
                S.SetShape(p, x, y, cirx, ciry);

                     //version 2 code //g.DrawEllipse(p, cirx, ciry, sqx, sqy);

                //check for fill
                if (fill)
                    S.FillShape(fillin, x, y, cirx, ciry);

                        //version 2 code // g.FillEllipse(fillin, cirx, ciry, sqx, sqy);
            }
            if (index == 4)
            {

                S.SetShape(p, x, y, cirx, ciry);

                    //r.SetShape(p, x, y, cirx, ciry);

                /* This is version 2 code without the object call. You this to 
                     * revert to previous version for testing / troubleshooting */

                            //sqx = rectwidth(x, cirx);
                            //sqy = rectheight(y, ciry);

                            // if (x < cirx && y > ciry)
                                //  g.DrawRectangle(p, x,ciry, sqx, sqy);
                            //  else if (y < ciry && x > cirx)
                                //   g.DrawRectangle(p, cirx, y, sqx, sqy);
                                     //   else if (x < cirx && y < ciry)
                                        //   g.DrawRectangle(p, x, y, sqx, sqy);
                                               // else
                                                //   g.DrawRectangle(p, cirx, ciry, sqx, sqy);

                //check for fill
                if (fill)
                {
                    S.FillShape(fillin, x, y, cirx, ciry);

                    //r.FillShape(fillin, x, y, cirx, ciry);

                    /* This is version 2 code without the object call. You this to 
                     * revert to previous version for testing / troubleshooting */

                             //if (x < cirx && y > ciry)
                                //    g.FillRectangle(fillin, x, ciry, sqx, sqy);
                                   //else if (y < ciry && x > cirx)
                                    //    g.FillRectangle(fillin, cirx, y, sqx, sqy);
                                        //else if (x < cirx && y < ciry)
                                            //    g.FillRectangle(fillin, x, y, sqx, sqy);
                                                 // else
                                                     //    g.FillRectangle(fillin, cirx, ciry, sqx, sqy);
                }
            }
            if (index == 5)
            {
                g.DrawLine(p, cirx, ciry, x, y);
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (draw)
            {
                if(index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
               
                
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;

            if (index == 4) //used during mose move event only
            {
                sqx = rectwidth(x,cirx);
                sqy = rectheight(y, ciry) ;
            }
            else
                //uncompensated.  //mose move event only. updates height and width
                sqx = (x - cirx);
                sqy = (y - ciry);
        }

        private int rectwidth(int final, int start)
        {
            //returns the absolute value of the generic  width for
            //compensating for different rectangle directions.
            int width;
            width = Math.Abs(final - start);
            return width;

        }
        private int rectheight(int final, int start)
        {
            //returns the absolute value of the generic  width for
            //compensating for different rectangle directions.
            int height;
            height = Math.Abs(final - start);
            return height;

        }
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_ellipse_Click(object sender, EventArgs e)
        {

            //sets shape to an ellipse

            index = 3;
            S = new Ellipse(bm);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;   //sets the drawing pattern to a freeform pencil line.

        }
    }
}
