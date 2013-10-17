using Abp.Modules;
using Taskever.Application.Services.Dto;
using Taskever.Dependency.Installers;

namespace Taskever.Startup
{
    [AbpModule("Taskever.Application", Dependencies = new[] { "Abp.Modules.Core.Application" })]
    public class TaskeverAppModule : AbpModule
    {
        public override void Initialize(IAbpInitializationContext initializationContext)
        {
            base.Initialize(initializationContext);
            initializationContext.IocContainer.Install(new TaskeverAppInstaller());
            DtoMapper.Map();
        }
    }
}