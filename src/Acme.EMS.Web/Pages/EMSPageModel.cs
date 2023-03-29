using Acme.EMS.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Acme.EMS.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class EMSPageModel : AbpPageModel
{
    protected EMSPageModel()
    {
        LocalizationResourceType = typeof(EMSResource);
    }
}
