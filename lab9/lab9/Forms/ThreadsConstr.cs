using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using XMLGUI.Forms;
using XMLGUI.EventsLib;
using System.Threading;

namespace XMLGUI
{
    public partial class ThreadConstr : Form
    {
        private delegate void SafeCallDelegate(string text);
        public ThreadConstr()
        {
            InitializeComponent();
        }
      
            static int sleeping = 0;
            static object locker = new object();
        
        public static string GetSent()
        {
            string sent="";
            Random r = new Random();
            int cnt = r.Next(1, 14);
            while(cnt>0)
            {
                sent += GetRandom();
                cnt = cnt - 1;
            }
            return sent;
        }

        public static string GetRandom()
        { 
            string[] randoms = new string[26];
            randoms[0] = "a";
            randoms[1] = "c";
            randoms[2] = "d";
            randoms[3] = "e";
            randoms[4] = "f";
            randoms[5] = "g";
            randoms[6] = "h";
            randoms[7] = "i";
            randoms[8] = "j";
            randoms[9] = "k";
            randoms[10] = "l";
            randoms[11] = "m";
            randoms[12] = "n";
            randoms[14] = "o";
            randoms[15] = "p";
            randoms[16] = "q";
            randoms[17] = "r";
            randoms[18] = "s";
            randoms[19] = "t";
            randoms[20] = "u";
            randoms[21] = "v";
            randoms[22] = "w";
            randoms[23] = "x";
            randoms[24] = "y";
            randoms[25] = "z";

            string[] rand = { ".", "?", "!" };
            
            string randsror = "";
            Random r = new Random();
            for (int i = 0; i < 13; i++)  randsror += randoms[r.Next(0, 25)]; 
            randsror += rand[r.Next(0, 3)]; 
            return randsror;
        }

        void main(int num, int time)
        {
            for (int i = 0; i < num; i++)
            {
                Thread myThread = new Thread(Count);

                myThread.Start();
            }
        }
            public void Count()
            {
            Random r = new Random();

                lock (locker)
                {
                for (int i = 1; i < 9; i++)
                    {
                    if (tableView.InvokeRequired)
                    {
                            var d = new SafeCallDelegate(WriteTextSafe);
                            tableView.Invoke(d, new object[] { "user" + Thread.CurrentThread.ManagedThreadId + ": " + GetSent() + Environment.NewLine });
                        tableView.ForeColor = SetColour();

                    }
                     
                        Thread.CurrentThread.Join(sleeping);
                    }
                
            }
            }
        private static Color SetColour()
        {
            Int32 col1 = Thread.CurrentThread.ManagedThreadId * 20;
            while (col1 > 255) { col1 = col1 / 250; }
            Color Res=Color.FromArgb(0, col1, col1);
            return Res;
        }
        
        private void WriteTextSafe(string text)
        {
            //this.tableView.Clear();
            if (tableView.InvokeRequired)
            { 
                var d = new SafeCallDelegate(WriteTextSafe);
                tableView.Invoke(d, new object[] { text });
                
            }
            else
            {
                tableView.Text +=text;
            }
        }
        private void SetText()
        {
            Color color = Color.FromArgb(15, 15, 15);
            Thread.CurrentThread.Join(1000);
        }
        private void filterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuantityThreads setFilterForm = new QuantityThreads();
            setFilterForm.FilterChangeEvent += new EventHandler<FilterChangeEventArgs>(this.OnThreadChangeEvent);
            setFilterForm.Show();
        }
        public void OnThreadChangeEvent(object sender, FilterChangeEventArgs e)
        {

            main(Convert.ToInt32(e.Param),12);
        }

        private void setTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetTime setTimerForm = new SetTime();
            setTimerForm.SetTimeChangeEvent += new EventHandler<SetTimerEventArgs>(this.SetTimeEvent);
            setTimerForm.Show();
        }
        public void SetTimeEvent(object sender, SetTimerEventArgs e)
        {
            sleeping = Convert.ToInt32(e.Param);
        }
    }
}