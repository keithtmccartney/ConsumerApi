# ConsumerApi
A .NET-based API to allow a consumer to save, update and get transactions.

a short description of your API what have used, debugging instructions (don't forget point 1) any comments you wish to add
The time you spent on the project.
If you ran out of time, but would have liked to implemented certain features, tell us why.

## What's inside, right now?

This is an ASP.NET Web Application in 4.6.1 with a Web API template, there is currently no Authentication logic built into the application.

There is a selection of different bits and pieces in here including a Unity IoC Dependency Resolver for a custom Controller with GET/POST/PUT/DELETE logic wrapped-in as core functionality.

Everything is nicely separeted out into Interfaces/Repositories/Containers, and Step structure/Support Files...

## What's to be done, in the future?

The latter is where I intend to take the solution further by splitting out the Selenium Web Driver logic for the Unit Testing (some of this needs re-structuring as I swopped & switched around the logic slightly mid-way through initial building attempting to write the solution more cleanly).

There's the basis for some SpecFlow stuff in here, where I'm yet needing to write up the Feature file/s for when I turn it into something bigger than just an HTTP-verb-machine.

## Okay, fair enough, how do I test the thing?

* [Postman](https://www.getpostman.com/postman) ...I use Postman now for most API testing as I read a book recently on best practices for developing Web API, it suggested to not use the Browser, so try the following JSON in a POST call to ...

{
	"TransactionId": 1,
	"TransactionDate": "2017-10-21T13:28:06.419Z",
	"Description": "'Suppy yuppy yo'!",
	"TransactionAmount": 123,
	"CreatedDate": "2016-10-21T13:28:06.419Z",
	"ModifiedDate": "2017-10-21T13:28:06.419Z",
	"CurrencyCode": "Abc",
	"Merchant": "Def ghi 456"
}

* [The URL for everything](http://localhost:50908/transaction) "Pass '.../transaction/get' (Gets everything), '.../transaction/get/{id}' (Gets something specific), .../transaction/post' (Posts something; use the JSON above as example Body data in Postman), '.../transaction/put/{id}' (Updates something specific), '.../transaction/delete/{id}' (Deletes something specific)"
