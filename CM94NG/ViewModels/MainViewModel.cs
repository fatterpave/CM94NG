﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM94NG.Utils;

namespace CM94NG.ViewModels
{
    public class MainViewModel : ObservableObject, IPageViewModel
    {
        public string Name
        {
            get { return "PUSS"; }
        }
    }
}
