using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event
{
    public class EventDispatcher
    {
        private static EventDispatcher instance;
        private Dictionary<string, EventHandler<EventArgs>> dicEventHandler = new Dictionary<string, EventHandler<EventArgs>>();

        private EventDispatcher()
        {
            if(EventDispatcher.instance != null)
            {
                throw new Exception("EventDispatcher는 SingleTon Class입니다.");
            }            
        }

        public static EventDispatcher GetInstance()
        {
            if(EventDispatcher.instance == null)
            {
                EventDispatcher.instance = new EventDispatcher();
            }
            return instance;
        }

        //Add event handler
        public void AddEventHandler(string eventName, EventHandler<EventArgs> executeHandler)
        {
            if(!this.dicEventHandler.ContainsKey(eventName))
            {
                this.dicEventHandler.Add(eventName, executeHandler);
                Console.WriteLine("{0}가 등록되었습니다.", eventName);
            }
        }

        //
        public void DispatchEvent(string eventName, EventArgs e)
        {
            var handler = this.dicEventHandler[eventName];
            handler?.Invoke(EventDispatcher.GetInstance(), e);
        }
    }
}
