using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
namespace RemoteLaunchAppClient
{
    class HostHistory
    {
        private int _maxV = 5;
        private Queue<string> _hostHstory;

        public Queue<string> HostHistoryData
        {
            get { return _hostHstory; }
        }
        
        public HostHistory(StringCollection sc)
        {
            _hostHstory = new Queue<string>();
            if (sc != null)
            {
                foreach (string item in sc)
                {
                    _hostHstory.Enqueue(item);

                }
            }
        }
    
        public Queue<string> UpdateHostHistory(string host)
        {

            if (_maxV < 5 && !_hostHstory.Contains(host))
            {
                _hostHstory.Enqueue(host);
            }
            else if (!_hostHstory.Contains(host))
            {
                if(_hostHstory.Count!=0)
                    _hostHstory.Dequeue();
                _hostHstory.Enqueue(host);
            }

            return _hostHstory;

        }

        public void SaveHostHistory(Properties.Settings s)
        {
            System.Collections.Specialized.StringCollection sc = new System.Collections.Specialized.StringCollection();
            foreach (string i in _hostHstory)
            {
                sc.Add(i);
            }
            Properties.Settings.Default.HostHistory = sc;
            Properties.Settings.Default.Save();
        }
    
    }
}
