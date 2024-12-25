﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace SignInSignUpUsingIdentity.Areas.Identity.Data;

// Add profile data for application users by adding properties to the SignInSignUpUsingIdentityUser class
public class SignInSignUpUsingIdentityUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Phone {  get; set; }
}

