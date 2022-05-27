PhotoBlog İzlenecek Adımlar
1) EF paketleri kurulur.
	Install-Package Microsoft.EntityFrameworkCore -v 5.0.17
	Install-Package Microsoft.EntityFrameworkCore.SqlServer -v 5.0.17
	Install-Package Microsoft.EntityFrameworkCore.Tools -v 5.0.17
	
2) Modeller
	- classlar
	- prop
	- nav prop
	- Annotation

3) AppDbContext
4) appsetting.json => ConnectionString
5) Startup.cs/ConfigureServices.... AddDbContext....
6) Migration
	-add-migration first
	-update-database

7) Program.cs ' de Seed Data eklenir.
8) Home/Index sayfasında girdiler listelenir.
9) Ana sayfada hashtag/başlık arama özelliği yapılır.
10) Tarih ve saatleri göreceli yapılır. (moment.js)
11) Admin paneli yapılır
	- asp-area-admin oluşturulur
	- adminLayout template
	- Girdilerin CRUD işlemleri
	
	
Resim1
Tagler
- yol
- su
- ev
- güneş

Resim2
Tagler
- yol
- su
- ağaç
-şehir

Resim3
Tagler
- ağaç
- su
- ev

Tagler => yol, su, ev, güneş, ağaç, şehir