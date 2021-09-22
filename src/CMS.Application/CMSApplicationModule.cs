﻿using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using CMS.Authorization;

namespace CMS
{
    [DependsOn(
        typeof(CMSCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class CMSApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<CMSAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(CMSApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
