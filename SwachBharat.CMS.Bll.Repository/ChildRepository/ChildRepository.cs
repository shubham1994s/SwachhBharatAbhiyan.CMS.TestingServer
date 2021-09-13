using SwachBharat.CMS.Bll.ViewModels.Grid;
using SwachBharat.CMS.Bll.Services;
using SwachBharat.CMS.Bll.ViewModels.ChildModel.Model;
using SwachBharat.CMS.Bll.ViewModels.MainModel;
using SwachBharat.CMS.Dal.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using SwachBharat.CMS.Bll.ViewModels.SS2020Reports;
using System.Web.Mvc;

namespace SwachBharat.CMS.Bll.Repository.ChildRepository
{
   public class ChildRepository:IChildRepository
    {
        private int AppID;
        IScreenService screenService;
        
        public ChildRepository(int AppId)
        {
           screenService = new ScreenService(AppId);
           
            AppID = AppId;
        }
        public DashBoardVM GetDashBoardDetails()
        {
            return screenService.GetDashBoardDetails();

        }
        public string Address(string location)
        {
            return screenService.Address(location);
        }
        public AreaVM GetArea(int teamId,string name)
        {
            return screenService.GetAreaDetails(teamId,name);
        }
        public void DeletArea(int teamId)
        {
             screenService.DeletAreaDetails(teamId);
        }
        public void SaveArea(AreaVM area)
        {
            if (area.Id<=0)
            {
                area.Id = 0;
            }
            screenService.SaveAreaDetails(area);
        }


        public VehicleTypeVM GetVehicleType(int teamId)
        {
            return screenService.GetVehicleTypeDetails(teamId);
        }
        public void DeletVehicleType(int teamId)
        {
            screenService.DeletVehicleTypeDetails(teamId);
        }
        public void SaveVehicleType(VehicleTypeVM type)
        {
            if (type.Id <= 0)
            {
                type.Id = 0;
            }
            screenService.SaveVehicleTypeDetails(type);
        }
         
        public WardNumberVM GetWardNumber(int teamId,string name)
        {
            return screenService.GetWardNumberDetails(teamId,name);
        }
        public void DeleteWardNumber(int teamId)
        {
            screenService.DeletWardNumberDetails(teamId);
        } 
        public void SaveWardNumber(WardNumberVM type)
        {
            if (type.Id <= 0)
            {
                type.Id = 0;
            }
            screenService.SaveWardNumberDetails(type);
        } 
        

        public HouseDetailsVM GetHouseById(int teamId)
        {
            return screenService.GetHouseDetails(teamId);
        }
        public HouseDetailsVM SaveHouse(HouseDetailsVM data)
        {
            if (data.houseId <= 0)
            {
                data.houseId = 0;
            }
            HouseDetailsVM dd =screenService.SaveHouseDetails(data);
            return dd;
        }
        public void DeletHouse(int teamId)
        {
            screenService.DeletHouseDetails(teamId);
        } 


        public SBALUserLocationMapView GetLocation(int teamId)
        {
            return screenService.GetLocationDetails(teamId);
        }

        public List<SBALUserLocationMapView> GetAllUserLocation(string date)
        {
            return screenService.GetAllUserLocation(date);
        }

        public List<SBALUserLocationMapView> GetAdminLocation()
        {
            return screenService.GetAdminLocation();
        }


        public List<SBALUserLocationMapView> GetUserWiseLocation(int userId,string date)
        {
            return screenService.GetUserWiseLocation(userId,date);
        }

        public List<SBALUserLocationMapView> GetUserAttenLocation(int userId)
        {
            return screenService.GetUserAttenLocation(userId);
        }
        public List<SBALUserLocationMapView> GetUserAttenRoute(int daId)
        {
            return screenService.GetUserAttenRoute(daId);
        }

        //Added By Saurabh(11 July 2019)
        public List<SBALUserLocationMapView> GetHouseAttenRoute(int daId)
        {
            return screenService.GetHouseAttenRoute(daId);
        }

