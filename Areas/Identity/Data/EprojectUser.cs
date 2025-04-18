using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace Eproject.Areas.Identity.Data;

// Add profile data for application users by adding properties to the EprojectUser class
public class EprojectUser : IdentityUser
{

    public string? FirstName { get; set; }


     public string? LastName { get; set; }


     public string?  Role{ get; set; }
}

