using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SwachhBharatAbhiyan.CMS.Models
{
    public class ZoneMasterVM
    {
        public int zoneId { get; set; }
     //   [Required(ErrorMessage = "Name is required.")]
        [Remote("CheckZoneDetails", "MainMaster", HttpMethod = "POST", ErrorMessage = "Name already exists!", AdditionalFields = "zoneId")]
        public string name { get; set; }
    }
}