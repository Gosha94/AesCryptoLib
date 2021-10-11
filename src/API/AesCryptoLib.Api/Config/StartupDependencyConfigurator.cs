using Castle.Windsor;
using AesCryptoLib.Core.Contracts;
using Castle.MicroKernel.Registration;
using AesCryptoLib.JsonParser.FileConfigs;
using AesCryptoLib.JsonParser.Repository;

namespace AesCryptoLib.Api.Config
{
    /// <summary>
    /// Класс с конфигурацией зависимостей проекта
    /// </summary>
    internal sealed class StartupDependencyConfigurator
    {
        private WindsorContainer _dependencyContainer;

        #region Constructor

        internal StartupDependencyConfigurator()
        {
            this._dependencyContainer = new WindsorContainer();
        }

        #endregion

        #region Instance Registrator

        internal void RegisterAllInstancesInApplication()
        {
            this._dependencyContainer.Register(Component.For<IReadOnlyUserDataRepository>().ImplementedBy<UserDataRepository>());
            this._dependencyContainer.Register(Component.For<IFileConfiguration>().ImplementedBy<JsonSaltFileConfiguration>());
        }

        #endregion
    }
}
