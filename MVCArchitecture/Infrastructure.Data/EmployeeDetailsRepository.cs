using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infrastructure.Data
{
    
    public class EmployeeDetailsRepository : IEmployeeDetailsRepository
    {
        TestingEntities _context = new TestingEntities();
        public List<EmployeeInfo> GetEmployeeInfo()
        {
            //EmployeeInfo info = new EmployeeInfo() {
            //    Id = 1,
            //    Name = "Bharath, S",
            //    Company = "Deloitte",
            //    Group = "ITS Canada"
            //};
            //List<EmployeeInfo> lst = new List<EmployeeInfo>();
            //lst.Add(info);
            //var data = _context.EmployeeDetails;
            var data = (from p in _context.EmployeeDetails
                        select new EmployeeInfo
                        {
                            Company = p.Company,
                            Group = p.Group.ToString(),
                            Id = p.Id,
                            Name = p.Name
                        }).ToList();
            return data;
        }
    }
}
