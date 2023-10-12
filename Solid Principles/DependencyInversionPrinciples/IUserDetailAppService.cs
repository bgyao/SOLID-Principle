namespace Solid_Principles.DependencyInversionPrinciples;

public interface IUserDetailAppService
{
    UserDetail GetUserDetailById(int id);
    List<UserDetail> GetAllUserDetails();
}
