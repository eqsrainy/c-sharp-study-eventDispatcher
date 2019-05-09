using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class UIButton
    {
        public event EventHandler OnClickEventHandler;

        public UIButton()
        {
    
        }

        public void AddEventListener(EventHandler call)
        {
            this.OnClickEventHandler = call;
        }

        public void Click()
        {
            //이벤트 발생
            this.OnClickEvent(EventArgs.Empty);
        }

        private void OnClickEvent(EventArgs e)
        {
            EventHandler handler = OnClickEventHandler;
            handler?.Invoke(this, e);
        }
    }
}
