using Grpc.Core;
using GrpcEmployee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GrpcGreeter.Services
{
    public class EmployeeService: Employee.EmployeeBase
    {
        public override Task<EmpModel> getInfo(EmpRequest request, ServerCallContext context)
        {
            if (request.Id == "2")
            {
                return Task.FromResult(new EmpModel { Fid = "222", Name = "张三" });
            }
            else
            {
                return Task.FromResult(new EmpModel { Fid = "33333", Name = "XXX" });
            }
        }
    }
}
