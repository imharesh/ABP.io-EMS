using System;
using System.Collections.Generic;
using System.Text;
using Acme.EMS.Localization;
using Volo.Abp.Application.Services;

namespace Acme.EMS;

/* Inherit your application services from this class.
 */
public abstract class EMSAppService : ApplicationService
{
    protected EMSAppService()
    {
        LocalizationResource = typeof(EMSResource);
    }
}
