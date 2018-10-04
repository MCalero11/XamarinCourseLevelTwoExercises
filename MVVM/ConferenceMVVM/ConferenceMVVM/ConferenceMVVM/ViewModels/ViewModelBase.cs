using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ConferenceMVVM.ViewModels
{
    class ViewModelBase : INotifyPropertyChanged
    {
        public string Title { get; set; }
        public bool IsBusy { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
