select Products.Name, Categories.Name
from Products
left join Categories
on Products.CategoryId = Categories.Id