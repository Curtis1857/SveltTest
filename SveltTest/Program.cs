//using var parcel = new NpmScript();

//await parcel.RunAsync(Console.WriteLine);

//Console.WriteLine(parcel.HasServer
//    ? $"From ASP.NET Core. Parcel is started ({parcel.HasServer}) @ {parcel.Url} at process: {parcel.ProcessId}"
//    : "Script has executed.");

//await Task.Delay(TimeSpan.FromSeconds(4));

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

var app = builder.Build();


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
