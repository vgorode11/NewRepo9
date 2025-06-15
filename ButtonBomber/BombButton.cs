using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ButtonBomber
{
   
    
        public class BombButton : Button
        {
            public bool IsBomb { get; set; } = false;
             public int Index { get; set; }
    }
    
}
