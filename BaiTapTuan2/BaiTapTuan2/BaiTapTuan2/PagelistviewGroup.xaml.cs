﻿using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTapTuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PagelistviewGroup : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public PagelistviewGroup()
        {
            InitializeComponent();
            LoaiHoa l = new LoaiHoa();
            lsthoa.ItemsSource = l.Loaihoas;


        }
    }
}
