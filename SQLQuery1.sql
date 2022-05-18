-- lấy  tất cả sản phẩm
select * from Products
-- lấy sản phẩm có giá lớn nhất
select  top(1) * from Products
order by UnitPrice DESC
-- tìm các sản phẩm có tên
-- chưa từ khóa "chai"
select * from Products 
where ProductName like '%chai%'
-- tim các sản phẩm có tên bắt đầu băng chữ "Chai"
select * from Products 
where ProductName like 'ch%'
-- tim các sản phẩm có tên kết thúc băng chữ "ng"
select * from Products 
where ProductName like '%ng'
-- tìm các sản phẩm có giá từ 10=> 50
select * from Products 
where UnitPrice > 10 and UnitPrice < 50 
-- tìm các sản phẩm theo CategoryID
select * from Products 
where CategoryID = 8
-- thống kê trong bản Products có bao nhiêu categoryID
select CategoryID from Products 
group by CategoryID
-- thống kê trong bảng sản phẩm 
--mỗi categoryID có bao nhiêu sản phẩm
select CategoryID, COUNT(*) as TongSanPham from Products 
group by CategoryID
-- tinh thanh tiển của các sản phẩm trong kho
-- unitPrice * unitinstock
Select *,UnitPrice * UnitsInStock as ThanhTien
from Products
-- 
select * from Categories
-- 1: tìm theo từ khóa
select * from Categories where CategoryName like '%se%' 
-- 2: tìm theo ma
select * from Categories where CategoryID = 1
-- 3 lấy thông tin sản phẩn và tên của Category tương ứng
select Categories.CategoryName,Products.* 
from Categories,Products
where Categories.CategoryID = Products.CategoryID
-- lấy sản phẩm theo tên và categoryID
Select * from Products
Where CategoryID  = 1 and ProductName like '%ch%'
-- lấy các dơn hàng trong năm 1998
Select * from Orders 
where YEAR(OrderDate) = 1998
-- tìm khách hàng dat hàng nhiều nhất
Select COUNT(*) as SoDonHang,CustomerID  
from Orders
Group by CustomerID
order by SoDonHang DESC
-- lấy thông tin 10 khách hàng đat hàng nhiều nhất
Select * from Customers where 
CustomerID in (
Select top(10) CustomerID  
from Orders
Group by CustomerID
order by  COUNT(*) DESC)

-- tìm các khách hàng có giá trị các don hàng lớn nhất
Select *
from Orders
-- Tính tổng tiền của đơn hàng 10248,10249,10250
select sum( UnitPrice * Quantity) as TongTien 
from [Order Details]
where OrderID in (10248,10249,10250)
-- tính tổng giá trị các đơn hàng 
--của khách hàng "ALFKI"
select sum( UnitPrice * Quantity) as TongTien 
from [Order Details]
where OrderID in (select Orderid 
from Orders 
where CustomerID = 'ALFKI')
-- tính tổng giá trị đơn hàng cho các khách hàng

Select  o.CustomerID,
sum(od.UnitPrice * od.Quantity) as TongTien 
from Orders as o,[Order Details] as od
where o.OrderID = od.OrderID
Group by o.CustomerID 
Order by TongTien desc










