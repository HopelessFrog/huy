﻿using DevExpress.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace huy.Pages
{
    public class Page1VM
    {
        public ICommand ForVlad
        {
            get
            {

                return new DelegateCommand(() =>
                {
                    MessageBox.Show("Vlad lox");
                });

            }
        }
    }
}
