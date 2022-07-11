using GameSaleProject.Abstracts;
using GameSaleProject.Entities;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ServiceReference1.KPSPublicSoapClient;

namespace GameSaleProject.Concrete
{
    internal class UserValidationManager : IUserValidationService
    {
        public bool Validation(Gamer gamer)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(gamer.NationalityId, gamer.FirstName.ToUpper(new CultureInfo("tr-TR", false)), gamer.LastName.ToUpper(new CultureInfo("tr-TR", false)), gamer.DateYear).GetAwaiter().GetResult();
            return result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
