using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActOne
{
    [System.Runtime.InteropServices.ComVisible(true)]
    public class Class1 : Xarial.XCad.SolidWorks.SwAddInEx
    {
        public override void OnConnect()
        {
            Application.ShowMessageBox("Hola Julian");
        }
    }
}
