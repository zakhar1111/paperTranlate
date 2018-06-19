using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Particals
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}

//[Fix] NOt Remove just overstep ---> [TODO] ShowOver step() [TODO] see low level algorithm Splicing()
//[OK] Show_1() impliment by Linq.Where( Predicate<>() )
//[OK] Clear elements alpha less 5 ClearElements(int alphaThreeshould) 
//[TODO] refactoring ClearElements(int){foreach (var el in this.Where(x => !x.ToDelete()))el.Show(gdi);}
//[TODO] Model Controller View=Partical
    //[OK] Canva [W , H]
    //[TODO] Partical Velosity  
    //[TODO] Partical Coordinate
    //[TODO] Partical Controller 
    //[TODO] Partical impl IDisposable
 

