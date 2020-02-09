﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
using Tochal.Core.DomainModels.DTO.MenuEntity;
using Tochal.Infrastructure.Services;

namespace TochalUI.Components
{
    [AllowAnonymous]
    public class Event : ViewComponent
    { 
        private readonly ContentManagementService _ContentManagementRepository;
        public Event(ContentManagementService ContentManagementRepository)
        {
            _ContentManagementRepository = ContentManagementRepository;
        }
        public async Task<IViewComponentResult> InvokeAsync(int numberToTake)
        {
            var list =await _ContentManagementRepository.GetAllByMainPageContentType(Tochal.Core.DomainModels.Entity.Blog.MainPageContentTypeSSOT.Event);
            return View(viewName: "Default", model: list.ToList());
        }
    }
}
