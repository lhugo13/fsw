using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo.Areas.Compensaciones
{
    public class CompensacionesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Compensaciones";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Compensaciones_default",
                "Compensaciones/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "SyC.CGRyF.Administrativo.Areas.Compensaciones.Controllers" }
            );
        }
    }
}