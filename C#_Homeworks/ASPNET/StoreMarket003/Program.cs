using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using StoreMarket003.Abstractions;
using StoreMarket003.Contexts;
using StoreMarket003.GraphQL;
using StoreMarket003.Mappers;
using StoreMarket003.Services;

namespace StoreMarket003
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<StoreContext>();
            builder.Services.AddAutoMapper(typeof(MappingProfile));

            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            //builder.Host.ConfigureContainer<ContainerBuilder>(x => x.RegisterType<ProductService>().As<IProductService>());
            builder.Services.AddMemoryCache(m => m.TrackStatistics = true);

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var configuration = new ConfigurationBuilder();
            configuration.SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            var cfg = configuration.Build();

            builder.Host.ConfigureContainer<ContainerBuilder>(x => x.Register(c => new StoreContext(cfg.GetConnectionString("db"))).InstancePerDependency());
            builder.Services.AddDirectoryBrowser();
            //!!!!!
            builder.Services
                .AddSingleton<IProductService, ProductService>()
                .AddSingleton<ICategoryService, CategoryService>()
                .AddSingleton<IStoreService, StoreService>()
                .AddGraphQLServer()
                .AddQueryType<Query>()
                .AddMutationType<Mutation>();
            var app = builder.Build();
            app.MapGraphQL();
            
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
