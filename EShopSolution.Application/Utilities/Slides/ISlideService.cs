﻿using EShopSolution.VM.Utilities.Slides;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EShopSolution.Application.Utilities.Slides
{
    public interface ISlideService
    {
        Task<List<SlideVm>> GetAll();
    }
}