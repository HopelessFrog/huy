using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using DevExpress.Mvvm;
using huy.Pages;

namespace huy
{
    public class MainViewModel : ViewModelBase
    {
        private Page currentPage;
        public Page CurrentPage 
        {
            get
            {
                return currentPage;
            }
            set
            {
                if (value != currentPage)
                {
                    currentPage = value;
                    RaisePropertiesChanged(nameof(CurrentPage));
                }
            }
        }

        private Page page1 = new Pages.Page1();

        private Page page2 = new Pages.Page2();

        public MainViewModel()
        {
            page1.DataContext = new Page1VM();
            page2.DataContext = new Page2VM();
        }

        public ICommand Page1Command
        {
            get
            {

                return new DelegateCommand(() =>
                {
                    CurrentPage = page1;
                });

            }
        }
        public ICommand Page2Command
        {
            get
            {

                return new DelegateCommand(() =>
                {
                    CurrentPage = page2;
                });

            }
        }

    }
}
