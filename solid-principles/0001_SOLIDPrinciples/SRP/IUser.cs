///----------------------------------------------------------------------
/// <File>IUser</File>
/// <Author>Pruthvi</Author>
/// <Date>August 3rd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace SRP
{
    public interface IUser
    {
        bool Login(string userName, string password);
        bool Register(string userName, string password, string email);
    }
}
