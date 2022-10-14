Program name:MvcMyProject
Program purpose: To review the components of an ASP.NET MVC application
Program suthor: Samir Solanki
Date Created: 2022-09-14 [ISO date format]

1050:FirstStep: Today I Created a new application of ASP.net MVC in .NET core 3.1 framework authentication - Individual Account.
Selected Razor runtime.. will this aactually work ! let us test this and see... [it didnt worked]

1100 - Let execute the application
1105 - Oh it didnt worked reason is This site can't be reached https://localhost:44389/
 Let us try to fix and see if it work
 - Let us open launchSetting.json../.. line no 7 ans comment 
 // "sslPort":44389 //

 After done the comment on // "sslPort":44389 // this Line the code started running. I got the Welcome Screen on browser This link is 
 http://localhost:34699/

 1121: Kept the application running ... testing Razor compile...
 change some content..... index.cshtml - from "Welcome" to "Hello World"........
 VS19 didnt seem to push ... but refereshed the browser and new context displayed


...../////////************ Part 2 .. Doing new chnages as per the part 2 documents.. ********///////////

 - Adding new controller 
 - Right click on "Controller" folder and add the new controller Given name "HelloWorldController.cs"
 - Now you can find the new controller "HelloWorldController.cs" inside "Controllers" Folder

 - In HelloWorldController I have added the new code ad per the documents..
 - Inside public class... added public string Index and return .."This is my default action..."

 - Added new Method Welcome... 
 and added return "This is the Welcome action method..."

 - After running the code and calling the link http://localhost:34699/HelloWorld
  It didnt worked ...
  - Because i have not added the "using System.Text.Encodings.Web;" include in my "HelloWorldController.cs"....
  - After adding this code It worked and gave me output... "This is my default action..."

  - .. Added new code in HelloWorldController.cs 
    .. added new 2 parameters in the line of code name and numTimes (Count) .. this code shows the number of count of browser refresh.

    - I got Error  in this File Because I didnt Commit this line of code ..
    public string Welcome()
        {
            return "This is the Welcome action method...";
        }

     and i wrote new code ..
       public string Welcome(string name, int numTimes = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
 
 -- So i commit old code and the Run the Program it worked ..
 I calledand added this paramter in this link ..http://localhost:34699/HelloWorld/Welcome?name=Samir&numtimes=14
  I got the OUTPUT:- 
.........  Hello Samir, NumTimes is: 14 .......

- I replaced the parameter  from numTimes to ID
 public string Welcome(string name, int ID = 1)...
 and run the Code..
 Added this paramter in link .. http://localhost:34699/HelloWorld/Welcome?name=Samir&ID=14
 and got the output as ..Hello Samir, ID: 14..


 .......//////************. Part 3... To Add the View to ASP>NET MVC app... *********/////////////

 - Create a new Folder inside Views Folder.. and give the name as "HelloWorld"..
 - Cretae a new File insde.. View/HelloWorld Folder and select as RazorView Empty and give the name as "Index.cshtml" 

 - Before creating the View Replace the Code in HelloWorldController.cs file 

 public IActionResult Index()
{
    return View();
}

-After doing the above code, add the file in side View folder/  and give the name as "HelloWorld"..
 Run the file.. You will get the output as .. when you call this link.. http://localhost:34699/HelloWorld ....
 Index
Hello from our View Template!.....

- After this Change the View and Layout Pages....
- we changed the code inside .. Views/Shared/_Layout.cshtm.. 
- I cahanged the Title name to "Movie App"
 and also changed in footer class....

 .. Lets Run the code and call this link ..  http://localhost:34699/Home

 - Now we can see the Title have changed to what we have given as MovieApp....

 - Done changes in View/HelloWorld/Index.cshtml
 .. changed the title to - "Movie List";
 Lets Run the code and call the link .. http://localhost:34699/HelloWorld


- Created a new file "Welcome.cshtml" inside the View/HelloWorld/Welcome.cshtml.. 
.. Now lets run the program....
and call this link .. http://localhost:34699/HelloWorld/Welcome?name=Samir&numtimes=10

 After done this step commit the code and Go to next step to part 4.....


......///************ Part 4... To Add a Modelto an ASP>NET MVC app... **********///////

- First add the Class inside Models Folder and give the name as Movies.cs
- add the line of code using System.ComponentModel.DataAnnotations; in the Movies.cs file or it will show error on line number
 14 on "[DataType(DataType.Date)]"

 - Creted a new Class "MvcMovieContext.cs" inside Data Folder

 - Add the code inside Startup.cs file ...

 i Commented this file ....
 "ConnectionStrings": {
    "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=aspnet-MvcMyProject-1C95EAB8-D7E1-4CD9-BF20-CE7DE52D548D;Trusted_Connection=True;MultipleActiveResultSets=true"

    and added new Code inside appsetting.json file

     "ConnectionStrings": {
    "MvcMyProjectContext": "Server=(localdb)\\mssqllocaldb;Database=MvcMyProjectContext-1;Trusted_Connection=True;MultipleActiveResultSets=true"
  }

  - Created a Scaffold movie page and added the new item in this..... 
  - Let us run the code and check if the database folder is created or not....
  - ohh no the database is not created yet .....

  - I have created an Initial migration in the code by adding the
  "Add-Migration InitialCreate
Update-Database" code in
 NuGet Package Manager > Package Manager Console (PMC).

 Commit all file to Github and check new steps later...

......///************ Part 5... WORKING With Database in ASP>NET... **********///////
