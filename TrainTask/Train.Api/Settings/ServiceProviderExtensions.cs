using Train.BLL;
using Train.DAL;

namespace Train.Api.Settings
{
    public static class ServiceProviderExtensions
    {
        public static void RedistrDI(this IServiceCollection services)
        {
            services.AddScoped<IUploadXmlFileService, UploadXmlFileService>();
            services.AddScoped<ITrainRepository, TrainRepository>();
        }
    }
}
