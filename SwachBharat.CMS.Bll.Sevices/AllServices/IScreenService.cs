﻿using SwachBharat.CMS.Bll.ViewModels.ChildModel.Model;
using SwachBharat.CMS.Dal.DataContexts;
using SwachBharat.CMS.Bll.ViewModels.Grid;
using SwachBharat.CMS.Bll.ViewModels.SS2020Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace SwachBharat.CMS.Bll.Services
{
    public interface IScreenService
    {
        DashBoardVM GetDashBoardDetails();
        string Address(string location);
        AreaVM GetAreaDetails(int teamId,string Name);
        void DeletAreaDetails(int teamId);
        void SaveAreaDetails(AreaVM area);


        VehicleTypeVM GetVehicleTypeDetails(int teamId);
        void DeletVehicleTypeDetails(int teamId);
        void SaveVehicleTypeDetails(VehicleTypeVM type);

         WardNumberVM GetWardNumberDetails(int teamId,string name);
         void SaveWardNumberDetails(WardNumberVM data);
         void DeletWardNumberDetails(int teamId);

        HouseDetailsVM GetHouseDetails(int teamId);
        HouseDetailsVM SaveHouseDetails(HouseDetailsVM data);
         void DeletHouseDetails(int teamId);

        SBALUserLocationMapView GetLocationDetails(int teamId);
        List<SBALUserLocationMapView> GetAllUserLocation(string date);

        List<SBALUserLocationMapView> GetAdminLocation();
        List<SBALUserLocationMapView> GetUserWiseLocation(int userId,string date);
        List<SBALUserLocationMapView> GetUserAttenLocation(int userId);
        List<SBALUserLocationMapView> GetUserAttenRoute(int userId);

        //Added By Saurabh(11 July 2019)
        List<SBALUserLocationMapView> GetHouseAttenRoute(int userId);

        GarbagePointDetailsVM GetGarbagePointDetails(int teamId);
        GarbagePointDetailsVM SaveGarbagePointDetails(GarbagePointDetailsVM data);
        void DeletGarbagePointDetails(int teamId);

        EmployeeDetailsVM GetEmployeeDetails(int teamId);

        SBAAttendenceSettingsGridRow GetAttendenceEmployeeById(int teamId);
        void DeleteEmployeeDetails(int teamId);
        void SaveEmployeeDetails(EmployeeDetailsVM employee);

        void SaveAttendenceSettingsDetail(SBAAttendenceSettingsGridRow atten);
        ComplaintVM GetCompalint(int teamId);
        void SaveComplaintStatus(ComplaintVM employee);

        ZoneVM GetZone(int teamId);
        void SaveZone(ZoneVM employee);
        ZoneVM GetValidZone(string name,int zoneId);

        //Added By Saurabh

        DumpYardDetailsVM GetDumpYardtDetails(int teamId);

        DumpYardDetailsVM SaveDumpYardtDetails(DumpYardDetailsVM data);
        void DeletDumpYardtDetails(int teamId);

        //Added By Saurabh (27 May 2019)

        List<QrEmployeeMaster> GetUserList(int AppId, int teamId);

        //Added By Saurabh (03 June 2019)
        HouseScanifyEmployeeDetailsVM GetHSEmployeeDetails(int teamId);

        //Added By Saurabh (04 June 2019)
        void SaveHSEmployeeDetails(HouseScanifyEmployeeDetailsVM employee);

        //Added By Saurabh (04 June 2019)
        HSDashBoardVM GetHSDashBoardDetails();

        List<SBALHSUserLocationMapView> GetHSUserAttenRoute(int qrEmpDaId);

        //Added By Saurabh (06 June 2019)
        List<SBALHouseLocationMapView> GetAllHouseLocation(string date, int userid, int areaid, int wardNo, string SearchString, int? GarbageType, int FilterType);

        //Code Optimization (code)
        //SBALHouseLocationMapView1 GetAllHouseLocation(string date, int userid,int areaid, int wardNo, string SearchString, string start);

        //Added By Saurabh (1 June 2019)
        HouseScanifyEmployeeDetailsVM GetUserDetails(int teamId, string Name);

        //Added By Saurabh (2 July 2019)
        DashBoardVM GetHouseOnMapDetails();
        //Added By Neha (12 July 2019)
        List<SBAEmplyeeIdelGrid> GetIdleTimeRoute(int userId, string Date);

        OnePoint4VM GetTotalCountDetails(int ANS_ID);



        OnePoint4VM GetMaxINSERTID();

        void Save1Point4(List<OnePoint4VM> point);

        //OnePoint4VM GetQuetionDetails(int teamId);

        List<OnePoint4VM> GetQuetions(string ReportName);

        void Save1Point5(List<OnePoint5VM> point);

        List<OnePoint5VM> GetQuetions1pointfive();

        void SaveTotalCount(OnePoint4VM onepointfour);

        List<OnePoint4VM> GetOnepointfourEditData(int INSERT_ID);

        void Save1Point7(List<OnePointSevenVM> point);

        List<OnePoint7QuestionVM> GetOnePointSevenQuestions();

        List<OnePoint7QuestionVM> GetOnePointSevenAnswers(int INSERT_ID);

        void EditOnePointSeven(List<OnePoint7QuestionVM> OnePoint7QuestionVM);
        List<SelectListItem> LoadListWardNo(int ZoneId);
        List<SelectListItem> LoadListArea(int WardNo);
        //InfotainmentDetailsVW GetInfotainmentDetailsById(int ID);
        //void SaveGameDetails(InfotainmentDetailsVW data);

        SauchalayDetailsVM GetSauchalayDetails(int teamId);

        SauchalayDetailsVM SaveSauchalayDetails(SauchalayDetailsVM data);

        List<SauchalayDetailsVM> GetCTPTLocation();

        #region WasteManagement
        WasteDetailsVM GetWasteDetails(int teamId);

        //List<WasteDetailsVM> SaveWasteDetails(List<WasteDetailsVM> data);
        string SaveWasteDetails(string data);
        string SaveSalesWasteDetails(string data);
        
        List<SelectListItem> LoadListSubCategory(int categoryId);
        List<SelectListItem> GetWMUserDetails();
        #endregion

        List<LogVM> GetLogString();

        List<SBAEmplyeeIdelGrid> GetIdelTimeNotification();
        List<SBALUserLocationMapView> GetUserTimeWiseRoute(string date = "", DateTime? fTime = null, DateTime? tTime = null, int? userId = null);
    }
}
