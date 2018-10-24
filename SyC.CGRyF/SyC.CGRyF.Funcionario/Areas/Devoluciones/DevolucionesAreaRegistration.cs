using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo.Areas.Devoluciones
{
    public class DevolucionesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Devoluciones";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Devoluciones_default",
                "Devoluciones/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}