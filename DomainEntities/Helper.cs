using System.Collections.Generic;
using System.Web.Mvc;
//using Microsoft.AspNetCore.Mvc.Rendering;
namespace Models
{
    public static class Helper
    {
        public static string Admin = "Admin";
        public static string User = "User";

        
        public static int success_code = 1;
        public static int failure_code = 0;

        public static List<SelectListItem> GetRolesForDropDown(bool isAdmin)
        {
            if (isAdmin)
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Admin,Text=Helper.Admin}
                };
            }
            else
            {
                return new List<SelectListItem>
                {
                    new SelectListItem{Value=Helper.Admin,Text=Helper.Admin},
                    new SelectListItem{Value=Helper.User,Text=Helper.User},
                };
            }
        }

    }
}
