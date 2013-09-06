La Marelle's database
=====================
In order to handle registration details for its pupils, La Marelle, a Saturday morning school in Kent, UK, originally used an Access database. When that became unwieldy because only one person could update it, I built an ASP.Net 2.0 Web Forms application to host the database on our website. The data was soon ported from Access to MySQL to provide better updating capabilities and more concurrent users. The result of that project is in my "lamarelle-db" repository.

However, times have moved on and I decided to update the project to a more modern framework. The ASP.Net MVC framework will not only allow test-driven development and improve the maintainability of the application, but also allow the addition of a RESTful API. The latter will be designed for consumption by public forms on the website at http://lamarelle.org.uk, and by a possible future Android app.
