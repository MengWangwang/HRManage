﻿using Core.WebServices.Interface;
using HRMS.Services.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace HRMS.Services.Interface
{
    public interface IEmployeeEntryService : IBase<EmployeeEntryDTO, int>, IDatatable
    {
    }
}
