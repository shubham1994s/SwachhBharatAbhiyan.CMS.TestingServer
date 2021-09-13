using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SwachBharat.CMS.Bll.ViewModels.ChildModel.Model
{
   public class AreaVM : BaseVM
    {
        public int Id { get; set; }
        [Remote("CheckAreaDetails", "MainMaster", HttpMethod = "POST", ErrorMessage = "Name already exists!", AdditionalFields = "Id")]
        public string Name { get; set; }
        [Remote("CheckAreaDetails", "MainMaster", HttpMethod = "POST", ErrorMessage = "Name already exists!", AdditionalFields = "Id")]
        public string NameMar { get; set; }
        public Nullable<int> wardId { get; set; }

    }
}
