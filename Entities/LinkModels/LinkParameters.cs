using Shared.RequestFeatures;
using Microsoft.AspNetCore.Http;

namespace Entities.LinkModels
{
    public record LinkParameters(EmployeeParameters EmployeeParameters, HttpContext Context);
}
