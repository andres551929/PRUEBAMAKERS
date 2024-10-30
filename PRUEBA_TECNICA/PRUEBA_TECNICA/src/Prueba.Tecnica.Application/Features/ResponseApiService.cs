using Prueba.Tecnica.Domain.Models;

namespace Prueba.Tecnica.Application.Features
{
    public class ResponseApiService
    {
        public static BaseResponseModel Response(int statusCode, object Data = null, string message = null)
        {
            bool success = false;

            if (statusCode >= 200 && statusCode < 300)
            {
                success = true;
            }

            var result = new BaseResponseModel
            {
                StatusCode = statusCode,
                Success = success,
                Message = message,
                Data = Data
            };
            return result;
        }
    }
}
