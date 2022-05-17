namespace User.Example.Domain.Exceptions.Models
{
    public class CustomValidationModel
    {
        public string Property { get; set; }
        public string[] Errors { get; set; }
    }
}
