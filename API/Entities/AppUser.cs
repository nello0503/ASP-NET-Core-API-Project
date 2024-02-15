namespace API.Entities;

public class AppUser
{
    
    public int Id { get;set ;} //the other classess can get and set this property //id will be the pripary key
    public string Username { get;set ;}

    public byte[] PasswordHash {get;set;}

    public byte[] PasswordSalt {get; set;}


}
