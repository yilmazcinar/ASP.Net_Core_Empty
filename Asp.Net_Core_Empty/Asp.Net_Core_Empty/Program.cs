var builder = WebApplication.CreateBuilder(args);

// MVC servislerinin eklenmesi.
builder.Services.AddControllersWithViews();


var app = builder.Build();

//Static dosyalarýn kullanýlabilmesi için eklenen kod.
app.UseStaticFiles();

//Routing iþlemlerinin yapýlabilmesi için eklenen kod.
app.UseRouting();

//Varsayýlan Route tanýmlamasý.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");



app.Run();


/*
    Controller: Kullanýcýdan gelen isteði iþleyerek uygun yanýtý oluþturan bileþendir.
    Action: Controller içindeki metodlardýr ve belirli bir görevi yerine getirir.
    Model: Verileri temsil eden sýnýflardýr. Ýþ mantýðýný ve veriyi taþýr.
    View: Kullanýcýya sunulan arayüzdür. Razor kullanýlarak HTML ile birleþtirilmiþ þablon dosyalarý içerir.
    Razor: ASP.NET Core'da HTML içeriði dinamik olarak oluþturmak için kullanýlan bir iþaretleme sözdizimidir.
    RazorView: Razor motoru tarafýndan iþlenen ve kullanýcýya gösterilen HTML sayfalarýdýr.
    wwwroot: CSS, JavaScript, resim gibi statik dosyalarýn bulunduðu klasördür.
    
    builder.Build(): Web uygulamasýný oluþturur ve gerekli servisleri yapýlandýrýr.
    app.Run(): Uygulamayý çalýþtýrýr ve gelen HTTP isteklerini dinler.
*/