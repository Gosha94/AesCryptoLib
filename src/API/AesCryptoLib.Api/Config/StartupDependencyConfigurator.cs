﻿using Castle.Windsor;
using AesCryptoLib.Core.Contracts;
using AesCryptoLib.Core.CommonModels;
using Castle.MicroKernel.Registration;
using AesCryptoLib.Core.FileConfigs;

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

        #region Instance Resolvers

        internal IReadOnlyUserDataRepository GetRepositoryInstance()
            => this._dependencyContainer.Resolve<IReadOnlyUserDataRepository>();

        internal IFileConfiguration GetJsonConfigurationInstance()
            => this._dependencyContainer.Resolve<IFileConfiguration>();

        #endregion


    }
}