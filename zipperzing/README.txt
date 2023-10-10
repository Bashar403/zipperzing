
2023-10-09 1835 EST			
Created my ASP.NET Core 3.1 application with the assigned product (Zipper) using Visual Studio 2019

1838
configured HTTPS, and ran the project and made sure it was running smoothly

1839
linked my local project to github to insure it wont be lost and to document my work step by step

1840
going to work on my readme.md and plan my project through the research i did on the weekend

1854
Created a README.md file and updateded it with my plan.

1914
Created a Controller, and View for the about us page and put some temporary text about the company, also added a Navigation Link.

1917
Tested the new About us page and everything works as expected.

1926
Created a Product class in Models. and added the needed attributes

1954
Added A Database Context. and downloaded 3.1

1958
updated the data file and added a name space because startup.cs was giving me and error

2007
updated startup file and appsettings file 

2017
renamed my data file to zipperzingContext and updated startup and appsettings accordingly

2027
added a scaffolded item with the name ProductsController

2031
ran the following commands:
		Add-Migration InitialCreate
		Update-Database

2041 
tested and everything works i need to add this to the url /Products/Index

2128
Added a SeedData file, updated the orginal code to work with my app 
also added 10 products to the seedData and updated my program.cs

2133
Tested the app all products are displayed and the program is working 
also tested the edit and delete.

2023-10-10 1026 EST	
updated the ProductsController bu adding a search feature where in the url you can search up for
zipper by matarial

1032
included a form for the search functuality where it will fillter by matarial.

1130
incountered an error {InvalidOperationException:} while adding the dropdown search function.

1240
fixed the issue, the names in the productsController didnt match the naming of the properties in the models folder










