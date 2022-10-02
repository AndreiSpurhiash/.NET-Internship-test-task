using Autofac;
using IbanNet.DependencyInjection.Autofac;
using Internship.DAL;
using Internship.DAL.Repositories;
using Internship.Domain.Entity;
using Internship.Service.Interfaces;
using Internship.Service.Implementations;
using Microsoft.EntityFrameworkCore;
using Internship.DAL.Interfaces;

namespace Internship
{
    public class ContainerModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterIbanNet();

            builder.RegisterType<PhotoStockContext>().As<DbContext>().AsSelf().InstancePerLifetimeScope();

            builder.RegisterType<AuthorRepository>().As<BaseRepository<Author>, IAuthorRepository>();
            builder.RegisterType<AuthorService>().As<IAuthorService>();

            builder.RegisterType<PhotoRepository>().As<BaseRepository<Photo>, IPhotoRepository>();
            builder.RegisterType<PhotoService>().As<IPhotoService>();

            builder.RegisterType<TextRepository>().As<BaseRepository<Text>, ITextRepository>();
            builder.RegisterType<TextService>().As<ITextService>();
        }
    }
}
