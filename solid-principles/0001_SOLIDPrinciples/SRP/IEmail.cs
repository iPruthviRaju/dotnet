///----------------------------------------------------------------------
/// <File>IEmail</File>
/// <Author>Pruthvi</Author>
/// <Date>August 3rd, 2018</Date>
/// <Summary></Summary>
///-----------------------------------------------------------------------

namespace SRP
{
    public interface IEmail
    {
        void SendEmail(string email, string emailContent);
    }
}
