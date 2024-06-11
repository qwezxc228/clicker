using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace clicker
{
    internal class Delay
    {
        private int count = 0;
        private int time;private Action action;
        private System.Windows.Forms.Timer timer1;
        public void Start(System.Windows.Forms.Timer timer1, int time, Action action)
        {
            timer1.Start();
            this.time = time;
            this.action = action;
            this.timer1 = timer1;
        }
        public void Tick()
        {count++;if (count > time)
            {
                action();count = 0;timer1.Stop();
            }
        }
    }
}