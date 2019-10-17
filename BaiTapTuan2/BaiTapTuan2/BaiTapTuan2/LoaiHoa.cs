using System;
using System.Collections.Generic;
using System.Text;

namespace BaiTapTuan2
{
    public class LoaiHoa:List<hoa>
    {
        public string TenLoai { get; set; }
        private LoaiHoa(string tenloai)
        {
            TenLoai = tenloai;
        }
        public IList<LoaiHoa> Loaihoas { get; set; }
        public LoaiHoa()
        {
            List<LoaiHoa> l = new List<LoaiHoa>
            {
                new LoaiHoa("Hoa cúc")
                {
                    new hoa { TenHoa = "Đón xuân", Gia = 50000, Hinh = "cuc1.jpg", MoTa = "Hoa cúc các màu: trắng, vàng, cam" },
                    new hoa { TenHoa = "Hồn nhiên", Gia = 60000, Hinh = "cuc2.jpg", MoTa = "Hoa cúc vàng, cam, lá măng" },
                    new hoa { TenHoa = "Tím thủy chung", Gia = 45000, Hinh = "cuc3.jpg", MoTa = "Hoa cúc tím" }
                } ,

                new LoaiHoa("Hoa cưới")
                {
                    new hoa { TenHoa = "Dây tơ hồng", Gia = 250000, Hinh = "cuoi1.jpg", MoTa = "Hoa hồng màu hồng đậm, hoa hồng xanh, các loại lá măng" },
                    new hoa { TenHoa = "cầu thủy tinh", Gia = 220000, Hinh = "cuoi2.jpg", MoTa = "Hoa hồng và hoa thủy tiên trắng" },
                    new hoa { TenHoa = "Duyên thầm", Gia = 26000, Hinh = "cuoi3.jpg", MoTa = "hoa cúc trắng, baby, lá măng" } }
                };
            Loaihoas = l;

        }
    }
    
}
