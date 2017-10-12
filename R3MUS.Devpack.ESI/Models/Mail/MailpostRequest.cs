namespace R3MUS.Devpack.ESI.Models.Mail
{
    public class MailPostRequest
    {
        public long OriginatorId { get; set; }
        public MailPostModel Mail { get; set; }
        public string Token { get; set; }
    }
}
