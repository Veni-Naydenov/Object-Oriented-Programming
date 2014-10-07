using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace AsynchronousTimer
{
    public class AsyncTimer
    {
        private Action<string> actionMethod;
        private int ticks;
        private int interval;

        public AsyncTimer(Action<string> actionMethod, int ticks, int interval)
        {
            this.actionMethod = actionMethod;
            this.ticks = ticks;
            this.interval = interval;
        }

        private void DoTask()
        {
            while (this.ticks > 0)
            {
                Thread.Sleep(this.interval);

                if (actionMethod != null)
                {
                    actionMethod(this.ticks.ToString());
                }

                this.ticks--;
            }
        }

        public void Start()
        {
            Thread thread = new Thread(DoTask);
            thread.Start();
        }
    }
}
