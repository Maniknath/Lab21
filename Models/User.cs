namespace FirstMVCApp.Models
{
    public class User
    {
        //[Key]
        //[Required]
        //[StringLength(10, MinnimumLength=3)]
        public string FisrtName { get; set; }
        public string LastName { get; set; }

        //[MinimumLength(3)]
        //[MaxLength(10)]
        //[Required]
        public string Password { get; set; }

        // [Required]



    }

}
