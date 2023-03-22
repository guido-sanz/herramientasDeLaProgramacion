using System.ComponentModel.DataAnnotations;

public class Form{
    [Required]
    [Display(Name = "Correo electronico")]
    public string Mail {get; set;}
    public string Password {get; set;}
}