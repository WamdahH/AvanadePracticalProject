# Avanade Practical Project Specification

## Requirement Analysis

### Creating an application that generates &quot;Objects&quot; upon a set of predefined rules.

For example:

Account number and prize generator.

D&amp;D style character generator.

Theme and setting generator for short stories.

Data generator to seed a new Database.

&#39;Magic 8 Ball&#39;

Fortune Teller

### Architecture

You are required to create a service-orientated architecture for your application, this application must be composed of at least 4 services that work together.

**Service 1**

The core service – this will render the HTML you need to interact with your application, it will also be responsible for communicating with the other 3 services, and finally for persisting some data in an SQL database.

**Service 2 + 3**

These will both generate a random &quot;Object&quot;, this object can be whatever you like as we encourage creativity in this project.

You can create the &quot;Object&quot; however you like, some methods will be more complex but therefore show a greater technical understanding and flexibility, examples of how you can generate your &quot;Object&quot; are:

- Random number
- Random letter
- Pull an item from an Array
- Pull from a .csv
- Pull from a database
- API call to an external API

**Service 4**

This service will also create an &quot;Object&quot; however this &quot;Object&quot; must be based upon the results of service 2 + 3 using some pre-defined rules.

The complexity of your logic here is up to you, again a simple implementation is allowed, however, may not showcase your full understanding of the technology.

### Different Implementations

For services 2, 3 and 4 you need to create 2 different implementations, you must be able to demonstrate swapping these implementations out for each other seamlessly, without disrupting the user experience.

## Planning

To achieve my requirements, I am going to produce an account number and prize generator app which should allow the user to be able to, generate a random account number which starts with 3 uppercase characters and ends in 6 numbers. The Second imp mentation should start with 2 lowercase characters and 8 numbers.

When the account number is generated and the output is &quot;ABC123456&quot;, because the first letter of the Account Number is &quot;A&quot; the user has a 25% chance to win £100 and a 75% chance to win £50. The Back-end completes the logic to decide the prize number, based upon the account number originally created, and displays this for the user.

### Project Tracking

For this project I have decided to generate a random account number with three letters and three numbers.

To be able to plan and keep track of my tasks I will be using a trello board with full expansion on tasks needed to complete the project.

![](RackMultipart20210623-4-dgptdv_html_9ecd7de34bf6526f.png)

Each card signifies the requirements of the project, once I have started working on a card, I can move it to In Progress and when finished it will be moved to Done.

