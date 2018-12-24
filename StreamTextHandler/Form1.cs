using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace StreamTextHandler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // List of codes for any other keys: https://docs.microsoft.com/en-us/windows/desktop/inputdev/virtual-key-codes
            Boolean win = Form1.RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 0x0000, 0x6B);  // Add Key
            Boolean loss = Form1.RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 0x0000, 0x6D); // Subtract Key
            Boolean draw = Form1.RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 0x0000, 0x6A); // Multiply Key
        }

        private void Form1_Load(object sender, EventArgs e) { UpdateRecord(); }

        private void UpdateRecord()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string output = textBox_style.Text.Replace("{W}", textBox_W.Text).Replace("{L}", textBox_L.Text).Replace("{D}", textBox_D.Text);
            File.WriteAllText(path + "/KadeWinLoss.txt", output);
        }

        private void button_Update_Click(object sender, EventArgs e) { UpdateRecord(); }

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                Keys key = (Keys)(((int)m.LParam >> 16) & 0xFFFF);
                switch (key.ToString()) {
                    case "Add": textBox_W.Value++; UpdateRecord(); break;
                    case "Subtract": textBox_L.Value++; UpdateRecord(); break;
                    case "Multiply": textBox_D.Value++; UpdateRecord(); break;
                    default: Console.WriteLine("Unknown?"); break;
                }
            }
            base.WndProc(ref m);
        }
    }
}
