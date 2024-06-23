using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

#region JWT Entegrasyonu

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt=>
{
  opt.RequireHttpsMetadata = false;   //https sertifikasý olmadan çalýþtýrýlacaksa false olmalý
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidIssuer = "http://localhost",  //token üreten kiþi
        ValidAudience = "http://localhost", //tokeni kullanacak kiþi

        //tokenin þifreleme algoritmasý
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("asp net core web api jwt project udemy")),
        ValidateIssuerSigningKey = true, //tokenin doðruluðunu kontrol et
        ValidateLifetime = true, //tokenin süresini kontrol et
        ClockSkew = TimeSpan.Zero //tokenin süresi dolmadan önce geçerli olmasýný saðlar
    };
});

#endregion

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
