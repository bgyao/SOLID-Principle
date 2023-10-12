namespace Solid_Principles.DependencyInversionPrinciples;

public class UserDetailAppService : IUserDetailAppService
{
    public List<UserDetail> GetAllUserDetails()
    {
        List<UserDetail> phoneBook = new List<UserDetail>();

        UserDetail[] userDetails = { new UserDetail()
            {
                Id = 1,
                LastName = "Kamisato",
                GivenName = "Ayaka",
                EmailAddress = "kamisato.ayaka@yashiro.co.iz",
                PhoneNumber = "8888 8887 loc 1001"
            },
            new UserDetail()
            {
                Id = 2,
                LastName = "Kamisato",
                GivenName = "Ayato",
                EmailAddress = "kamisato.ayato@yashiro.co.iz",
                PhoneNumber = "8888 8887 loc 1002"
            }
        };

        phoneBook.AddRange(userDetails);

        return phoneBook;
    }

    public UserDetail GetUserDetailById(int id)
    {
        UserDetail userDetail = new UserDetail()
        {
            Id = id,
            LastName = "Kamisato",
            GivenName = "Ayato",
            EmailAddress = "kamisato.ayato@yashiro.co.iz",
            PhoneNumber = "8888 8888"
        };

        return userDetail;
    }
}
