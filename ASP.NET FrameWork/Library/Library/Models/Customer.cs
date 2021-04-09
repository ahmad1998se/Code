using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Library.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Enter Customer's name.")]
        [StringLength(255)]
        public string Name { get; set; }
        [Display(Name  ="Date Of Birth")]
        [Min18YearsIfAMember]
        public DateTime? Birthday { get; set; }


        public bool isSubscribedToNewsletter { get; set; }


        [Display(Name = "Membership Type")]
        public virtual int MembershipTypeId { get; set; }

        [ForeignKey("MembershipTypeId")]
        public virtual MembershipType MembershipType { get; set; }


    }
}