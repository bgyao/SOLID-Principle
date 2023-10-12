namespace Solid_Principles.DependencyInversionPrinciples;

public class GetUserDetailById
{
    public static IUserDetailAppService GetUserDetail()
    {
        return new UserDetailAppService();
    }
}