        public GarbagePointDetailsVM GetGarbagePointById(int teamId)
        {
            return screenService.GetGarbagePointDetails(teamId);
        }
        public GarbagePointDetailsVM SaveGarbagePoint(GarbagePointDetailsVM data)
        {
            if (data.gpId <= 0)
            {
                data.gpId = 0;
            }
            GarbagePointDetailsVM dd = screenService.SaveGarbagePointDetails(data);
            return dd;
        }
        public void DeletGarbagePoint(int teamId)
        {
            screenService.DeletGarbagePointDetails(teamId);
        }

        
        public EmployeeDetailsVM GetEmployeeById(int teamId)
        {
           return screenService.GetEmployeeDetails(teamId);
        }


        public SBAAttendenceSettingsGridRow GetAttendenceEmployeeById(int teamId)
        {
            return screenService.GetAttendenceEmployeeById(teamId);
        }

        public void DeleteEmployee(int teamId)
        {
            screenService.DeleteEmployeeDetails(teamId);
        }

        public void SaveEmployee(EmployeeDetailsVM employee)
        {
            screenService.SaveEmployeeDetails(employee);
        }

      public  void SaveAttendenceSettingsDetail(SBAAttendenceSettingsGridRow atten)
        {
            screenService.SaveAttendenceSettingsDetail(atten);
        }
        public ComplaintVM GetComplaint(int teamId)
        {
            return screenService.GetCompalint(teamId);
        }

        public void SaveComplaintStatus(ComplaintVM comp)
        {
            screenService.SaveComplaintStatus(comp);
        }

        public ZoneVM GetZone(int teamId)
        {
            return screenService.GetZone(teamId);
        }
       
        public void SaveZone(ZoneVM type)
        {
            if (type.id <= 0)
            {
                type.id = 0;
            }
            screenService.SaveZone(type);
        }
        public ZoneVM GetValidZone(string name,int zoneId)
        {
            return screenService.GetValidZone(name,zoneId);
        }

        //Added By Saurabh
        public DumpYardDetailsVM GetDumpYardById(int teamId)
        {
            return screenService.GetDumpYardtDetails(teamId);
        }

        public DumpYardDetailsVM SaveDumpYard(DumpYardDetailsVM data)
        {
            if (data.dyId <= 0)
            {
                data.dyId = 0;
            }
            DumpYardDetailsVM dd = screenService.SaveDumpYardtDetails(data);
            return dd;
        }

        #region HouseScanify
        //Added By Saurabh

        public List<QrEmployeeMaster> GetUserList(int AppId , int teamId)
        {
            return screenService.GetUserList(AppId, teamId);
        }

        // Addded By Saurabh (03 June 2019)
        public HouseScanifyEmployeeDetailsVM GetHSEmployeeById(int teamId)
        {
            return screenService.GetHSEmployeeDetails(teamId);
        }

        // Addded By Saurabh (04 June 2019)
        public void SaveHSEmployee(HouseScanifyEmployeeDetailsVM employee)
        {
            screenService.SaveHSEmployeeDetails(employee);
        }

        // Addded By Saurabh (04 June 2019)
        public HSDashBoardVM GetHSDashBoardDetails()
        {
            return screenService.GetHSDashBoardDetails();

        }

        public List<SBALHSUserLocationMapView> GetHSUserAttenRoute(int qrEmpDaId)
        {
            return screenService.GetHSUserAttenRoute(qrEmpDaId);
        }

        #endregion
        // Addded By Saurabh (06 June 2019)
        public List<SBALHouseLocationMapView> GetAllHouseLocation(string date, int userid, int areaid, int wardNo, string SearchString, int? GarbageType, int FilterType)
        {
            return screenService.GetAllHouseLocation(date, userid, areaid, wardNo, SearchString, GarbageType, FilterType);
        }

        //Code Optimization (code)
        //public SBALHouseLocationMapView1 GetAllHouseLocation(string date, int userid, int areaid, int wardNo, string SearchString, string start)
        //{
        //    return screenService.GetAllHouseLocation( date, userid,areaid, wardNo, SearchString, start);
        //}

        // Addded By Saurabh (21 June 2019)
        public HouseScanifyEmployeeDetailsVM GetUser(int teamId, string name)
        {
            return screenService.GetUserDetails(teamId, name);
        }

        public DashBoardVM GetHouseOnMapDetails()
        {
            return screenService.GetHouseOnMapDetails();

        }
        // Addded By neha (12 July 2019)
        public List<SBAEmplyeeIdelGrid> GetIdleTimeRoute(int userId, string Date)
        {
            return screenService.GetIdleTimeRoute(userId, Date);
        }
        public void Save1Point4(List<OnePoint4VM> point)
        {
            screenService.Save1Point4(point);

        }

