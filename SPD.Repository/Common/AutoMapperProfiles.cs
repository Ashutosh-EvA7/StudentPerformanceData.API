using AutoMapper;
using SPD.Entity.Models;
using SPD.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPD.Repository.Common
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles() 
        {
            CreateMap<StudentMaster, StudentDetail>();
            CreateMap<Marksheet, MarkView>();
        }
    }
}
