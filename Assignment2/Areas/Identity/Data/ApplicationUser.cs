using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Assignment2.Areas.Identity.Data;

// Add profile data for application users by adding properties to the ApplicationUser class
public class ApplicationUser : IdentityUser
{
    public string Firstname { get; set; }
    public string Lastname { get; set; }
    public string Location { get; set; }
    public int CompanyID { get; set; }
    public int TravelAgencyID { get; set; }

}
