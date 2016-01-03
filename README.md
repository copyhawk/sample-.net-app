# Copyhawk-Sample-Application
This application will is the result of following the readme steps to get started with Copyhawk.

CopyHawk is a very easy way to manage your content. Follow these simple steps to get started from scratch:
#Pre-requisites:
* Installed .NET 4.5 framework
* Visual Studio (Community 2015 was used for this guide)

#To start from scratch:
1.	Open Visual Studio
2.	File -> New ->  Project
3.	Name your application (Copyhawk.TestApplication used in demo)
4.	Click OK
5.	Right-click your solution
6.	Click on "Manage Nugget Packages For Solution"
7.	Search for "Copyhawk"
8.	Install the CopyHawk.Client in your project
9.	Open Default.aspx
10.	Replace the inner content of the first <h1> tags with the following: 
"<asp:CopyHawk data-label=Footer runat=server></asp:CopyHawk>"
11.	Add "<%@ Register TagPrefix="asp" Namespace="CopyHawkClient" Assembly="CopyHawkClient" %>" to your .aspx page.
12.	Open your web.config file and add the following entry inside the <configuration> tag:
"<appSettings><add key="CopyHawkSiteId" value="566c81dfc1b15e9e1e2d89c7"/></appSettings>"
13.	Run your app!
14.	The main page's html content is now being delivered from CopyHawk!

#Or simply:
1.	Check out: https://github.com/copyhawk/Copyhawk-Sample-Application.git
2.	Open the .sln file in Visual Studio.
3.	Build the solution to restore the missing nugget packages.
4.	Run your app!

We will be adding more functionality after the initial release so please check in with us from time to time.
Thanks,
CopyHawk Team