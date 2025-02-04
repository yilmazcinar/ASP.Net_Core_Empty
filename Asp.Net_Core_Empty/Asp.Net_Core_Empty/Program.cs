var builder = WebApplication.CreateBuilder(args);

// MVC servislerinin eklenmesi.
builder.Services.AddControllersWithViews();


var app = builder.Build();

//Static dosyalar�n kullan�labilmesi i�in eklenen kod.
app.UseStaticFiles();

//Routing i�lemlerinin yap�labilmesi i�in eklenen kod.
app.UseRouting();

//Varsay�lan Route tan�mlamas�.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();


/*
    Controller: Kullan�c�dan gelen iste�i i�leyerek uygun yan�t� olu�turan bile�endir.
    Action: Controller i�indeki metodlard�r ve belirli bir g�revi yerine getirir.
    Model: Verileri temsil eden s�n�flard�r. �� mant���n� ve veriyi ta��r.
    View: Kullan�c�ya sunulan aray�zd�r. Razor kullan�larak HTML ile birle�tirilmi� �ablon dosyalar� i�erir.
    Razor: ASP.NET Core'da HTML i�eri�i dinamik olarak olu�turmak i�in kullan�lan bir i�aretleme s�zdizimidir.
    RazorView: Razor motoru taraf�ndan i�lenen ve kullan�c�ya g�sterilen HTML sayfalar�d�r.
    wwwroot: CSS, JavaScript, resim gibi statik dosyalar�n bulundu�u klas�rd�r.
    
    builder.Build(): Web uygulamas�n� olu�turur ve gerekli servisleri yap�land�r�r.
    app.Run(): Uygulamay� �al��t�r�r ve gelen HTTP isteklerini dinler.
*/