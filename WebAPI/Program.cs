using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business.Abstract;
using Business.Concrete;
using Business.DependencyResolver.Autofac;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;

namespace WebAPI
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.
			//Autofac, Ninject, CastleWindsor, StructreMap, LightInject, DryInject -->IoC Container
			//AOP
			//Postsharp
			builder.Services.AddControllers();
			builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
			builder.Host.ConfigureContainer<ContainerBuilder>(myBuilder=> myBuilder.RegisterModule(new AutofacBusinessModule()));
			//builder.Services.AddSingleton<IProductService,ProductManager>();
			//builder.Services.AddSingleton<IProductDal,EfProductDal>();
			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment())
			{
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();
			
			app.UseAuthorization();


			app.MapControllers();

			app.Run();
		}
	}
}
