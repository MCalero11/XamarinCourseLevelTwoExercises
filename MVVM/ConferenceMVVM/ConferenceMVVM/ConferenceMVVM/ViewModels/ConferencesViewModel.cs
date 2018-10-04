using ConferenceMVVM.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;

namespace ConferenceMVVM.ViewModels
{
    class ConferencesViewModel : ViewModelBase
    {
        public ObservableCollection<Conference> Conferences { get; set; }
        public ConferencesViewModel()
        {
            Title = "List Conference";
            Conferences = new ObservableCollection<Conference>(FillConferences());
        }

        private IList<Conference> FillConferences()
        {
            return new List<Conference>() {
                new Conference() {
                    Photo = "https://www.dotnetconf.net/Content/img/dotNETConf_banners_facebook_eventinfo.png",
                    Title = ".NET Conf",
                    Datetime = "08/09/2018",
                },
                new Conference() {
                    Photo = "https://www.linuxfoundation.org/wp-content/uploads/2018/04/BCE2018_workshp_linux-2.jpg",
                    Title = "Linux Workshop",
                    Datetime = "04/04/2018",
                },
                new Conference() {
                    Photo = "https://sec.ch9.ms/ch9/9042/b1e34614-8cd6-4355-8571-8704226a9042/M353_960.jpg",
                    Title = "Azure cognitive services",
                    Datetime = "03/10/2018",
                },
                new Conference() {
                    Photo = "https://blog.novoda.com/content/images/2017/11/firebase-devsummit-2017.png",
                    Title = "Firebase Services",
                    Datetime = "24/12/2018",
                },
                new Conference() {
                    Photo = "https://dyjpb62732.i.lithium.com/t5/image/serverpage/image-id/859i607721728F9587CD/image-size/large?v=1.0&px=999",
                    Title = "Github Camp",
                    Datetime = "12/01/2019",
                },
            };
        }
    }
}
