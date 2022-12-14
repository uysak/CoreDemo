using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Autofac;
using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Abstract;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.Repository;

namespace BusinessLayer.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EfCategoryRepository>().As<ICategoryDal>().SingleInstance();
            builder.RegisterType<CategoryManager>().As<ICategoryService>().SingleInstance();

            builder.RegisterType<EfBlogRepository>().As<IBlogDal>().SingleInstance();
            builder.RegisterType<BlogManager>().As<IBlogService>().SingleInstance();

            builder.RegisterType<EfCommentRepository>().As<ICommentDal>().SingleInstance();
            builder.RegisterType<CommentManager>().As<ICommentService>().SingleInstance();
        }
    }
}
