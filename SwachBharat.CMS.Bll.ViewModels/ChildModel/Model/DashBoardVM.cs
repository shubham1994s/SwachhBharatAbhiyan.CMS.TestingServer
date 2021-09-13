using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SwachBharat.CMS.Bll.ViewModels.ChildModel.Model
{
    public class DashBoardVM : BaseVM
    {
        public Nullable<int> TodayAttandence { get; set; }
        public Nullable<int> TotalAttandence { get; set; }
        public Nullable<int> HouseCollection { get; set; }
        public Nullable<int> PointCollection { get; set; }
        public Nullable<int> TotalComplaint { get; set; }
        public Nullable<int> DumpYardCount { get; set; }

        public Nullable<int> TotalHouseCount { get; set; }
        public Nullable<int> MixedCount { get; set; }
        public Nullable<int> BifurgatedCount { get; set; }
        public Nullable<int> NotCollected { get; set; }
        public Nullable<double> TotalGcWeightCount { get; set; }
        public Nullable<double> TotalDryWeightCount { get; set; }
        public Nullable<double> TotalWetWeightCount { get; set; }
        public Nullable<double> GcWeightCount { get; set; }
        public Nullable<double> DryWeightCount { get; set; }
        public Nullable<double> WetWeightCount { get; set; }

        public Nullable<int> NotSpecified { get; set; }


        public int userId { get; set; }
        public string userName { get; set; }
        public string gcTarget { get; set; }

        public string UserName { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public int _Count { get; set; }



        public string Target { get; set; }

        //public Nullable<int> TotalHouseCount { get; set; }
        public Nullable<int> TotalHouseLatLongCount { get; set; }
        public Nullable<int> TotalScanHouseCount { get; set; }


        public string areaName { get; set; }

        // public List<SelectListItem> AreaList { get; set; }

        public Nullable<int> ZoneId { get; set; }
        public Nullable<int> WardNo { get; set; }
        public Nullable<int> AreaId { get; set; }


    }
}
