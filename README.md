# SpaceX_Site

Development Process:
    I first made a working prototype using PHP, since I was more familiar with that than C# for web applications. Once that was up and
  running, I began reading online documentation on how to create a web application using C#. I first created a basic HTML page with a
  table, and wrote code to add rows and cells to the table.
    Once that was finished, I researched a couple different ways to consume a REST API using C#. Since the project was fairly simple, 
  I decided to use HTTPWebRequest to recieve the data. After making sure that a response was received, I created some classes to store
  the data, and used JavaScriptSerializer to convert from JSON to the classes. Then I used the code I had written before to output the
  data in the classes to the table. After writing some basic CSS to display the table correctly, the webpage was finished.
  
  Challenges:
    - Lack of experience with creating webpages in C# and ASP.NET made the task seem daunting, however with a little research I was able
      to overcome any roadblocks this may have caused.
    - Because some of the parameters were nested within other parameters in the JSON data, multiple classes had to be used to retrieve the
      data using JavaScriptSerializer
      
  Thoughts & Feedback:
    Overall a great way to test familiarity with API's and JSON responses. Having done similar projects in Java, I can say that I would
    greatly prefer using C# over Java for web applications like these. One piece of feedback: On the email I received, one of the
    requirements was to include a link to the cargo manifests for each launch. However, looking at SpaceX's API it doesn't seem like such
    information is provided. The closest thing that I could find was a link to the presskits, which included the cargo of each rocket.
