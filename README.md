IMPORTANT
To view the readme with proper spacing, please click on it in the code and then read it through the source blob option or raw. If that doesn't work, there is also a screenshot in the screenshot folder within the API Final Project Folder.


REQUIREMENTS
I did not complete the finish the consistent response model in time for the due date, but everything else is complete. 
There is a slight error that seems to be happening with the LocationID foreign key in the Items table that references the LocationID in the Locations table. It keeps appearing as null. I think you also experienced this error in class with it showing up as null, but I forget how you fixed it. 


PURPOSE OF THIS API
To track locations and items in the video game Elden Ring and relevant information like whether or not you've discovered a location or found a certain item.


EXAMPLES
Below are 3 example endpoint descriptions, sample request bodies, and sample response bodies for 3 different HTTP methods.
RESPONSE1, REQUEST2, etc are used to reference screenshots in the project folder for code that I didn't know how to format them well into this readme.
As I mentioned earlier, since I didn't finish the consistent response model, the response bodies don't let you know much unless you're using Postman.

Endpoint                    Purpose                                       Request Body                Response Body
GET api/Location            Return info about elden ring locations        N/A                         RESPONSE1
POST api/Location           To add a new location into the database       REQUEST2                    N/A (I didn't finish the consistent response model)
DELETE api/Item/{id}        To delete a specfiic item by ID               N/A                         N/A (I didn't finish the consistent response model)

If I were to have finished the consistent response model in time:
  The response body for POST api/ITEM would let you know whether or not a location was added into the database. 
  The response body for DELETE api/Item/{Id} would let you know whether or not an item was deleted from the database.
   

WRAPPING THOUGHTS
Through this project I learned a lot about SQL, C#, Postman and APIs in general, all of which I had no knowledge of before this class. Though a few concepts were slightly difficult, the class was very informative and a great learning experience. 
