using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DaNenTang_Tuan2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Bai1 : ContentPage
    {
        System.Collections.ObjectModel.ObservableCollection<Hoa> Hoas = new System.Collections.ObjectModel.ObservableCollection<Hoa>();
        public Bai1()
        {
            InitializeComponent();
            Hoas.Add(new Hoa { TenHoa = "Đón xuân", Gia = 50000, hinh = "cuc_9.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam" });
            lsvHoa.ItemsSource = Hoas;
        }
    }
}