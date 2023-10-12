namespace Solid_Principles.DependencyInversionPrinciples;

public class Contacts
{
    IUserDetailAppService _userDetailAppServce;

    public Contacts()
    {
        _userDetailAppServce = GetUserDetailById.GetUserDetail();
    }

    public UserDetail GetUserDetail(int id)
    {
        return _userDetailAppServce.GetUserDetailById(id);
    }
}
