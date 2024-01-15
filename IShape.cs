using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;



/*When fully implemented should allow for general polymorphism and create shapes as required based 
 * on the classes implementing the interface. May need to make methods virtual */
namespace Sweng_example_2
{
    interface IShape
    {

        
        Graphics SetShape(Pen p, int x, int y, int cirx, int ciry);
        Graphics FillShape(Brush b, int x, int y, int cirx, int ciry);

    }
}
