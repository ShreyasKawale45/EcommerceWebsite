using IncomeResourceGroup;
using Microsoft.AspNetCore.Mvc;

namespace IncomeResourceGroup.ViewComponent.Shared
{
	public class FooterViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			try
			{
				return View("~/Views/Shared/Components/_Footer.cshtml");
			}
			catch (Exception ex)
			{
				throw ex;
			}
		}
	}
}
