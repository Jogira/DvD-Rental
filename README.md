# DvD-Rental

An ASP.NET MVC application made by following along with this course: https://codewithmosh.com/p/asp-net-mvc

A small, locally deployed website that allows users to rent movies from a movie catalog. Site admins are able to do CRUD (Create/Read/Update/Delete) operations to maintain the database. This can be done through the website, or directly via API calls.

Some pages have restricted access to prevent users that aren't logged in from interacting with the page. 
![Restricted Page](https://github.com/Jogira/DvD-Rental/blob/master/Images/Access%20Denial.gif?raw=true)
Accounts can be made using the registration page, which is handled by ASP.NET Core's Identity library. 
![image](https://user-images.githubusercontent.com/46968282/217659958-8de7274f-72d6-4655-bb29-3ebd0ecfd929.png)
Forms also have some custom validation as well. Dropdowns get autopopulated from the database models.
![image](https://user-images.githubusercontent.com/46968282/217667329-efeb394e-c86c-4279-8128-2a67e689eb9b.png)
Movies can get added, including their covers. If it's a valid movie, it gets added to the movie catalog that can be viewed via the movies page or API.
![Added a movie](https://github.com/Jogira/DvD-Rental/blob/master/Images/Adding%20Movie.gif?raw=true)
![image](https://user-images.githubusercontent.com/46968282/217670900-add0a5ec-04d2-4a89-9288-5ddc0c4e3d4d.png)


