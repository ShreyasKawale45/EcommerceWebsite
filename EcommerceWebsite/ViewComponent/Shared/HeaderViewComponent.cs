using IncomeResourceGroup;
using Microsoft.AspNetCore.Mvc;

namespace IncomeResourceGroup.ViewComponent.Shared
{
	public class HeaderViewComponent : Microsoft.AspNetCore.Mvc.ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			try
			{
				return View("~/Views/Shared/Components/_Header.cshtml");
			}
			catch (Exception ex) 
			{ 
				throw ex; 
			}
		}
	}
}
