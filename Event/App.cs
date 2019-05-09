using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class App
    {
        private GameLauncher launcher;
        //public event EventHandler ThresholdReached;

        public App()
        {
            this.launcher = new GameLauncher();
        }

        public void Start()
        {
            //var eventArgs = new EventArgs();
            //this.OnThresholdReached(EventArgs.Empty);
            //this.OnThresholdReached(eventArgs);

            this.launcher.Init();
        }

        //protected virtual void OnThresholdReached(EventArgs e)
        //{
        //    EventHandler handler = ThresholdReached;
        //    handler?.Invoke(this, e);
        //    //Invoke = 발생시키는 것, handler가 !null 이면 Invoke 실행
        //    //handler.Invoke(this, e);와 같다. 위는 C#6.0에서 새로 나온 문법
        //    // ?. : Null Conditional operator
        //}
    }
}
