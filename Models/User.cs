namespace Repository_Pattern_CRUD.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Email { get; set; } = "";
        public int PinCode { get; set; }
        public bool IdActive { get; set; }  

    }
}
