# Avanade Practical Project Specification

## Requirement Analysis

### Creating an application that generates “Objects” upon a set of predefined rules.

For example:

Account number and prize generator.

D&D style character generator.

Theme and setting generator for short stories.

Data generator to seed a new Database.

‘Magic 8 Ball’

Fortune Teller

### Architecture

You are required to create a service-orientated architecture for your application, this application must be composed of at least 4 services that work together.

**Service 1**

The core service – this will render the HTML you need to interact with your application, it will also be responsible for communicating with the other 3 services, and finally for persisting some data in an SQL database.

**Service 2 + 3**

These will both generate a random “Object”, this object can be whatever you like as we encourage creativity in this project.

You can create the “Object” however you like, some methods will be more complex but therefore show a greater technical understanding and flexibility, examples of how you can generate your “Object” are:

- Random number
- Random letter
- Pull an item from an Array
- Pull from a .csv
- Pull from a database
- API call to an external API

**Service 4**

This service will also create an “Object” however this “Object” must be based upon the results of service 2 + 3 using some pre-defined rules.

The complexity of your logic here is up to you, again a simple implementation is allowed, however, may not showcase your full understanding of the technology.

### Different Implementations

For services 2, 3 and 4 you need to create 2 different implementations, you must be able to demonstrate swapping these implementations out for each other seamlessly, without disrupting the user experience.

## Planning

To achieve my requirements, I am going to produce an account number and prize generator app which should allow the user to be able to, generate a random account number which starts with 3 uppercase characters and ends in 6 numbers. The Second imp mentation should start with 2 lowercase characters and 8 numbers.

When the account number is generated and the output is “ABC123456”, because the first letter of the Account Number is “A” the user has a 25% chance to win £100 and a 75% chance to win £50. The Back-end completes the logic to decide the prize number, based upon the account number originally created, and displays this for the user.

### Project Tracking

For this project I have decided to generate a random account number with three letters and three numbers.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image1.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image1.jpg)

To be able to plan and keep track of my tasks I will be using a trello board with full expansion on tasks needed to complete the project.

Each card signifies the requirements of the project, once I have started working on a card, I can move it to In Progress and when finished it will be moved to Done.

[Avanade | Trello](https://trello.com/b/MkQg5iIL/avanade)

### Structure

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image2.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image2.jpg)

Frontend service will communicate with the merge service and then be input into the random number service and the random number service.

### Risk Assessment

[Untitled](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/Untitled%20Database%201580fbd7eaf14d0e88c3339979b4cd9b.csv)

## Software Design and Development

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image3.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image3.jpg)

Created a new ASP.Net Core Web App MVC for the front-end service and three Web API’s projects for service two, three and merge.

### Front-End Controller

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image4.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image4.jpg)

The Front end controller calls the merge service and returns the view to the webpage.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image5.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image5.jpg)

In the front end appsettings.json ive added the local host link for the merged service so that the front end calls the merged service.

### Merge Controller

Merge Controller takes the input, calls the random number service and gets the response, does the same for the letters service and merges them together.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image6.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image6.jpg)

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image7.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image7.jpg)

In the merge controller appsettings.json, I have added the local hosts for the numbers and letters service so that the merge service calls them.

### Random Number Controller

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image8.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image8.jpg)

When attempting to generate a single random number between 10 and 50 , the webpage would return this:

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image9.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image9.jpg)

This error occurred because I was using console writeline however this was wrong.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image10.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image10.jpg)

I tried different methods of trying to obtain two randoms numbers, one of which is 6 digits and the other 8 digits, however whenever I debugged these, the webpage would return :

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image11.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image11.jpg)

I had no operations defined in my code and was not returning anything to be output.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image12.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image12.jpg)

In my final random number code, you are able to set a certain length for the number string and it will generate another random number for the length of string that has been input.

### Random Letter

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image13.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image13.jpg)

With the random letter controller, I received the same error as with the random number, so I had to put in an action result function.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image14.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image14.jpg)

The final code for the random letters returns two upper case letters, and three lowercase letters.

### Debugging

While debugging I came across the error below:

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image15.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image15.jpg)

I had named one of my controllers incorrectly, so it was not calling the random numbers controller.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image16.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image16.jpg)

However, I continued to get this error, this was because my numbers and letters controller needed an input value.

So I had to add the length at the end of the url for the merge service.

### Testing

For testing I created an Xunit test project, and created four different folders for merge, random letters and random numbers. (Service one two and three)

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image17.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image17.jpg)

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image18.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image18.jpg)

So, in the first line is my Arrange, the second line is my get actions, which is getting the number from my random number controller. And then the last two lines are the Assert, which is testing whether the return value is not null. The second test is checking if I am returning action result of string.

Since I will be testing using IOptions for configuration, I have added appsettings.cs. In my startup.cs file I have modified my constructor, instead of injecting I configuration, I am injecting IWebHostEnvireonment. By doing this I am telling the project on startup to create a new configuration builder and set the base part of the environment variables and making the configuration equal to the final build action which results in an Iconfiguration file. I then inject IOptions of appsettings into my controllers

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image19.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image19.jpg)

In my merge controller tests, I created a new instance of my appsettings.cs file, and inserted a url of my published appsettings files. Creating a mock of IOptions of appsettings, so that it will return the values that are in my published services.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image20.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image20.jpg)

When running my tests I had no errors, although the merge test took 435ms

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image21.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image21.jpg)

I generated my test report

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image22.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image22.jpg)

I would have also liked to include the prize generator in the future if more time was available.

## Terraform

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image23.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image23.jpg)

Setting terraforms description language to hashicorp.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image24.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image24.jpg)

Created a resource type using azure resource group and labelling it rg, azureresource group which is also the cloud service provider, I then labelled my group of properties, setting the name of my resource group and setting the location. I have then created my app service plan and named it Wamdah-app-svc, using windows as the os type. Using the B1 service basic plan, and specified the resource group it belongs to, and used the declared variable.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image25.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image25.jpg)

I have created four appservices for my front end, merge, randletter and randnumbers, then set the resource group and appservice plan I would like to use.

Then using the commands:

1. Install the plugins we've specified: terraform init
2. Check what Terraform plans to do with this configuration and check it's correct: terraform plan
3. Apply this configuration, and build our resources: terraform apply

Now going to azure portal:

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image26.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image26.jpg)

I can see my resource group has been created and my appservices.

## Deployment

I used GitHub Actions to deploy my webapp, first I started by publishing each service separately creating a yml file for each. After publishing I then pushed to github however, my workflow kept failing.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image27.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image27.jpg)

I went back to my yml file to check where the error was, realised I had to edit the AZURE_WEBAPP_PACKAGE_PATH and WORKING_DIRECTORY, as they did not contain the correct path.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image28.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image28.jpg)

Above is the correct path however before the path was “FrontEnd/publish”.

Now pushing this to github and my app successfully deployed.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image29.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image29.jpg)

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image30.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image30.jpg)

The jobs I would like to run on my workflow are contained in the yml file, using .NetCore and using github actions are, restore, using dotnet restore, Build using dotnet build, Test, publish and deploy all using dotnet.

On Azure Portal I now need to go to the front end service and add an application string.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image31.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image31.jpg)

The value of this application string would be the published url of the merge service, as the front end needs to call the merge service.

The application strings for the merge service would be the published random numbers and letters url.

![Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image32.jpg](Avanade%20Practical%20Project%20Specification%20a688f5d650f1440ea3e0d999d7838086/image32.jpg)

My final webapp page.