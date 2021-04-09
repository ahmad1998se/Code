﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Library.Models
{
    public class Min18YearsIfAMember:ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var customer = (Customer)validationContext.ObjectInstance;
            if (customer.MembershipTypeId==MembershipType.Unknown||customer.MembershipTypeId == MembershipType.PayAsYoGo)
            {
                return ValidationResult.Success;
            }

            if (customer.Birthday == null)
                return new ValidationResult("Birthdate is required.");

            var age = DateTime.Today.Year - customer.Birthday.Value.Year;

            return (age >= 18)
                ? ValidationResult.Success
                : new ValidationResult("Should be At least 18 years old");
        }
    }
}