        public List<OnePoint4VM> GetQuetions(string ReportName)
        {
            return screenService.GetQuetions(ReportName);
        }

        public void Save1Point5(List<OnePoint5VM> point)
        {
            screenService.Save1Point5(point);

        }

        public List<OnePoint5VM> GetQuetions1pointfive()
        {
            return screenService.GetQuetions1pointfive();
        }
        public List<OnePoint4VM> GetOnepointfourEditData(int INSERT_ID)
        {
            return screenService.GetOnepointfourEditData(INSERT_ID);
        }

        public OnePoint4VM GetOnePointFourTotalCount(int ANS_ID)
        {
            return screenService.GetTotalCountDetails(ANS_ID);
        }
        public OnePoint4VM GetMaxINSERTID()
        {
            return screenService.GetMaxINSERTID();
        }
        public void SaveTotalCount(OnePoint4VM onepointfour)
        {
            screenService.SaveTotalCount(onepointfour);
        }

        public void Save1Point7(List<OnePointSevenVM> point)
        {
            screenService.Save1Point7(point);

        }

        public List<OnePoint7QuestionVM> GetOnePointSevenQuestions()
        {
            return screenService.GetOnePointSevenQuestions();
        }

        public void EditOnePointSeven(List<OnePoint7QuestionVM> OnePoint7QuestionVM)
        {
            screenService.EditOnePointSeven(OnePoint7QuestionVM);
        }

        public List<OnePoint7QuestionVM> GetOnePointSevenAnswers(int INSERT_ID)
        {
            return screenService.GetOnePointSevenAnswers(INSERT_ID);
        }

        public List<SelectListItem> LoadListWardNo(int ZoneId)
        {
            return screenService.LoadListWardNo(ZoneId);
        }

        public List<SelectListItem> LoadListArea(int WardNo)
        {
            return screenService.LoadListArea(WardNo);
        }

        //public InfotainmentDetailsVW GetInfotainmentDetailsById(int ID)
        //{
        //    return screenService.GetInfotainmentDetailsById(ID);
        //}

        //public void SaveGameDetails(InfotainmentDetailsVW data)
        //{
        //    if (data.GameDetailsId <= 0)
        //    {
        //        data.GameDetailsId = 0;
        //    }
        //    screenService.SaveGameDetails(data);
        //}

        public SauchalayDetailsVM GetSauchalayById(int teamId)
        {
            return screenService.GetSauchalayDetails(teamId);
        }

        public SauchalayDetailsVM SaveSauchalay(SauchalayDetailsVM data)
        {
            if (data.Id <= 0)
            {
                data.Id = 0;
            }
            SauchalayDetailsVM dd = screenService.SaveSauchalayDetails(data);
            return dd;
        }

        public List<SauchalayDetailsVM> GetCTPTLocation()
        {
            return screenService.GetCTPTLocation();
        }

        #region WasteManagement
        public WasteDetailsVM GetWasteById(int teamId)
        {
            return screenService.GetWasteDetails(teamId);
        }

        //public List<WasteDetailsVM> SaveWaste(List<WasteDetailsVM> data)
        //{
        //    return screenService.SaveWasteDetails(data);
        //}
        public string SaveWaste(string data)
        {
            return screenService.SaveWasteDetails(data);
        }

        public string SaveSalesWaste(string data)
        {
            return screenService.SaveSalesWasteDetails(data);
        }
        
        public List<SelectListItem> LoadListSubCategory(int categoryId)
        {
            return screenService.LoadListSubCategory(categoryId);
        }

        public List<SelectListItem> GetWMUser()
        {
            return screenService.GetWMUserDetails();
        }
        #endregion

        public List<LogVM> GetLogString()
        {
            return screenService.GetLogString();
        }

        public List<SBAEmplyeeIdelGrid> GetIdelTimeNotification()
        {
            return screenService.GetIdelTimeNotification();
        }
        public List<SBALUserLocationMapView> GetUserTimeWiseRoute(string date = "", DateTime? fTime = null, DateTime? tTime = null, int? userId = null)
        {
            return screenService.GetUserTimeWiseRoute(date,fTime, tTime, userId);
        }

     
    }
}

