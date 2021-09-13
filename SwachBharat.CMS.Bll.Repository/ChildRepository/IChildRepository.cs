﻿using SwachBharat.CMS.Bll.ViewModels;
using SwachBharat.CMS.Bll.ViewModels.Grid;
using SwachBharat.CMS.Bll.ViewModels.ChildModel.Model;
using SwachBharat.CMS.Bll.ViewModels.MainModel;
using SwachBharat.CMS.Bll.ViewModels.SS2020Reports;
using SwachBharat.CMS.Dal.DataContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SwachBharat.CMS.Bll.Repository.ChildRepository
{
    public interface IChildRepository
    {
     
        DashBoardVM GetDashBoardDetails();
        string Address(string location);
        AreaVM GetArea(int teamId,string name);
        void DeletArea(int teamId);
        void SaveArea(AreaVM area);


        VehicleTypeVM GetVehicleType(int teamId);
        void DeletVehicleType(int teamId);
        void SaveVehicleType(VehicleTypeVM type);


        WardNumberVM GetWardNumber(int teamId,string name);
        void DeleteWardNumber(int teamId);
        void SaveWardNumber(WardNumberVM type);


         HouseDetailsVM GetHouseById(int teamId);
         HouseDetailsVM SaveHouse(HouseDetailsVM data);
         void DeletHouse(int teamId);


        SBALUserLocationMapView GetLocation(int teamId);
        List<SBALUserLocationMapView> GetAllUserLocation(string date);
        // for admin
        List<SBALUserLocationMapView> GetAdminLocation();
        List<SBALUserLocationMapView> GetUserWiseLocation(int id,string date);
        List<SBALUserLocationMapView> GetUserAttenLocation(int id);
        List<SBALUserLocationMapView> GetUserAttenRoute(int id);

        //Added By Saurabh (11 July 2019)
        List<SBALUserLocationMapView> GetHouseAttenRoute(int id);
        GarbagePointDetailsVM GetGarbagePointById(int teamId);
        GarbagePointDetailsVM SaveGarbagePoint(GarbagePointDetailsVM data);
        void DeletGarbagePoint(int teamId);

        EmployeeDetailsVM GetEmployeeById(int teamId);

        SBAAttendenceSettingsGridRow GetAttendenceEmployeeById(int teamId);
        void DeleteEmployee(int teamId);
        void SaveEmployee(EmployeeDetailsVM employee);

        void SaveAttendenceSettingsDetail(SBAAttendenceSettingsGridRow atten);

        ComplaintVM GetComplaint(int teamId);
        void SaveComplaintStatus(ComplaintVM comp);

        ZoneVM GetZone(int teamId);
        void SaveZone(ZoneVM type);
        ZoneVM GetValidZone(string name,int zoneId);

        //Added By Saurabh

        DumpYardDetailsVM GetDumpYardById(int teamId);

        DumpYardDetailsVM SaveDumpYard(DumpYardDetailsVM data);

        #region HouseScanify
        // Added By Saurabh (27 May 2019)
        List<QrEmployeeMaster> GetUserList(int AppId, int teamId);

        //Added By Saurabh (03 June 2019)

        HouseScanifyEmployeeDetailsVM GetHSEmployeeById(int teamId);

        //Added By saurabh (04 June 2019)
        void SaveHSEmployee(HouseScanifyEmployeeDetailsVM employee);

        //Added By saurabh (04 June 2019)
        HSDashBoardVM GetHSDashBoardDetails();

        List<SBALHSUserLocationMapView> GetHSUserAttenRoute(int qrEmpDaId);
        #endregion

        //Added By saurabh (04 June 2019)

        List<SBALHouseLocationMapView> GetAllHouseLocation(string date, int userid, int areaid, int wardNo, string SearchString, int? GarbageType, int FilterType);

        //Code Optimization (code)
        //SBALHouseLocationMapView1 GetAllHouseLocation(string date, int userid,int areaid,int wardNo, string SearchString, string start);


        //Added By saurabh ( June 2019)
        HouseScanifyEmployeeDetailsVM GetUser(int teamId, string name);

        //Added By saurabh ( 02 July 2019)
        DashBoardVM GetHouseOnMapDetails();
        //Added By Neha ( 12 July 2019)
        List<SBAEmplyeeIdelGrid> GetIdleTimeRoute(int userId, string Date);
        OnePoint4VM GetOnePointFourTotalCount(int ANS_ID);

        OnePoint4VM GetMaxINSERTID();


        void Save1Point4(List<OnePoint4VM> point);

        List<OnePoint4VM> GetQuetions(string ReportName);

        void Save1Point5(List<OnePoint5VM> point);

        List<OnePoint5VM> GetQuetions1pointfive();

        List<OnePoint4VM> GetOnepointfourEditData(int INSERT_ID);

        void SaveTotalCount(OnePoint4VM onepointfour);

        void Save1Point7(List<OnePointSevenVM> point);

        List<OnePoint7QuestionVM> GetOnePointSevenAnswers(int INSERT_ID);

        List<OnePoint7QuestionVM> GetOnePointSevenQuestions();

        void EditOnePointSeven(List<OnePoint7QuestionVM> OnePoint7);

        List<SelectListItem> LoadListWardNo(int ZoneId);

        List<SelectListItem> LoadListArea(int WardNo);

        //InfotainmentDetailsVW GetInfotainmentDetailsById(int ID);
        //void SaveGameDetails(InfotainmentDetailsVW data);

        SauchalayDetailsVM GetSauchalayById(int teamId);

        SauchalayDetailsVM SaveSauchalay(SauchalayDetailsVM data);

        List<SauchalayDetailsVM> GetCTPTLocation();

        #region WasteManagement

        WasteDetailsVM GetWasteById(int teamId);

        //List<WasteDetailsVM> SaveWaste(List<WasteDetailsVM> data);

        string SaveWaste(string data);

        string SaveSalesWaste(string data);
        List<SelectListItem> LoadListSubCategory(int categoryId);
        List<SelectListItem> GetWMUser();
        #endregion

        List<LogVM> GetLogString();

        List<SBAEmplyeeIdelGrid> GetIdelTimeNotification();

        List<SBALUserLocationMapView> GetUserTimeWiseRoute(string date = "", DateTime? fTime = null, DateTime? tTime = null, int? userId = null);
    }
}
