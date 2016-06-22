using MvcMusicStore.InfraStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Models
{
    public class Order:IValidatableObject
    {


         IEnumerable<ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            if (Username != null&&Username.Length>10)
            {
                yield return new ValidationResult("Username length is too high", new[] { "Username" });
            }
           

        }
        public int OrderId { get; set; }
        
        public DateTime OrderDate { get; set; }
        //[Remote("CheckUserNameExists","StoreManager")]
        
        public string Username { get; set; }
        [Required(ErrorMessageResourceType = typeof(ErrorMessages), ErrorMessageResourceName = "LastNameRequired")]

        [StringLength(160,MinimumLength=3)]
        [Display(Name="First Name",Order=1500001)]
        public string FirstName { get; set; }

        [Required]
        //[StringLength(160, MinimumLength = 3)]
        [MusicStoreMaxLength(10,ErrorMessage="Error Message for {0} via Custom error")]
        //[Compare("FirstName")]
        [Display(Name = "Last Name", Order = 15002)]
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        
        public string State { get; set; }
        public string PostalCode { get; set; }
        [DataType(DataType.Password)]
        public string Country { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "Tel:{0} ", NullDisplayText = "No phone found")]
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}")]
        public string Email { get; set; }
       // [Range(10,100)]
        //[ReadOnly(true)]
        public decimal Total { get; set; }





        
    }
}