using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SwachBharat.CMS.Bll.ViewModels.ChildModel.Model
{
    public class WardNumberVM : BaseVM
    {
        public int Id { get; set; }
        [Remote("CheckWardDetails", "MainMaster", HttpMethod = "POST", ErrorMessage = "Name already exists!", AdditionalFields = "Id")]
        public string WardNo { get; set; }

        public Nullable<int> zoneId { get; set; }

    }
}
