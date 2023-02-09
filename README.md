# DvD-Rental

An ASP.NET MVC application made by following along with this course: https://codewithmosh.com/p/asp-net-mvc

A small, locally deployed website that allows users to rent movies from a movie catalog. Site admins are able to do CRUD (Create/Read/Update/Delete) operations to maintain the database. This can be done through the website, or directly via API calls.

Some pages have restricted access to prevent users that aren't logged in from interacting with the page. 
![Restricted Page](https://github.com/Jogira/DvD-Rental/blob/master/Images/Access%20Denial.gif?raw=true)
Accounts can be made using the registration page, which is handled by ASP.NET Core's Identity library. 
![image](https://user-images.githubusercontent.com/46968282/217659958-8de7274f-72d6-4655-bb29-3ebd0ecfd929.png)
Forms also have some custom validation as well. Dropdowns get autopopulated from the database models.
![image](https://user-images.githubusercontent.com/46968282/217667329-efeb394e-c86c-4279-8128-2a67e689eb9b.png)
## CRUD Operations
All CRUD operations for movies can only be done by an admin. 
Movies can get added, including their covers. If it's a valid movie, it gets added to the movie catalog that can be viewed via the movies page or API.
![Added a movie](https://github.com/Jogira/DvD-Rental/blob/master/Images/Adding%20Movie.gif?raw=true)
![image](https://user-images.githubusercontent.com/46968282/217670900-add0a5ec-04d2-4a89-9288-5ddc0c4e3d4d.png)
Movies can deleted by admins. If not logged in as an admin, this option is removed. 
![Deleteing a movie](https://github.com/Jogira/DvD-Rental/blob/master/Images/Deleting%20Movie.gif?raw=true)
(A view of the same page, but logged in as a normal user.)
![image](https://user-images.githubusercontent.com/46968282/217675609-1c7778aa-5808-4550-8243-a744bd4de6a1.png)
Movies can also be edited. Here I changed the genre of Pool Room from Thriller to Sci-Fi and it updates realtime. The datatables plugin was also used to format the movies into a more presentable format, along with adding pagination, ordering, and search functionality. 
![Editing a movie](https://github.com/Jogira/DvD-Rental/blob/master/Images/Editing%20Movie.gif?raw=true)

## Other Site Pages
For administrative purposes, a list of all customers can be viewed as well with all of the same functionality used for movies.
![image](https://user-images.githubusercontent.com/46968282/217679199-59e98633-ea8c-4171-b301-b349a1080d8d.png)
![image](https://user-images.githubusercontent.com/46968282/217679313-a67f8250-95df-4cdd-b73f-6132ee65c423.png)

Movies can also be rented. As long as there is at least one copy of a movie in stock, it will appear when searched for. Both the fields for the customer renting and the movie they're looking for also autopopulates by contacting the customers API. A toast pops up when the rental is complete, and the number of available copies is decremented from the database.
![Renting movie](https://github.com/Jogira/DvD-Rental/blob/master/Images/Renting%20Movie.gif?raw=true)
