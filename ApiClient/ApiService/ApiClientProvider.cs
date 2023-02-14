using Refit;

namespace Data.Api
{
    public class ApiClientProvider
    {
        public ApiClientProvider() { 
        
           
        }
        private IRegionApi createRegionApiClient()
        {
            return  RestService.For<IRegionApi>(BaseApi.BaseUrl);
        }

    }
}
