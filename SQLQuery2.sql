--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select * from Customers where City = 'Berlin'

--case insensitive
Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products where CategoryID=1 order by UnitPrice desc    --ascending  --descending

select count (*) Adet from Products 

select CategoryID,count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10






