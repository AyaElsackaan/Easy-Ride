using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;

namespace EasyRide
{
    public class Controller
    {
        DBManager dbMan;
        public Controller()
        {
            dbMan = new DBManager();
        }


        public void TerminateConnection()
        {
            dbMan.CloseConnection();
        }


        public DataTable getAllRegions()
        {
            String StoredProcedureName = StoredProcedures.getAllregions;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public DataTable AllBuses()
        {

            string StoredProcedureName = StoredProcedures.AllBuses;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable AllRegions()
        {

            string StoredProcedureName = StoredProcedures.AllRegions;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable AllDrivers()
        {

            string StoredProcedureName = StoredProcedures.AllDrivers;
            return dbMan.ExecuteReader(StoredProcedureName, null);

        }

        public int InsertCSA(int id, string name, int s, string reg, string pass)
        {

            string StoredProcedureName = StoredProcedures.InsertCSA;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@name", name);
            Parameters.Add("@s", s);
            Parameters.Add("@Reg", reg);
            Parameters.Add("@pass", pass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int InsertTrip(int code, int riders_no, int p, string time, string reg, char dir, int bno, int Did)
        {

            string StoredProcedureName = StoredProcedures.InsertTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            Parameters.Add("@Rno", riders_no);
            Parameters.Add("@price", p);
            Parameters.Add("@st_time", time);
            Parameters.Add("@Reg", reg);
            Parameters.Add("@d", dir);
            Parameters.Add("@bno", bno);
            Parameters.Add("@DID", Did);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateCSsalary(int id, int newsal)
        {
            string StoredProcedureName = StoredProcedures.UpdateCSsalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@C_S_A_ID", id);
            Parameters.Add("@NewSalary", newsal);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateDriversalary(int id, int newsal)
        {
            string StoredProcedureName = StoredProcedures.UpdateDriverSalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@DriverID", id);
            Parameters.Add("@NewSalary", newsal);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int RemoveTrip(int id)
        {
            string StoredProcedureName = StoredProcedures.RemoveTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        ///// aya on saturday////////////////////////////////////////////////////////////////


        public object checkidRider(int id)
        {
            string StoredProcedureName = StoredProcedures.checkidRider;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public object checkPassRider(int id, string pass)
        {
            string StoredProcedureName = StoredProcedures.checkPassRider;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pass", pass);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public DataTable getRegionDirections(string reg)
        {

            string StoredProcedureName = StoredProcedures.getRegionDirections;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@reg", reg);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);

        }

        public DataTable GetTrip(string reg, string dir)
        {
            string StoredProcedureName = StoredProcedures.GetTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@reg", reg);
            Parameters.Add("@dir", dir);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object getTripCode(string reg, string dir, string time)
        {
            string StoredProcedureName = StoredProcedures.getTripCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@reg", reg);
            Parameters.Add("@dir", dir);
            Parameters.Add("@time", time);

            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public object getRiderName(int id)
        {
            string StoredProcedureName = StoredProcedures.getRiderName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);

            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);


        }

        public object getRiderPhone(int id)
        {
            string StoredProcedureName = StoredProcedures.getRiderPhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);

            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public int BookTrip(int code, int id, string date)
        {
            string StoredProcedureName = StoredProcedures.BookTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            Parameters.Add("@id", id);
            Parameters.Add("@date", date);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);

        }

        public object getBusNumber(int code)
        {
            string StoredProcedureName = StoredProcedures.getBusNumber;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object getDriverName(int code)
        {
            string StoredProcedureName = StoredProcedures.getDriverName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object getDriverPhone(int code)
        {
            string StoredProcedureName = StoredProcedures.getDriverPhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object getTripPrice(int code)
        {
            string StoredProcedureName = StoredProcedures.getTripPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object getTripDuration(string reg)
        {
            string StoredProcedureName = StoredProcedures.getTripDuration;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@reg", reg);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object getCredit(int id)
        {
            string StoredProcedureName = StoredProcedures.getCredit;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object getPromo(int id)
        {
            string StoredProcedureName = StoredProcedures.getPromo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int AddPromo(int id)
        {
            string StoredProcedureName = StoredProcedures.AddPromo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable getComNo(int id)
        {
            string StoredProcedureName = StoredProcedures.getcompNo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object getReply(int comp)
        {
            string StoredProcedureName = StoredProcedures.getReply;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp", comp);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public DataTable getUpcomingTrips(int id, string date, string time)
        {
            string StoredProcedureName = StoredProcedures.getUpcomingTrips;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@time", time);
            Parameters.Add("@date", date);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable getPreviousTrips(int id, string date, string time)
        {
            string StoredProcedureName = StoredProcedures.getPreviousTrips;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@time", time);
            Parameters.Add("@date", date);

            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public object getStTime(int code)
        {
            string StoredProcedureName = StoredProcedures.getStTime;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public object getDurationFromCode(int code)
        {
            string StoredProcedureName = StoredProcedures.getDurationFromCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public int InsertRating(int id, int driver, int code, int val)
        {

            string StoredProcedureName = StoredProcedures.InsertRating;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@driver", driver);
            Parameters.Add("@code", code);
            Parameters.Add("@value", val);
           
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object getDriverID(int code)
        {
            string StoredProcedureName = StoredProcedures.getDriverID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@code", code);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }


        public int UpdatePasswordRider(int id, string pass)
        {

            string StoredProcedureName = StoredProcedures.UpdatePasswordRider;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pass", pass);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int CancelTrip(int id, int code,string date)
        {

            string StoredProcedureName = StoredProcedures.CancelTrip;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@code", code);
            Parameters.Add("@date", date);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetAllTrips()
        {
            string StoredProcedureName = StoredProcedures.GetAllTrips;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetAllCSA()
        {
            string StoredProcedureName = StoredProcedures.GetAllCSA;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public int AddDriver(int id, string name, string phone, string pass, int salary)
        {

            string StoredProcedureName = StoredProcedures.AddDriver;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@name", name);
            Parameters.Add("@phone", phone);
            Parameters.Add("@pass", pass);
            Parameters.Add("@salary", salary);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object checkidManager(int id)
        {
            string StoredProcedureName = StoredProcedures.checkidManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public object checkPassManager(int id, string pass)
        {
            string StoredProcedureName = StoredProcedures.checkPassManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pass", pass);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public int AddRider( string name, string phone, string pass)
        {

            string StoredProcedureName = StoredProcedures.AddRider;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@name", name);
            Parameters.Add("@phone", phone);
            Parameters.Add("@pass", pass);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public DataTable GetRComplaints(string reg)
        {
            string StoredProcedureName = StoredProcedures.GetRComplaints;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@reg", reg);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetDComplaints(string reg)
        {
            string StoredProcedureName = StoredProcedures.GetDComplaints;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@reg", reg);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public Object GetContent(int Cno)
        {
            string StoredProcedureName = StoredProcedures.GetContent;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp_no", Cno);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public Object GetDriverSalary(int DId)
        {
            string StoredProcedureName = StoredProcedures.GetDriverSalary;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@D_id", DId);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public Object GetAbout(int Cno)
        {
            string StoredProcedureName = StoredProcedures.GetAbout;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp_no", Cno);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public Object GetSender(int Cno)
        {
            string StoredProcedureName = StoredProcedures.GetSender;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp_no", Cno);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int SetPromo(int id)
        {
            string StoredProcedureName = StoredProcedures.SetPromo;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@R_Id", id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public Object GetTripID(int Cno)
        {
            string StoredProcedureName = StoredProcedures.GetTripID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp_no", Cno);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public Object GetTripPrice(int Tid)
        {
            string StoredProcedureName = StoredProcedures.GetTripPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@T_id", Tid);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int Refund(int Rid, int price)
        {
            string StoredProcedureName = StoredProcedures.Refund;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@price", price);
            Parameters.Add("@R_id", Rid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int Reply(int Cno, string msg)
        {
            string StoredProcedureName = StoredProcedures.Reply;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp_no", Cno);
            Parameters.Add("@msg", msg);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int PenaltyRider(int Rid)
        {
            string StoredProcedureName = StoredProcedures.PenaltyRider;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@R_id", Rid);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public object checkidCSA(int id)
        {
            string StoredProcedureName = StoredProcedures.checkidCSA;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public object checkPassCSA(int id, string pass)
        {
            string StoredProcedureName = StoredProcedures.checkPassCSA;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pass", pass);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public int UpdatePasswordManager(int id, string pass)
        {

            string StoredProcedureName = StoredProcedures.UpdatePasswordManager;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pass", pass);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdatePasswordCSA(int id, string pass)
        {

            string StoredProcedureName = StoredProcedures.UpdatePasswordCSA;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pass", pass);

            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public Object getCSregion(int id)
        {
            string StoredProcedureName = StoredProcedures.getCSregion;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public int InsertComp(int sender, int t, int about, string content)
        {

            string StoredProcedureName = StoredProcedures.InsertComp;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@sender", sender);
            Parameters.Add("@trip", t);
            Parameters.Add("@about", about);
            Parameters.Add("@content", content);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }
        public object checkidDriver(int id)
        {
            string StoredProcedureName = StoredProcedures.checkidDriver;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }
        public object checkPassDriver(int id, string pass)
        {
            string StoredProcedureName = StoredProcedures.checkPassDriver;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@id", id);
            Parameters.Add("@pass", pass);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);

        }

        public DataTable GetDriversID()
        {
            String StoredProcedureName = StoredProcedures.GetDriversID;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetDriversTrips(int id)
        {
            String StoredProcedureName = StoredProcedures.GetDriversTrips;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@Driver_ID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetUpcomingRider(string date)
        {
            String StoredProcedureName = StoredProcedures.GetUpcomingRider;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@trip_date", date);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }

        public DataTable GetPreviousRider()
        {
            String StoredProcedureName = StoredProcedures.GetPreviousRider;
            return dbMan.ExecuteReader(StoredProcedureName, null);
        }

        public DataTable GetRiderDetails(int id)
        {
            String StoredProcedureName = StoredProcedures.GetRiderDetails;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteReader(StoredProcedureName, Parameters);
        }
        public object GetRidersName(int id)
        {
            String StoredProcedureName = StoredProcedures.GetRidersName;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetRidersPhone(int id)
        {
            String StoredProcedureName = StoredProcedures.GetRidersPhone;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public object GetPrice(int id)
        {
            String StoredProcedureName = StoredProcedures.GetPrice;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@ID", id);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }


        public int Complain(int Cno, string msg)
        {
            string StoredProcedureName = StoredProcedures.Complain;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@comp_no", Cno);
            Parameters.Add("@msg", msg);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public int UpdateRiderWallet(int change, int R_id)
        {
            string StoredProcedureName = StoredProcedures.Complain;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@price", change);
            Parameters.Add("@R_ID", R_id);
            return dbMan.ExecuteNonQuery(StoredProcedureName, Parameters);
        }

        public Object GetTripPriceM(int Tid)
        {
            string StoredProcedureName = StoredProcedures.GetTripPriceM;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@T_id", Tid);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public Object GetTripCode(int Rid)
        {
            string StoredProcedureName = StoredProcedures.GetTripCode;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@R_ID", Rid);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }

        public Object GetRiderID(int Tid)
        {
            string StoredProcedureName = StoredProcedures.GetRiderID;
            Dictionary<string, object> Parameters = new Dictionary<string, object>();
            Parameters.Add("@T_id", Tid);
            return dbMan.ExecuteScalar(StoredProcedureName, Parameters);
        }




    }
}
