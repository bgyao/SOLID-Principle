namespace Solid_Principles.DependencyInversionPrinciples;

public class Program
{
    static void Main(string[] args)
    {
        UserDetailAppService userDetailService = new UserDetailAppService();
        UserDetail user = userDetailService.GetUserDetailById(1);
        Console.WriteLine($"ID: {user.Id}, Full Name: {user.GivenName} {user.LastName}, Email Address: {user.EmailAddress}, Phone Number: {user.PhoneNumber}");
        Console.ReadKey();
    }
}
