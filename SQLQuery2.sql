--Select
--ANSII Standartı
--Case Insensitive

select * from Customers c left join Orders o on c.CustomerID=o.CustomerID where o.OrderID IS null
select * from Products p left join [Order Details] od on p.ProductID=od.ProductID inner join Orders o on o.OrderID=od.OrderID
select Products.productId, Products.ProductName, Products.UnitPrice,Categories.CategoryName from products inner join Categories on Products.CategoryID=Categories.CategoryID where Products.UnitPrice>10
select count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10
select count(*)Adet from products where CategoryID=2
select *from products where CategoryID=1 order by UnitPrice desc
select * from products order by UnitPrice asc
select * from products order by CategoryId,ProductName
select * from products order by ProductName
Select * from Products where CategoryID=1 and UnitPrice>=10
Select * from Products where CategoryID=1 or CategoryID=3
Select * from Customers where City= 'Berlin'
Select CustomerID, OrderDate from Orders

--DTO Data Transformation Object


 