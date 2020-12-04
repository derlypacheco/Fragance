using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Fragancy
{
    public class Functions
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        public extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        public extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public void DragElement(IntPtr frmDrag)
        {
            ReleaseCapture();
            SendMessage(frmDrag, 0x112, 0xf012, 0);
        }
    }
}
