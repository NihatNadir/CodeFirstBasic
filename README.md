# CodeFirstBasic ENG || TR

## Entityframework CodeFirst approach
- Installed Microsoft.EntityFrameworkCore, Microsoft.EntityFrameworkCore.SqlServer, and Microsoft.EntityFrameworkCore.Tools.
- Created a Data folder and a new folder called Entities inside it.
- Defined classes in the Entities folder that will map to database tables (e.g., Movie, Game).
- Created the PatikaFirstDbContext context inside the Data folder.
- Inside the context, I defined DbSet and used OnModelCreating to configure the table properties (e.g., Movies, Games).
public DbSet<Game> Games => Set<Game>();
public DbSet<Movie> Movies => Set<Movie>();
- The big three steps =>
1. Created a constructor inside the context.
2. In appsettings.json and appsettings.Development, I defined the ConnectionString.
3. In Program.cs, I retrieved the connection string created in step 2 with GetConnectionString and connected them using builder.Services.AddDbContext.
- Ran the Add-Migration and Update-Database commands.
- In the controller, I created a copy of the context. (private readonly PatikaFirstDbContext _context;)
- Injected the context into the controller using Dependency Injection.
- In the controller, I created an IActionResult method to add data to the database and update it. (_context....Add(), _context.SaveChanges())

---

## Entityframework CodeFirst yaklaşımı
- Microsoft.EntityFrameworkCore , Microsoft.EntityFrameworkCore.SqlServer ve Microsoft.EntityFrameworkCore.Tools kurulumunu yaptım.  
- Data klasörü ve içerisinde yeni bir klasör olan Entities oluşturdum.
- Entities klasörüne veritabanı tablosuna dönüşecek olan classları tanımladım. (Movie, Game)
- Data klasörü içerisine PatikaFirstDbContext context oluşturdum.
- Context içerisinde DbSet tanımladım ve OnModelCreating ile tablo özelliklerini tanımladım (Movies, Games)
public DbSet<Game> Games => Set<Game>();
public DbSet<Movie> Movies => Set<Movie>();
- 3 büyükleri =>
1. context içerisinde constructor oluşturdum.
2. appsettings.json => appsettings.Development => ConnectionString tanımladım.
3. program.cs => GetConnectionString ile 2.adımda oluşturulan connectionstring i aldım ve builder.Services.AddDbContext ile bunları bağladım.
- Add-migration ve Update-database komutlarını çalıştırdım.
- Controller'da kopya bir _context oluşturdum. (private readonly PatikaFirstDbContext _context;)
- Controller'da Dependency Injection ile context aldım.
- Controller'da IAction Add veritabanına veri ekleyip veritabanını güncelledim. (_context....Add(), _context.SaveChanges())