[Avanade | Trello](https://trello.com/b/MkQg5iIL/avanade)

### Structure

![](RackMultipart20210623-4-dgptdv_html_f5c4ec84b0e9aa53.png)

Frontend service will communicate with the merge service and then be input into the random number service and the random number service.

### Risk Assessment

| **Description** | **Evaluation** | **Likelihood** | **Impact Level** | **Responsibility** | **Response** | **Control Measures** |
| --- | --- | --- | --- | --- | --- | --- |
| Stored Account Numbers on generator site | Users often allow the website to store their generated account number | High | High | Wamdah Hassan |
 | Store Account numbers in an encrypted database and are otherwise protected by top-of-the-line security protocols. |
| Stored account numbers on convenient browser plugins | Often users allow to website to store their details so as they&#39;re browsing the web they can auto-fill their account details to access online accounts for you. | High | High | Wamdah Hassan |
 | Store Account numbers in an encrypted database and are otherwise protected by top-of-the-line security protocols. |
| Data Breach | When customers use an account generator, they have now trusted this website not to put their data (account number) at risk or be exposed | Low | Low | Wamdah Hassan | As this is a random account number generator, no data is stored onto the site. Therefore, no data is put at risk |
 |
| Repeated Account Number | The random account generator could repeat the same account number for different users. | Medium | Medium | Wamdah Hassan | Display an error message, informing the user that this account number has been taken | Create a database and assigned generated account number to an ID so that the same number cannot be repeated |

## Software Design and Development

![](RackMultipart20210623-4-dgptdv_html_396872b8f9356307.png)

Created a new ASP.Net Core Web App MVC for the front-end service and three Web API&#39;s projects for service two, three and merge.

### F ![](RackMultipart20210623-4-dgptdv_html_4e317ca4fa2e2253.png) ront-End Controller

The Front end controller calls the merge service and returns the view to the webpage.

![](RackMultipart20210623-4-dgptdv_html_5a72a692c6640f47.png)

In the front end appsettings.json ive added the local host link for the merged service so that the front end calls the merged service.

### Merge Controller

![](RackMultipart20210623-4-dgptdv_html_bf4c75dfa3f3729b.png)Merge Controller takes the input, calls the random number service and gets the response, does the same for the letters service and merges them together.

![](RackMultipart20210623-4-dgptdv_html_dfa6335e771d2994.png)

In the merge controller appsettings.json, I have added the local hosts for the numbers and letters service so that the merge service calls them.

### Random Number Controller

![](RackMultipart20210623-4-dgptdv_html_8123838e5c6cd94d.png)

When attempting to generate a single random number between 10 and 50 , the webpage would return this:

![](RackMultipart20210623-4-dgptdv_html_9ba83192a59cb64b.png)

This error occurred because I was using console writeline however this was wrong.

![](RackMultipart20210623-4-dgptdv_html_5f80c74a3968d137.png)

I tried different methods of trying to obtain two randoms numbers, one of which is 6 digits and the other 8 digits, however whenever I debugged these, the webpage would return :

![](RackMultipart20210623-4-dgptdv_html_2bbad3dc390ef7e5.png)

I had no operations defined in my code and was not returning anything to be output.

![](RackMultipart20210623-4-dgptdv_html_c7644da663d83a52.png)

In my final random number code, you are able to set a certain length for the number string and it will generate another random number for the length of string that has been input.

### Random Letter

![](RackMultipart20210623-4-dgptdv_html_284500046e3d15d.png)

With the random letter controller, I received the same error as with the random number, so I had to put in an action result function.

![](RackMultipart20210623-4-dgptdv_html_bc35518ca2bf55da.png)

The final code for the random letters returns two upper case letters, and three lowercase letters.

### Debugging

While debugging I came across the error below:

![](RackMultipart20210623-4-dgptdv_html_c79b6cc6986f7fb5.png)

I had named one of my controllers incorrectly, so it was not calling the random numbers controller.

H ![](RackMultipart20210623-4-dgptdv_html_ed01ce474b19ddf6.png) owever, I continued to get this error, this was because my numbers and letters controller needed an input value.

So I had to add the length at the end of the url for the merge service.

### Testing

For testing I created an Xunit test project, and created four different folders for merge, random letters and random numbers. (Service one two and three)

![](RackMultipart20210623-4-dgptdv_html_c7a0d88b60dbf120.png)

![](RackMultipart20210623-4-dgptdv_html_363637292079e62e.png)

So, in the first line is my Arrange, the second line is my get actions, which is getting the number from my random number controller. And then the last two lines are the Assert, which is testing whether the return value is not null. The second test is checking if I am returning action result of string.

Since I will be testing using IOptions for configuration, I have added appsettings.cs. In my startup.cs file I have modified my constructor, instead of injecting I configuration, I am injecting IWebHostEnvireonment. By doing this I am telling the project on startup to create a new configuration builder and set the base part of the environment variables and making the configuration equal to the final build action which results in an Iconfiguration file. I then inject IOptions of appsettings into my controllers

![](RackMultipart20210623-4-dgptdv_html_4afecd08c731d7dc.png)

In my merge controller tests, I created a new instance of my appsettings.cs file, and inserted a url of my published appsettings files. Creating a mock of IOptions of appsettings, so that it will return the values that are in my published services.

![](RackMultipart20210623-4-dgptdv_html_bb15d1896a14272c.png)

When running my tests I had no errors, although the merge test took 435ms

![](RackMultipart20210623-4-dgptdv_html_68da242287a0c839.png)

I generated my test report

![](RackMultipart20210623-4-dgptdv_html_be4a2a094de9ef9d.png)

I would have also liked to include the prize generator in the future if more time was available.

## Terraform

![](RackMultipart20210623-4-dgptdv_html_a5d0c8fd3de7524e.png)

Setting terraforms description language to hashicorp.

![](RackMultipart20210623-4-dgptdv_html_f3437d2a1e09475.png)

Created a resource type using azure resource group and labelling it rg, azureresource group which is also the cloud service provider, I then labelled my group of properties, setting the name of my resource group and setting the location. I have then created my app service plan and named it Wamdah-app-svc, using windows as the os type. Using the B1 service basic plan, and specified the resource group it belongs to, and used the declared variable.

![](RackMultipart20210623-4-dgptdv_html_cf2405e66dfb1a28.png)

I have created four appservices for my front end, merge, randletter and randnumbers, then set the resource group and appservice plan I would like to use.

Then using the commands:

1. Install the plugins we&#39;ve specified: terraform init
2. Check what Terraform plans to do with this configuration and check it&#39;s correct: terraform plan
3. Apply this configuration, and build our resources: terraform apply

Now going to azure portal:

![](RackMultipart20210623-4-dgptdv_html_7b0165d6f5089224.png)

I can see my resource group has been created and my appservices.

## Deployment

I used GitHub Actions to deploy my webapp, first I started by publishing each service separately creating a yml file for each. After publishing I then pushed to github however, my workflow kept failing.

![](RackMultipart20210623-4-dgptdv_html_565b639f2df2ae34.png)

I went back to my yml file to check where the error was, realised I had to edit the AZURE\_WEBAPP\_PACKAGE\_PATH and WORKING\_DIRECTORY, as they did not contain the correct path.

![](RackMultipart20210623-4-dgptdv_html_d20f79e81fdfae5d.png)

Above is the correct path however before the path was &quot;FrontEnd/publish&quot;.

Now pushing this to github and my app successfully deployed.

![](RackMultipart20210623-4-dgptdv_html_1b01c6fdc8fd8780.png)

![](RackMultipart20210623-4-dgptdv_html_f164fd83fe8f0090.png)

The jobs I would like to run on my workflow are contained in the yml file, using .NetCore and using github actions are, restore, using dotnet restore, Build using dotnet build, Test, publish and deploy all using dotnet.

On Azure Portal I now need to go to the front end service and add an application string.

![](RackMultipart20210623-4-dgptdv_html_cecf47a0f9abb49d.png)

The value of this application string would be the published url of the merge service, as the front end needs to call the merge service.

The application strings for the merge service would be the published random numbers and letters url.

![](RackMultipart20210623-4-dgptdv_html_d4e5e9760797da2f.png)

My final webapp page.
