using ConferenceMVVM.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConferenceMVVM.ViewModels
{
    class ConferenceDetailViewModel
    {
        public string Photo { get; set; }
        public string Title { get; set; }
        public string Date { get; set; }
        public ConferenceDetailViewModel(object e)
        {
            Photo = (e as Conference).Photo;
            Title = (e as Conference).Title;
            Date = (e as Conference).Datetime;
        }
    }
}
