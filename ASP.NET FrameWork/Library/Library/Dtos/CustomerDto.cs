using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using Library.Models;

namespace Library.Dtos
{
    public class CustomerDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        // [Min18YearsIfAMember] because  we have to endpoint Api and normal app can't cast
        public DateTime? Birthday { get; set; }
        public bool isSubscribedToNewsletter { get; set; }
        public virtual int MembershipTypeId { get; set; }
        public MembershipTypeDto MembershipType { get; set; }

    }
}