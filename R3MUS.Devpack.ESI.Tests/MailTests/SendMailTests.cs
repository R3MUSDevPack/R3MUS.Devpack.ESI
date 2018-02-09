using Microsoft.VisualStudio.TestTools.UnitTesting;
using R3MUS.Devpack.ESI.Models.Mail;
using Ploeh.AutoFixture;
using R3MUS.Devpack.ESI.Extensions;
using FluentAssertions;
using R3MUS.Devpack.ESI.Tests.Properties;

namespace R3MUS.Devpack.ESI.Tests.MailTests
{
    [TestClass]
    public class SendMailTests : TestBase
    {
        [TestMethod]
        public void SendMail_ReturnsTrue()
        {
            //  Arrange
            var mailBody = Fixture.Build<MailPostModel>()
                .With(w => w.Recipients, new Recipient[] {
                    new Recipient() { RecipientId = Settings.Default.MailRecipientId, RecipientType = "character" }
                })
                .With(w => w.Subject, Properties.Settings.Default.MailHeader)
                .With(w => w.Body, Properties.Settings.Default.MailText)
                .Create();

            var mail = Fixture.Build<MailPostRequest>()
                .With(w => w.OriginatorId, Settings.Default.MailOriginatorId)
                .With(w => w.Token, _accessToken)
                .With(w => w.Mail, mailBody)
                .Create();

            //  Act
            var response = mail.Send();

            //  Assert
            response.Should().BeOfType(typeof(int));
        }
    }
}
