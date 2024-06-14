using System.ComponentModel.DataAnnotations;

namespace imageUploading.Models
{
    public class Gallery
    {
        [Required(ErrorMessage = "Given Name is required.")]
        [Display(Name = "Given Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Image File is required.")]
        [Display(Name = "Image File")]
        public string image { get; set; }

        [Required(ErrorMessage = "Family Name is required.")]
        [Display(Name = "Family Name")]
        public string FamilyName { get; set; }

        [Required(ErrorMessage = "Email Address is required.")]
        [Display(Name = "Email Address")]
        [EmailAddress(ErrorMessage = "Invalid Email Address.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Home Address is required.")]
        [Display(Name = "Home Address")]
        public string HomeAddress { get; set; }

        [Required(ErrorMessage = "Summary is required.")]
        [Display(Name = "Summary")]
        public string Summary { get; set; }

        [Required(ErrorMessage = "Experience is required.")]
        [Display(Name = "Experience")]
        public string Experience { get; set; }

        [Required(ErrorMessage = "Education is required.")]
        [Display(Name = "Education")]
        public string Education { get; set; }

        [Required(ErrorMessage = "Certificate is required.")]
        [Display(Name = "Certificate")]
        public string Certificate { get; set; }

        //SKILLS
        public bool HTML { get; set; }
        public bool CSS { get; set; }
        public bool JavaScript { get; set; }
        public bool Python { get; set; }
        public bool React { get; set; }
        public bool Nodejs { get; set; }
        public bool Angular { get; set; }
        public bool Java { get; set; }
        public bool Csharp { get; set; }
        public bool PHP { get; set; }

        //HOBIES
        public bool Reading { get; set; }
        public bool Sports { get; set; }
        public bool Music { get; set; }
        public bool Travel { get; set; }
        public bool Cooking { get; set; }
        public bool Gaming { get; set; }
        public bool Photography { get; set; }
        public bool Painting { get; set; }
     

    }
}
