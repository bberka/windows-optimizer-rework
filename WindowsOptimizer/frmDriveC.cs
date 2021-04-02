using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Diagnostics;

namespace WindowsOptimizer
{
    public partial class frmDriveC : Form
    {
        public frmDriveC()
        {
            InitializeComponent();
        }
        enum RecycleFlags : int
        {
            SHRB_NOCONFIRMATION = 0x00000001, // Don't ask for confirmation
            SHRB_NOPROGRESSUI = 0x00000001, // Don't show progress
            SHRB_NOSOUND = 0x00000004 // Don't make sound when the action is executed
        }
        [DllImport("Shell32.dll", CharSet = CharSet.Unicode)]
        static extern uint SHEmptyRecycleBin(IntPtr hwnd, string pszRootPath, RecycleFlags dwFlags);

        //public static string currentdir = Directory.GetCurrentDirectory();//gets current directory 
        public static string userdir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);//gets user directory C:\Users\%username%
        public static string systemdir = Environment.GetFolderPath(Environment.SpecialFolder.System);//gets system32 directory C:\Windows\System32
        public static string desktopdir = userdir + "\\Desktop";//gets desktop directory C:\Users\%username%\desktop
        public static string currentdir = Directory.GetCurrentDirectory();//gets current directory 
        private void btn4_Click(object sender, EventArgs e)
        {
            try
            {
                frmMain.path = Environment.ExpandEnvironmentVariables(@"C:\Windows\Prefetch");
                frmMain.delfile();
                MessageBox.Show("Prefetch files successfully deleted.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("This tool does not have the permission to delete these files instead tool will open the file directory and you can delete files that not being used currently.\n It is possible you may not have the permission to do if so just disable prefetch and superfetch from Performance section. ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                System.Diagnostics.Process.Start(@"C:\Windows\Prefetch");
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            frmMain.path = Environment.ExpandEnvironmentVariables(userdir + "\\Downloads");
            frmMain.delfile();
            MessageBox.Show("Download folder has been cleared!");
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            frmMain.path = Environment.ExpandEnvironmentVariables("C:\\Windows\\Temp");
            frmMain.delfile();

            frmMain.path = Environment.ExpandEnvironmentVariables(userdir + "\\AppData\\Local\\Temp");
            frmMain.delfile();
           

            frmMain.path = Environment.ExpandEnvironmentVariables(@"C:\Windows.old");
            File.Delete(frmMain.path);

            MessageBox.Show("Useless system files has been deleted!","Information", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            try
            {
                // Execute the method with the required parameters
                uint IsSuccess = SHEmptyRecycleBin(IntPtr.Zero, null, RecycleFlags.SHRB_NOCONFIRMATION);
                MessageBox.Show("Recycle bin has been cleared!");
            }
            catch
            {
                // Handle exceptions
                MessageBox.Show("The recycle bin couldn't be recycled", "Clear recycle bin", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("cleanmgr.exe");
        }

        private void frmDriveC_Load(object sender, EventArgs e)
        {

        }
    }
}
