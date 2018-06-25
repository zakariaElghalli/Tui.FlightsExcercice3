using System;
using Unity;

namespace FileReading.Tests
{
    public static class DependencyResolver
    {
        static IUnityContainer Container => container.Value;

        static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static T Resolve<T>() => Container.Resolve<T>();

        public static void RegisterTypes(IUnityContainer container)
        {
            container.RegisterType<IFileReading, ReadTextFile>();
        }
    }
}
