﻿using AutoMapper;
using Core.Database.Repository;
using Core.WebServices.Model;
using Core.WebServices.Service;
using HRMS.Database;
using HRMS.Database.Entities;
using HRMS.Services.DTO;
using HRMS.Services.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Services.Service
{
    public class TransCrossDepartService : BaseService<PositionTransferCrossDepart, DataContext, PositionTransCrossDepartDTO, int>, ITransCrossDepartService
    {
        public TransCrossDepartService(IRepository<PositionTransferCrossDepart, DataContext> Repository, IMapper mapper) : base(Repository, mapper)
        {
        }

        protected override CoreResponse Create(CoreRequest core_request)
        {
            throw new NotImplementedException();
        }

        protected override CoreResponse Edit(CoreRequest core_request)
        {
            throw new NotImplementedException();
        }

        protected override CoreResponse Remove(CoreRequest core_request)
        {
            throw new NotImplementedException();
        }

        protected override CoreResponse Upload(CoreRequest core_request)
        {
            throw new NotImplementedException();
        }
    }
}
