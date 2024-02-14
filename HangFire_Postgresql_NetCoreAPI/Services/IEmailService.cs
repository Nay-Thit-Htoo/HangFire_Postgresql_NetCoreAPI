namespace HangFire_Postgresql_NetCoreAPI.Services
{
    public interface IEmailService
    {
        void SendEmail(string backGroundJobType, string startTime);
    }
}
