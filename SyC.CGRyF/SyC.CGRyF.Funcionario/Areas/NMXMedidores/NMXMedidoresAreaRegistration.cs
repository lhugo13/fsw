using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo.Areas.NMXMedidores
{
    public class NMXMedidoresAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NMXMedidores";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NMXMedidores_default",
                "NMXMedidores/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}