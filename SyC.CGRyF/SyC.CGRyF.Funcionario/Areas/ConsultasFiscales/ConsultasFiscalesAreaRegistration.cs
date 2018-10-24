using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo.Areas.ConsultasFiscales
{
    public class ConsultasFiscalesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "ConsultasFiscales";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "ConsultasFiscales_default",
                "ConsultasFiscales/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}