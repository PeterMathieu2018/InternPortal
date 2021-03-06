﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InternPortal.UI.Models
{
    public class Menu
    {
        public List<MenuItem> MenuItems { get; set; }

        public Menu()
        {
            MenuItems = new List<MenuItem>
            {
                new MenuItem
                {
                    Id = 100,
                    NameOption = "Interns",
                    Controller = "",
                    Action = "",
                    ImageClass = "fa fa-users fa-lg",
                    Status = true,
                    IsParent = true,
                    ParentId = 0,
                    RequiredRoles = System.Configuration.ConfigurationManager.AppSettings["OrdersAccess"],
                    SubMenu= new List<MenuItem>()
                    {
                        new MenuItem()
                        {
                            Id = 100,
                            NameOption = "View Applications",
                            Controller = "Application",
                            Action = "ViewAll",
                            ImageClass = "fa fa-file",
                            Status = true,
                            IsParent = false,
                            ParentId = 0
                        }
                    }
                }
            };
        }
    }
}