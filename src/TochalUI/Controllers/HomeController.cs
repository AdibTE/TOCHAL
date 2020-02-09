using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Tochal.Core.DomainModels.DTO.ContentEntity;
using Tochal.Core.DomainModels.DTO.MenuEntity;
using Tochal.Core.DomainModels.Entity.Blog;
using Tochal.Core.DomainModels.Entity.Menu;
using Tochal.Infrastructure.Services;
using Tochal.UI.Helpers;
using TochalUI.Models;

namespace TochalUI.Controllers
{
    [AllowAnonymous]
    public class HomeController : Controller
    {
        private readonly MenuService _MenuRepository;
        private readonly ContentManagementService _contentManagementService;
        private readonly GalleryService _GalleryService;
        public HomeController(MenuService MenuRepository, ContentManagementService contentManagementService, GalleryService GalleryService)
        {
            _contentManagementService = contentManagementService;
            _MenuRepository = MenuRepository;
            _GalleryService = GalleryService;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<IActionResult> Detail(int id , DetailTypeSSOT DetailType)

        {
            var Content =await _contentManagementService.Find(id);

            var Gallery = _GalleryService.GetGalleries(id);

            if (Content.SubMenuId.HasValue)
            {
                var menu = await _MenuRepository.Find(Content.SubMenuId.Value);
                TempData["DetailType"] = menu.DetailType;
            }

            //if (DetailType == DetailTypeSSOT.Blog)
            //{
            //    return View("~/Views/Home/Detail.cshtml", new Tuple<ContentEntity, List<Tochal.Core.DomainModels.Entity.Content.Gallery>>(Content, Gallery));
            //}
            if (DetailType == DetailTypeSSOT.Pro)
            {
                return View("~/Views/Home/PostDetail.cshtml",new Tuple<ContentEntity, List<Tochal.Core.DomainModels.Entity.Content.Gallery>>(Content, Gallery));
            }
            else
            {
                return View("~/Views/Home/Text.cshtml", new Tuple<ContentEntity, List<Tochal.Core.DomainModels.Entity.Content.Gallery>>(Content, Gallery));
            }
        }

        public async Task<IActionResult> Post(int menuId)
        {
            var menu =await _MenuRepository.Find(menuId);
            TempData["DetailType"] = menu.DetailType;
            var Contents = _contentManagementService.GetAllByMenuId(menuId);

            return View(Contents);
        }
        public async Task<IActionResult> Blog(int menuId)
        {
            var menu = await _MenuRepository.Find(menuId);
            TempData["DetailType"] = menu.DetailType;
            var Contents = _contentManagementService.GetAllByMenuId(menuId);

            return View(Contents);
        }
        public async Task<IActionResult> SinglePage(int menuId)
        {
            var menu = await _MenuRepository.Find(menuId);

            return View(menu);
        }

        public async Task<IActionResult> MoreEvent()
        {
            var list =await _contentManagementService
                .GetAllByMainPageContentType(MainPageContentTypeSSOT.Event);

            return View(viewName: "~/Views/Home/Blog.Cshtml", model: list.Take(4).ToList());
        }

        public PartialViewResult Languages()
        {
            return PartialView(_MenuRepository.GetLanguages());
        }

        public IActionResult ChangeLanguage(string culture)
        {
            Response.Cookies.Append(CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions() { Expires = DateTimeOffset.UtcNow.AddMonths(3) });

            return Redirect(Request.Headers["Referer"].ToString());
        }

       
    }
}
