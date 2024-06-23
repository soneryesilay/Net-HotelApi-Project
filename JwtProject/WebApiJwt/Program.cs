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
  opt.RequireHttpsMetadata = false;   //https sertifikas� olmadan �al��t�r�lacaksa false olmal�
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidIssuer = "http://localhost",  //token �reten ki�i
        ValidAudience = "http://localhost", //tokeni kullanacak ki�i

        //tokenin �ifreleme algoritmas�
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("asp net core web api jwt project udemy")),
        ValidateIssuerSigningKey = true, //tokenin do�rulu�unu kontrol et
        ValidateLifetime = true, //tokenin s�resini kontrol et
        ClockSkew = TimeSpan.Zero //tokenin s�resi dolmadan �nce ge�erli olmas�n� sa�lar
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
