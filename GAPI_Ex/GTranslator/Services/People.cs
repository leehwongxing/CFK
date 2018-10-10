using Google.Apis.Auth.OAuth2;
using Google.Apis.PeopleService.v1;
using Google.Apis.PeopleService.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Reflection;
using System.Threading;

namespace GTranslator.Services
{
    public interface IPeopleService
    {
        bool SignIn();

        Person RequestProfile();

        bool SignOut();
    }

    public class People : IPeopleService
    {
        private readonly string[] Scopes = {
            "profile",
            "email"
        };

        private UserCredential Credential { get; set; }

        private PeopleServiceService Service { get; set; }

        public People()
        {
            ReInit();
        }

        public void ReInit()
        {
            if (Service != null) Service.Dispose();
            Credential = null;

            using (var stream = Assembly
                .GetExecutingAssembly()
                .GetManifestResourceStream("GTranslator.GTranslator_OAuth2.json"))
            {
                Credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                   GoogleClientSecrets.Load(stream).Secrets,
                   Scopes,
                   Settings.AppName,
                   CancellationToken.None,
                   new FileDataStore(Settings.FileStore, true)).Result;
            }

            Service = new PeopleServiceService(
                new BaseClientService.Initializer
                {
                    HttpClientInitializer = Credential,
                    ApplicationName = Settings.AppName
                });
        }

        public Person RequestProfile()
        {
            var Request = Service.People.Get("people/me");
            Request.PersonFields = "residences,emailAddresses,names,photos";
            return Request.ExecuteAsync().Result;
        }

        public bool SignIn()
        {
            ReInit();
            return true;
        }

        public bool SignOut()
        {
            try
            {
                Settings.ResetCredential();

                ReInit();

                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }
    }
}
