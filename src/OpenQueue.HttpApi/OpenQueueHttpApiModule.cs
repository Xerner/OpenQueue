using Localization.Resources.AbpUi;
using OpenQueue.Localization;
using Volo.Abp.Account;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Localization;
using Volo.Abp.TenantManagement;
using Volo.Abp.AspNetCore.Mvc;

namespace OpenQueue;

 [DependsOn(
    typeof(OpenQueueApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpAccountHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpTenantManagementHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule)
    )]
public class OpenQueueHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
        //Configure<AbpAspNetCoreMvcOptions>(options =>
        //{
        //    options
        //        .ConventionalControllers
        //        .Create(typeof(OpenQueueApplicationContractsModule).Assembly);
        //});
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<OpenQueueResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
