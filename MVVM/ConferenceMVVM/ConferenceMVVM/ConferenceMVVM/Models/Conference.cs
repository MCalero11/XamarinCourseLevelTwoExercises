using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceMVVM.Models
{
    class Conference
    {
        private string _Photo;

        public string Photo
        {
            get { return _Photo; }
            set { _Photo = value; }
        }

        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        private string _Datetime;

        public string Datetime
        {
            get { return _Datetime; }
            set { _Datetime = value; }
        }
    }
}
