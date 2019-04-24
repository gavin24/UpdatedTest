using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using DevloperTest.Models;
using Newtonsoft.Json;

namespace DevloperTest.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MenuItemsController : ApiController
    {
        private MenuItemDataModel db = new MenuItemDataModel();

        // GET: api/MenuItems
        public IQueryable<MenuItem> GetMenuItems()
        {
            return db.MenuItems;
        }

        // GET: api/MenuItems/5
        [ResponseType(typeof(MenuItem))]
        public string GetMenuItem(int id)
        {
            MenuItem menuItem = db.MenuItems.Find(id);
            List<MenuItem> menuItemList = db.MenuItems.Where(x => x.TopLevelNode == menuItem.Id).ToList();
            //if (menuItem == null)
            //{
            //    return NotFound();
            //}
            string menuItemJson = JsonConvert.SerializeObject(menuItemList);
            return menuItemJson;
            //return Ok(menuItem);
        }
        [ResponseType(typeof(MenuItem))]
        public string GetMenuItem(string value)
        {
            MenuItem menuItem = db.MenuItems.Where(x => x.Title.ToLower() == value.ToLower()).FirstOrDefault();
            List<MenuItem> menuItemList = new List<MenuItem>();
            //if (menuItem == null)
            //{
            //    return NotFound();
            //}
            string menuItemJson = JsonConvert.SerializeObject(menuItemList);
            return menuItemJson;
            // return menuItemList;
            //  return Ok(menuItem);
        }


        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool MenuItemExists(int id)
        {
            return db.MenuItems.Count(e => e.Id == id) > 0;
        }
    }
}