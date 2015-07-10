using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unconnected.Mvc.Outputcache;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// This action will get varyByParam attribute from web.config.
        /// Code will not run until cache expiration.
        /// </summary>
        /// <returns></returns>
        [ParameterizedOutputCache(CacheProfile = "test")]
        public ActionResult Index()
        {
            var p = new ParameterizedOutputCacheAttribute();
            return View();
        }

        /// <summary>
        /// This action will ignore varyByParam attribute from web.config.
        /// But you can specify it directly and code will not run until cache expiration.
        /// </summary>
        /// <returns></returns>
        [OutputCache(CacheProfile = "test", VaryByParam="none")]
        public ActionResult CachedAction()
        {
            return View();
        }

        /// <summary>
        /// This action will ignore varyByParam attribute from web.config.
        /// Code will run any time you add random query string to request.
        /// </summary>
        /// <returns></returns>
        [OutputCache(CacheProfile="test")]
        public ActionResult NoProtectionFromRandom()
        {
            return View();
        }
	}
}