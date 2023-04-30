using Memory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using System.Reflection.Emit;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {

        private Random rnd = new Random();
        private const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";


        [DllImport("user32.dll")]
        static extern short GetAsyncKeyState(System.Windows.Forms.Keys vKey);
    
        Mem m = new Mem();


      
        public Form1()
        {
            InitializeComponent();
        }
       

        #region Butonla Pid .bin
        private void button1_Click(object sender, EventArgs e)
        {
            string svname = PidLabel.Text;
            if (WithButtonSvNameTextBox.Text == "1")
            {
                PidLabel.Text = "metin2client.bin";
            }
            else if (WithButtonSvNameTextBox.Text == "2")
            {
                PidLabel.Text = "wom2.bin";
            }
            else if (WithButtonSvNameTextBox.Text == "3")
            {
                PidLabel.Text = "Mercure2.bin";
            }

            Process[] processes = Process.GetProcessesByName(svname);
            foreach (Process process in processes)
            {
                int pik = process.Id;
                WithButtonServerPidTextBox.Text = pik.ToString();
            }
        }
        #endregion

        #region F12 lik yer
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            
            if (SafeButtonCheckBox.Checked == true)
            {
                SafeTimer.Start(); /* Combobox */
                timer1.Start();  /* F2 */
            }
            else
            {
                SafeTimer.Stop(); /* Combobox */
                timer1.Stop(); /* F2 */
            }
        }
       

      
        private void SafeTimer_Tick(object sender, EventArgs e) 
        {
            if (ServerCombo.Text == "Aeldra")
            {
                ServerName.Text = "Aeldra";
                ServerBin.Text = "metin2client301.bin";
            }
            else if (ServerCombo.Text == "Wom2")
            {
                ServerName.Text = "Wom2";
                ServerBin.Text = "wom2.bin";
            }
            else if (ServerCombo.Text == "Mercure2")
            {
                ServerName.Text = "Mercure2";
                ServerBin.Text = "metin2client.bin";
            }
        }


        [DllImport("user32.dll")]
        public static extern IntPtr GetWindowThreadProcessId(IntPtr hWnd, out uint ProcessId);
        private int Metin2Pid;

        private void timer1_Tick(object sender, EventArgs e)
        {
            bool ÇekBeniBihter = IsKeyDown(Keys.F2);
            if (ÇekBeniBihter)
            {
                IntPtr foregroundWindow = GetForegroundWindow();
                uint processId;
                GetWindowThreadProcessId(foregroundWindow, out processId);
                Process processById = Process.GetProcessById((int)processId);
                if (SafeButtonCheckBox.Checked)
                {
                    Metin2Pid = processById.Id;
                    ServerPid.Text = "Pid: " + Metin2Pid.ToString();
                    SafeButtonCheckBox.Checked = false;
                }
            }
        }

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();

        static bool IsKeyDown(Keys key)
        {
            return (GetKeyState((int)key) & 0x8000) != 0;
        }

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern short GetKeyState(int key);

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Randomname_Tick(object sender, EventArgs e)
        {
            string randomString = "";
            for (int i = 1; i < 15; i++)
            {
                int index = rnd.Next(chars.Length);
                randomString += chars[index];
            }
            this.Text = randomString;
        }
    }
}

