select HoaDon.Sohd,Ngaylap,Nguoilap,Makh,Manv,SanPham.Masp,Tensp,SanPham.Soluong,SanPham.Dongia,NSX,SanPham.Soluong*SanPham.Dongia as ThanhTien 
from HoaDon,SanPham,CTBanHang 
where HoaDon.Sohd = CTBanHang.Sohd and SanPham.Masp = CTBanHang.Masp