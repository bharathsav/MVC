using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Services.Interfaces
{
    public class EmployeeDetailsService : IEmployeeDetailsService
    {
        private readonly IEmployeeDetailsRepository _IEmployeeDetailsRepository;
        public EmployeeDetailsService(IEmployeeDetailsRepository IEmployeeDetailsRepository)
        {
            _IEmployeeDetailsRepository = IEmployeeDetailsRepository;
        }
        public List<EmployeeInfo> GetEmployeeInfo()
        {
            return _IEmployeeDetailsRepository.GetEmployeeInfo();
        }
    }
}
