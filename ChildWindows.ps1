
Add-Type -TypeDefinition @'
using System;
using System.Text;
using System.Runtime.InteropServices;
using System.Collections;
using System.Collections.Generic;

namespace Scratch5
{
    public class WindowHandleInfo
    {
        private delegate bool EnumWindowProc(IntPtr hwnd, IntPtr lParam);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool EnumChildWindows(IntPtr window, EnumWindowProc callback, IntPtr lParam);

        [DllImport("user32.dll")]
        public static extern int GetWindowText(int hWnd, StringBuilder title, int size);

        public static int GetWindowTitle(int hwnd)
        {
            StringBuilder title = new StringBuilder(256);
            return GetWindowText(hwnd, title, 256);
        }

        private IntPtr _MainHandle;

        public WindowHandleInfo(IntPtr handle)
        {
            this._MainHandle = handle;
        }

        public List<IntPtr> GetAllChildHandles()
        {
            List<IntPtr> childHandles = new List<IntPtr>();

            GCHandle gcChildhandlesList = GCHandle.Alloc(childHandles);
            IntPtr pointerChildHandlesList = GCHandle.ToIntPtr(gcChildhandlesList);

            try
            {
                EnumWindowProc childProc = new EnumWindowProc(EnumWindow);
                EnumChildWindows(this._MainHandle, childProc, pointerChildHandlesList);
            }
            finally
            {
                gcChildhandlesList.Free();
            }

            return childHandles;
        }

        private bool EnumWindow(IntPtr hWnd, IntPtr lParam)
        {
            GCHandle gcChildhandlesList = GCHandle.FromIntPtr(lParam);

            if (gcChildhandlesList == null || gcChildhandlesList.Target == null)
            {
                return false;
            }

            List<IntPtr> childHandles = gcChildhandlesList.Target as List<IntPtr>;
            childHandles.Add(hWnd);

            return true;
        }
    }
}
'@

$AllChildWindowHandles = (New-Object Scratch5.WindowHandleInfo ($P.MainWindowHandle)).GetAllChildHandles() 

$AllChildWindows = $AllChildWindowHandles | %{
    $SB = New-Object System.Text.StringBuilder(256); 
    $Null = [Scratch5.WindowHandleInfo]::GetWindowText($_, $SB, 256); 
    New-Object psobject -Property ([ordered]@{
        Handle = $_;
        Text = $SB.ToString().Trim() -replace '\s{6,}.*'
        })
    }
    
$ICW = $AllChildWindows | ? {
        $_.Text -match 'Input'
    }