using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Polyominoes
{
    static class Program
    {
        // TODO --> Build out implementation of algorithm :)
        //test comment
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //create permutations - pass in our 4 polyominoes
            //create board - pass in our numRowsAndCols (4)
            //create engine - pass in board and permutations.EachColor'sPerm

            //create form - pass in our engine
            Application.Run(new PolyominoeForm());
            

        }
    }
}
