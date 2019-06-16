using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.Reflection;
using System.Linq.Expressions;

namespace PayrollService.API
{
    public static class AutoMapperBootStrapper
    {
        public static MapperConfiguration BootStrap()
        {

            return new MapperConfiguration(
                  cfg =>
                  {
                      cfg.CreateMap<DTO.Payment, Model.Payment>();
                      cfg.CreateMap<Model.Payment, DTO.Payment>();

                  }
                );            
        }

    }
}
