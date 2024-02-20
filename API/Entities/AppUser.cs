using API.Extensions;

namespace API.Entities;

public class AppUser
{
    
    public int Id { get;set ;} //the other classess can get and set this property //id will be the pripary key
    public string Username { get;set ;}

    public byte[] PasswordHash {get;set;}
    public byte[] PasswordSalt {get; set;}

    public DateOnly DateOfBirth {get;set;}
    public string KnownAs {get;set;}
    public DateTime Created {get;set;} = DateTime.UtcNow;
    public DateTime LastActive {get;set;} 
    public string Gender {get;set;}
    public string Introduction {get;set;}
    public string LookingFor {get;set;}
    public string Intrests {get;set;}
    public string City {get;set;}
    public string Country{get;set;}
    public List<Photo> Photos {get;set;} = new();

   /* public int GetAge()
    {
        return DateOfBirth.CalculateAge();
        
    }*/
}
