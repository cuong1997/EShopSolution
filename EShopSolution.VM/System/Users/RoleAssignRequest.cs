﻿using EShopSolution.VM.Common;
using System;
using System.Collections.Generic;

namespace EShopSolution.VM.System.Users
{
    public class RoleAssignRequest
    {
        public Guid Id { get; set; }
        public List<SelectItem> Roles { get; set; } = new List<SelectItem>();
    }
}