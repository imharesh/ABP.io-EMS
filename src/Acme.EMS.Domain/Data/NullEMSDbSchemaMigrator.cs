﻿using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace Acme.EMS.Data;

/* This is used if database provider does't define
 * IEMSDbSchemaMigrator implementation.
 */
public class NullEMSDbSchemaMigrator : IEMSDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
