using System;

namespace R3MUS.Devpack.ESI.Models.Verification
{
    public class Summary
    {
        public long CharacterID { get; set; }
        public string CharacterName { get; set; }
        public DateTime ExpiresOn { get; set; }
        public string Scopes { get; set; }
        public string TokenType { get; set; }
        public string CharacterOwnerHash { get; set; }
    }
}
