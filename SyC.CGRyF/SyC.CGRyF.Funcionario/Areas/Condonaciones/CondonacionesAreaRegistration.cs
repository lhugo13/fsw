using System.Web.Mvc;

namespace SyC.CGRyF.Administrativo.Areas.Condonaciones
{
    public class CondonacionesAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Condonaciones";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Condonaciones_default",
                "Condonaciones/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional },
                new string[] { "SyC.CGRyF.Administrativo.Areas.Condonaciones.Controllers" }
            );
        }
    }
}