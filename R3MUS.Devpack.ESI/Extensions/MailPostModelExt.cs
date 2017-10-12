using R3MUS.Devpack.Core;
using R3MUS.Devpack.ESI.Models.Mail;
using System.Collections.Generic;

namespace R3MUS.Devpack.ESI.Extensions
{
    public static class MailPostModelExt
    {
        public static int Send(this MailPostRequest me)
        {
            var reqUri = string.Format("{0}/{1}/{2}/{3}/?{4}", Resources.BaseURI, Resources.Characters, me.OriginatorId.ToString(), 
                Resources.Mail, Resources.BaseURITail);
            var headers = new Dictionary<string, string> ();
            headers.Add(Resources.Authorization, string.Concat("Bearer ", me.Token));
            headers.Add("Content-Type", "application/json");
            headers.Add("Accept", "application/json");

            return Web.Post<int>(reqUri, headers, me.Mail);
        }
    }
}
