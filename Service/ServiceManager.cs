using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
    public sealed class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICompanyService> _companyService;
        private readonly Lazy<IEmployeeService> _employeeService;

        public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger, IMapper mapper, IDataShaper<EmployeeDto> dataShaper)
        {
            _companyService = new Lazy<ICompanyService>(() => new
            CompanyService(repositoryManager, logger, mapper));
            _employeeService = new Lazy<IEmployeeService>(() => new
            EmployeeService(repositoryManager, logger, mapper, dataShaper));
        }
        public ICompanyService CompanyService => _companyService.Value;
        public IEmployeeService EmployeeService => _employeeService.Value;
    }
}
