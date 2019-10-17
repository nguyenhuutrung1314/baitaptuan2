using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BaiTapTuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListviewHoa : ContentPage
    {
        ObservableCollection<hoa> Hoas = new ObservableCollection<hoa>();

        public PageListviewHoa()
        {
            InitializeComponent();
            Hoas.Add(new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "cuc1.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam" });
            Hoas.Add(new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc2.jpg", MoTa = "Hoa cúc vàng, cam, lá măng" });
            Hoas.Add(new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuc3.jpg", MoTa = "Hoa cúc tím" });
            lsvHoa.ItemsSource = Hoas;
        }
        
    }
}
