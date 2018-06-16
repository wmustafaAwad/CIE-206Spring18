using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;


namespace Database_Forms
{
    public class Controller
    {
        DBManager dbMan;
        public static int CID;
        public Controller()
        {
            dbMan = new DBManager();
        }
        public string CheckPassword(String username, String password)
        {
            string query = "Select Privilege From LoginInfo Where" + "'" + username + "'" + "= Username AND" + "'" + password + "'" + "=uPassword";
            return dbMan.ExecuteScalarQuery(query).ToString();
        }
        public int AddSupplier(int SprID, String Name, String PhoneNum, String mail,/**Removed the rest and SAddress Added**/ String SAddress)
        // Add Supplier given these information
        {
            string query = "INSERT INTO Supplier(ID,Name,PhoneNum,Email,SAddress) Values("
            + SprID + ",'"
            + Name + "',"
            + PhoneNum + ",'" //Notice there are no " ' " because I want PhoneNum to be input as a number no text.Although it is originally a string.
            + mail + "','"
            + SAddress + "');";
            return dbMan.UpdateData(query);


        }
        public int AddUser(String username, String upassword, String privilege)
        {
            //returns -1 if username already exists, returns 1 if user creation is successful
            string query = "INSERT  INTO LoginInfo (Username, uPassword, Privilege) "
                + "Values( '" + username + "', '" + upassword + "', " + privilege + ");";
            return dbMan.UpdateData(query);
        }

        public int ChangePassword(String username, String currentPassword, String newPassword)
        {
            //result = -1 if currentPassword does not match uPassword or username not correct, result = 1 if password change is successful
            int result;
            string query0 = "SELECT uPassword FROM LoginInfo WHERE Username = '" + username + "';";
            string dbPassword = dbMan.ExecuteScalarQuery(query0).ToString();
            if (dbPassword.CompareTo(currentPassword) != 0)
                result = -1;
            else
            {
                string query = "UPDATE LoginInfo SET uPassword = '" + newPassword + "' WHERE Username = '" + username + "';";
                result = dbMan.UpdateData(query);
            }
            return result;
        }

        public int AddEmployee(String Fname, String Mname, String Lname, bool Gender, int ID, String NatID, String Phone_Num, String mail, int Salary, String Job_Type, String SuperVisorID)

        //Adds Employee given these information.
        //Job_ID is zero if no such job is found (Hopefully won't happen since the user chooses from a list, 
        //but zero is to prevent program from crashing and know the error type).
        {
            String Job_ID;
            string query1 = "SELECT ID FROM Job WHERE Descr like '%" + Job_Type + "%' ;"; //First query to get Job_ID.

            Job_ID = dbMan.ExecuteScalarQuery(query1).ToString();


            int sex;
            if (Gender) { sex = 1; } else { sex = 0; } //To fix that bool for sql is 0 and 1, while bool for C# is true and false.


            //The Query:
            string query2 = "INSERT INTO Employee (ID,FName,MNames,LName,Gender,NatID,Phone_Num,Email,BasicSalary,JobID,SupervisorID) " +
                            "Values (" + ID + ",'"
                            + Fname + "','"
                            + Mname + "','"
                            + Lname + "',"
                            + sex + ",'"
                            + NatID + "','"
                            + Phone_Num + "','"
                            + mail + "',"
                            + Salary + ","
                            + Job_ID + ","
                            + SuperVisorID + ");";

            return dbMan.UpdateData(query2);
        }

        public int AddSupply(int SpyID, String Name, double UnitPrice, String Unit)
        //Add supply given these information
        {

            String Unit_ID;
            string query1 = "SELECT ID FROM MeasurementUnit  WHERE Descr like '%" + Unit + "%' ;"; //First query to get Unit_ID.

            Unit_ID = dbMan.ExecuteScalarQuery(query1).ToString();

            string query2 = "INSERT INTO Supply(ID,Name,UnitPrice,UnitID) VALUES("
                + SpyID + ",'"
                + Name + "',"
                + UnitPrice + ","
                + Unit_ID + ");";

            return dbMan.UpdateData(query2);
        }



        public String GetTotal_Income(int Start_Month, int Start_Day, int End_Month, int End_Day)
        //Gets Total Income over a time period of time //Year is always this year.
        {
            string This_Year = DateTime.Now.Year.ToString();
            string query1 = "SELECT SUM(TotalPrice) FROM Cust_Order WHERE NOT(OTimeStamp > '"
                + This_Year + "-" + End_Month + "-" + End_Day
                + "' OR OTimeStamp < '"
                + This_Year + "-" + Start_Month + "-" + Start_Day + "');";
            return dbMan.ExecuteScalarQuery(query1).ToString();
        }

        public string GetMostUsedItem(int Start_Month, int Start_Day, int End_Month, int End_Day)
        { //View the most frequently bought items in a time period of his/her choice

            string This_Year = DateTime.Now.Year.ToString();
            string query1 = " SELECT Name FROM Item WHERE ID in(SELECT ItemID FROM(SELECT SUM(Number) as summed_n , ItemID From OrderItems AS OI WHERE OI.OrderID IN(Select OrderID FROM Cust_Order WHERE  NOT(OTimeStamp > '"
                    + This_Year + "-" + End_Month + "-" + End_Day + " ' OR OTimeStamp < '"
                    + This_Year + "-" + Start_Month + "-" + Start_Day + "'))"
                    + " Group By ItemID) as Summed_All Where summed_n = (SELECT MAX(a.Total_Qty) as 'Max_Qty' From(SELECT OT.ItemID, SUM(OT.Number) AS Total_Qty FROM OrderItems as OT GROUP BY OT.ItemID) as a));";
            return dbMan.ExecuteScalarQuery(query1).ToString();
        }

        public DataTable ViewMostActiveCusts(int Start_Month, int Start_Day, int End_Month, int End_Day)
        {   //Allows Supervisor to view Most Active Customer(s) within a certain time frame to send them Offers/Invitations.
            //Phone Number and first name are displayed.

            string This_Year = DateTime.Now.Year.ToString();
            string query1 = "Select Fname,PhoneNum  /*Select Needed Data*/ From Customer  Where ID IN (SELECT  CustID /*Select the CustID with max time*/FROM (SELECT COUNT(*) AS times, CustID FROM Cust_Order" +
                        " Where NOT(Cust_Order.OTimeStamp> '"
                        + This_Year + "-" + End_Month + "-" + End_Day
                        + "' OR Cust_Order.OTimeStamp < '"
                        + This_Year + "-" + Start_Month + "-" + Start_Day + "' )"
                        + " group by CustID) CustID Where times = (SELECT MAX(a.Total_Qty) as 'Max_Qty' From(SELECT CustID, COUNT(*) AS Total_Qty /*Find Max Time*/ FROM Cust_Order"
                        + " Where NOT(Cust_Order.OTimeStamp> '"
                        + This_Year + "-" + End_Month + "-" + End_Day
                        + "' OR Cust_Order.OTimeStamp < '"
                        + This_Year + "-" + Start_Month + "-" + Start_Day + "' )" +
                        "GROUP BY CustID) as a))";
            return dbMan.ExecuteTableQuery(query1);
        }

        public DataTable ViewOrderListAndStatus(int limt_minutes)
        {
            //Displays A list of order ID’s and their status, ordered limit_minutes away. (Maximum is not 60, can enter Up to 4 Hours earlier (random choice of limit))  //Also shows  customer name 
            //--Order, OStatus,Customer

            string query1 = "Select FName, OrderID, Descr from Customer, Cust_Order, OrderStatus Where OstatusID = OrderStatus.ID AND Cust_Order.CustID = Customer.ID AND OTimeStamp> DateAdd(MINUTE, DateDiff(MINUTE, 0, GetDate()) - "
                + limt_minutes + ", 0);";
            return dbMan.ExecuteTableQuery(query1);
        }
        public int AddOrder(int Status, int CashierID, int CustID, double Net_Price, int BranchID)
        {
            //Autogenerates OrderID from Last Order (So that Chef would know what order came first). 
            //Timestamp Auto-generated.  
            //ServicePrice and TaxPrice are calculated from Net Price. Total Price is calculated from Net Price + Service Price + Tax Price. 
            //Also Subtracts the amount used from every raw material from each item on the order used, from Branch_Has.


            //Get Previous Order_ID and ADD 1

            string query1 = "select MAX(OrderID) from Cust_Order";
            int new_order_id = Int32.Parse(dbMan.ExecuteScalarQuery(query1).ToString()) + 1;


            //Timestamp Auto-generated.  

            DateTime TheMoment = DateTime.Now;

            //Get ServicePrice and TaxPrice and TotalPrice

            double ServicePrice = Net_Price * 0.12;
            double TaxPrice = Net_Price * 0.13;
            double TotalPrice = Net_Price + ServicePrice + TaxPrice;

            //AddOrder
            string query2 = "Insert Into Cust_Order Values("
                + new_order_id + ",'"
                + TheMoment + "',"
                + Status + ","
                + CashierID + ","
                + CustID + ","
                + Net_Price + ","
                + ServicePrice + ","
                + TaxPrice + ","
                + TotalPrice + ","
                + BranchID + ");";
            dbMan.UpdateData(query2);
            return new_order_id;
        }
        public int UpdateRawMaterialPrice(int Spy_ID, double New_Price)
        {
            /* Updates item prices given a new price to a certain raw material. 
Algorithm: Gets all items containing a certain raw material, then for each item: Averages old and new price of the raw material, and subracts (new_price - old_price)*Qty of  the raw material used in item, from the item price.*/

            string query1 = "select UnitPrice from Supply Where ID =" + Spy_ID + ";";
            double Old_Price = double.Parse(dbMan.ExecuteScalarQuery(query1).ToString());
            string query2 = "Update Supply Set UnitPrice = " + New_Price + " Where ID =" + Spy_ID;
            dbMan.UpdateData(query2);

            string query3 = "Select ID From Item Where ID in(Select ItemID from ItemContains where SupplyID =" + Spy_ID + ")";

            DataTable ItemIDtable = dbMan.ExecuteTableQuery(query3); //Table Items
            int ctr = 0;
            string query5, query6, query7; double QuantityUsed; double CurrentItemPrice;
            string existQuery = "SELECT COUNT(*) FROM ItemContains  WHERE SupplyID= " + Spy_ID;
            int IsExist = Int16.Parse(dbMan.ExecuteScalarQuery(existQuery).ToString());

            if (IsExist != 0)
            {
                foreach (DataRow row in ItemIDtable.Rows)
                {
                    foreach (var itemID in row.ItemArray)
                    {
                        query5 = "select Qty FROM ItemContains Where ItemID =" + itemID + "AND SupplyID = " + Spy_ID + ";";
                        QuantityUsed = double.Parse(dbMan.ExecuteScalarQuery(query5).ToString());
                        query6 = "select Price from Item Where ID =" + itemID + ";";
                        CurrentItemPrice = double.Parse(dbMan.ExecuteScalarQuery(query6).ToString());
                        double newItemPrice = CurrentItemPrice - QuantityUsed * CurrentItemPrice + QuantityUsed * (New_Price + CurrentItemPrice) / 2;
                        query7 = "update Item Set Price =" + newItemPrice + "where ID=" + itemID + ";";
                        dbMan.UpdateData(query7);
                        Console.Write("Item: "); // Print label.
                        Console.WriteLine(itemID);
                        Console.Write("New_Price:");
                        Console.WriteLine(newItemPrice);
                    }
                }
            }




            return 0;


        }

        public int AddBranch_WarehouseTransaction(int BID, int WHID, int SupplyID, DateTime Date1, int Qty, String Unit, int Price)
        { //Subtracts Qty from Warehouse_Has table with SupplyID and adds it to the quantity in Branch_Gets table, under the same SupplyID. Also adds it to the Branch_Has table, with the same SupplyID.
          //-- Branch_Has, Branch_Gets, Supply

            String Unit_ID;
            string query1 = "SELECT ID FROM MeasurementUnit  WHERE Descr like '%" + Unit + "%' ;"; //First query to get Unit_ID.
            Unit_ID = dbMan.ExecuteScalarQuery(query1).ToString();


            string query2 = "INSERT INTO BranchGets(BranchID,WarehouseID,SupplyID,ArrivalDate,QTY,UnitID,UnitPrice) VALUES("
                + BID + ","
                + WHID + ","
                + SupplyID + ",'"
                + Date1 + "',"
                + Qty + ","
                + Unit_ID + ","
                + Price + ");";
            dbMan.UpdateData(query2);
            //Added to BranchGets

            string query3 = "select Qty from BranchHas Where SupplyID =" + SupplyID + " AND BranchID=" + BID + ";";
            double Old_Quantity = double.Parse(dbMan.ExecuteScalarQuery(query3).ToString());
            double NewQuantity = Old_Quantity + Qty;
            string query4 = "Update BranchHas SET Qty =" + NewQuantity + " Where SupplyID =" + SupplyID + " AND BranchID=" + BID + "; ";
            dbMan.UpdateData(query4);
            //Added to  BranchHas 
            //Need to check first if it does not exist to Insert instead of Update  but will do this later


            //Subtracted to WareHouseHas
            string query5 = "Select TransactionID From WarehouseHas Where SupplyID=" + SupplyID + ";";
            DataTable Transtable = dbMan.ExecuteTableQuery(query5); //Table Items

            double Needed_Quantity = Qty; double AvaialbleWithExpiringBatch;

            string query6; string query7;

            while (Needed_Quantity > 0)
            {
                query6 = "select QtyLeft From WarehouseHas W where W.SupplyID =" + SupplyID + " and ExpiryDate = (Select Min(ExpiryDate) From WarehouseHas H Where H.SupplyID = W.SupplyID );";
                AvaialbleWithExpiringBatch = double.Parse(dbMan.ExecuteScalarQuery(query6).ToString());

                if (AvaialbleWithExpiringBatch >= Needed_Quantity)
                {
                    AvaialbleWithExpiringBatch -= Needed_Quantity; //Then Update the AvaialableWithExpiringBatch
                    query7 = "Update WareHouseHas  SET QtyLeft =" + AvaialbleWithExpiringBatch + " where TransactionID in(select TransactionID From WarehouseHas W where W.SupplyID =" + SupplyID + " and ExpiryDate = (Select Min(ExpiryDate) From WarehouseHas H Where H.SupplyID = W.SupplyID ))";
                    dbMan.UpdateData(query7);
                }
                else
                {
                    Needed_Quantity -= AvaialbleWithExpiringBatch; //Then AvailableWithExpiration=0, and delete it.
                    query7 = "Delete From WarehouseHas where TransactionID in(select TransactionID From WarehouseHas W where W.SupplyID =" + SupplyID + " and ExpiryDate = (Select Min(ExpiryDate) From WarehouseHas H Where H.SupplyID = W.SupplyID ))";
                    dbMan.UpdateData(query7);
                }




            }


            /*foreach (DataRow row in Transtable.Rows)
            {
                foreach (var TID in row.ItemArray)
                {
                    
                }

            }*/










            return 0;
        }
        public DataTable GetEmployeeBySearch(String Fname, String Mname, String Lname, int? Gender, String ID, String NatID, String Phone_Num, String Email, String BasicSalary, int? JobID, String SupervisorID)
        {
            string query = "SELECT * FROM Employee WHERE ";
            if (Fname != "")
            {
                query += "FName = '" + Fname + "'";
                if ((Mname != "") || (Lname != "") || (Gender != -1) || (ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (Mname != "")
            {
                query += "MNames = '" + Mname + "'";
                if ((Lname != "") || (Gender != -1) || (ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (Lname != "")
            {
                query += "LName = '" + Lname + "'";
                if ((Gender != -1) || (ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (Gender != -1)
            {
                query += "Gender = " + Gender;
                if ((ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (ID != "")
            {
                query += "ID = '" + ID + "'";
                if ((NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (NatID != "")
            {
                query += "NatID = '" + NatID + "'";
                if ((Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (Phone_Num != "")
            {
                query += "Phone_Num = '" + Phone_Num + "'";
                if ((Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (Email != "")
            {
                query += "Email = '" + Email + "'";
                if ((BasicSalary != "") || (JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (BasicSalary != "")
            {
                query += "BasicSalary = '" + BasicSalary + "'";
                if ((JobID != 0) || (SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (JobID != 0)
            {
                query += "JobID = " + JobID;
                if ((SupervisorID != "")) {
                    query += " AND ";
                }
            }
            if (SupervisorID != "")
            {
                query += "SupervisorID =" + Int16.Parse(SupervisorID);
            }
            return dbMan.ExecuteTableQuery(query);
        }
        public int UpdateEmployee(String Fname, String Mname, String Lname, int? Gender, String ID, String NatID, String Phone_Num, String Email, String BasicSalary, int? JobID, String SupervisorID, String Fname1, String Mname1, String Lname1, int? Gender1, String ID1, String NatID1, String Phone_Num1, String Email1, String BasicSalary1, int? JobID1, String SupervisorID1)
        {
            string query = "UPDATE Employee SET ";
            if (Fname != "")
            {
                query += "FName = '" + Fname + "'";
                if ((Mname != "") || (Lname != "") || (Gender != -1) || (ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (Mname != "")
            {
                query += "MNames = '" + Mname + "'";
                if ((Lname != "") || (Gender != -1) || (ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (Lname != "")
            {
                query += "LName = '" + Lname + "'";
                if ((Gender != -1) || (ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (Gender != -1)
            {
                query += "Gender = " + Gender;
                if ((ID != "") || (NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (ID != "")
            {
                query += "ID = '" + ID + "'";
                if ((NatID != "") || (Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (NatID != "")
            {
                query += "NatID = '" + NatID + "'";
                if ((Phone_Num != "") || (Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (Phone_Num != "")
            {
                query += "Phone_Num = '" + Phone_Num + "'";
                if ((Email != "") || (BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (Email != "")
            {
                query += "Email = '" + Email + "'";
                if ((BasicSalary != "") || (JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (BasicSalary != "")
            {
                query += "BasicSalary = '" + BasicSalary + "'";
                if ((JobID != 0) || (SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (JobID != 0)
            {
                query += "JobID = " + JobID;
                if ((SupervisorID != ""))
                {
                    query += " , ";
                }
            }
            if (SupervisorID != "")
            {
                query += "SupervisorID =" + Int16.Parse(SupervisorID);
            }
            query += " WHERE ";

            if (Fname1 != "")
            {
                query += "FName = '" + Fname1 + "'";
                if ((Mname1 != "") || (Lname1 != "") || (Gender1 != -1) || (ID1 != "") || (NatID1 != "") || (Phone_Num1 != "") || (Email1 != "") || (BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (Mname1 != "")
            {
                query += "MNames = '" + Mname1 + "'";
                if ((Lname1 != "") || (Gender1 != -1) || (ID1 != "") || (NatID1 != "") || (Phone_Num1 != "") || (Email1 != "") || (BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (Lname1 != "")
            {
                query += "LName = '" + Lname1 + "'";
                if ((Gender1 != -1) || (ID1 != "") || (NatID1 != "") || (Phone_Num1 != "") || (Email1 != "") || (BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (Gender1 != -1)
            {
                query += "Gender = " + Gender1;
                if ((ID1 != "") || (NatID1 != "") || (Phone_Num1 != "") || (Email1 != "") || (BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (ID1 != "")
            {
                query += "ID = '" + ID1 + "'";
                if ((NatID1 != "") || (Phone_Num1 != "") || (Email1 != "") || (BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (NatID1 != "")
            {
                query += "NatID = '" + NatID1 + "'";
                if ((Phone_Num1 != "") || (Email1 != "") || (BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (Phone_Num1 != "")
            {
                query += "Phone_Num = '" + Phone_Num1 + "'";
                if ((Email1 != "") || (BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (Email1 != "")
            {
                query += "Email = '" + Email1 + "'";
                if ((BasicSalary1 != "") || (JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (BasicSalary1 != "")
            {
                query += "BasicSalary = '" + BasicSalary1 + "'";
                if ((JobID1 != 0) || (SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (JobID1 != 0)
            {
                query += "JobID = " + JobID1;
                if ((SupervisorID1 != ""))
                {
                    query += " AND ";
                }
            }
            if (SupervisorID1 != "")
            {
                query += "SupervisorID =" + Int16.Parse(SupervisorID1);
            }
            return dbMan.UpdateData(query);
        }

        public int AddBranch(int BID, int MngrID, String BAddress, String OpensAt, String ClosesAt, int Capacity, String Contact_Info)
        {
            string query = "INSERT INTO Branch (ID, MngrID, BAddress, OpensAt, ClosesAt, Capacity, PhoneNum)  " +
                            "Values ('" + BID + "','" + MngrID + "','" + BAddress + "',' " + OpensAt + " ',' " + ClosesAt + " ',' " + Capacity + " ', " + Contact_Info + ");";

            return dbMan.UpdateData(query);
        }

        public int AddWarehouse(int WID, int MngrID, String Address, String Phone_Num)
        {
            string query = "INSERT INTO Warehouse (ID, MgrID, WAddress,PhoneNum) " +
                            "Values ('" + WID + "','" + MngrID + "','" + Address + "'," + Phone_Num + ");";

            return dbMan.UpdateData(query);
        }
        public int InsertJobWH(int WHID, String EmpID) {
            string query = "INSERT INTO WorksAtWH VALUES (" + Int16.Parse(EmpID) + "," + WHID + ")";
            return dbMan.UpdateData(query);
        }
        public int InsertJobBr(int BrID, String EmpID)
        {
            string query = "INSERT INTO WorksAtBr VALUES (" + Int16.Parse(EmpID) + "," + BrID + ")";
            return dbMan.UpdateData(query);
        }
        public int UpdateJobWH(int WHID, String EmpID, int WHID1)
        {
            string query = "UPDATE WorksAtWH SET WarehouseID = " + WHID + "WHERE WarehouseID = " + WHID1 + " AND EmployeeID = " + Int16.Parse(EmpID);
            return dbMan.UpdateData(query);
        }
        public int UpdateJobBr(int BrID, String EmpID, int BrID1)
        {
            string query = "UPDATE WorksAtBr SET BranchID = " + BrID + "WHERE BranchID = " + BrID1 + " AND EmployeeID = " + Int16.Parse(EmpID);
            return dbMan.UpdateData(query);
        }
        public int DeleteJobWH(String EmpID)
        {
            string query = "DELETE FROM WorksAtWH WHERE EmployeeID =" + Int16.Parse(EmpID);
            return dbMan.UpdateData(query);
        }
        public int DeleteJobBr(String EmpID)
        {
            string query = "DELETE FROM WorksAtBr WHERE EmployeeID =" + Int16.Parse(EmpID);
            return dbMan.UpdateData(query);
        }
        public DataTable GetWHID()
        {
            string query = "SELECT DISTINCT WarehouseID FROM WorksAtWH";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable GetBrID()
        {
            string query = "SELECT DISTINCT BranchID FROM WorksAtBr";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable GetWorksAt(int EmpID)
        {
            string query = "Select BranchID, WarehouseID From((Select concat(C.EmployeeID, d.EmployeeID) as EmpID, BranchID, WarehouseID From WorksAtBr C full outer join WorksAtWH d on C.EmployeeID = d.EmployeeID)) as A Where EmpID =" + EmpID;
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable GetMenuItems()
        {
            string query = "SELECT Name FROM Item";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable GetPrice(String Name)
        {
            string query = "SELECT Price FROM Item WHERE Name =" + "'" + Name + "'";
            return dbMan.ExecuteTableQuery(query);
        }
        public int AddCustomer(int CID, String Fname, String Mname, String Lname, String PhoneNum, String mail, String Address)
        {
            string query = "Insert into Customer (ID, FName, MNames, LName, PhoneNum, Email, CAddress) " +
                        "Values ('" + CID + "','" + Fname + "','" + Mname + "',' " + Lname + " ',' " + PhoneNum + " ',' " + mail + "','" + Address + "');";

            return dbMan.UpdateData(query);

        }
        public DataTable GetCustomerBySearch(String FName, String MNames, String LName, String PhoneNum, String Email)
        {
            //Returns Customer(s) by searching
            //Waleed
            bool ANDflg = false;
            bool Pflg = false;
            string query = "Select* From Customer Where(FName+' '+MNames+' '+LName) Like ";
            if (FName != "")
            {
                query += ("'%" + FName + "%'");
                ANDflg = true;
                Pflg = true;

            }
            if (MNames != "")
            {
                query += (Pflg) ? " + " : " ";
                query += ("'%" + MNames + "%'");
                ANDflg = true;
                Pflg = true;

            }
            if (LName != "")
            {
                query += (Pflg) ? " + " : " ";
                query += ("'%" + LName + "%'");
                ANDflg = true;
            }
            if (PhoneNum != "")
            {
                query += (ANDflg) ? " AND " : " ";

                query += (" PhoneNum ='" + PhoneNum + "'");

                ANDflg = true;
            }
            if (Email != "")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("Email = '" + Email + "' ");
            }


            return dbMan.ExecuteTableQuery(query);

        }

        public DataTable DisplayByPopularity()
        {//Returns Items sorted by popularity
         //Waleed
            String query = "Select Name, Popularity From Item_Name_Popularity Order By Popularity Desc";
            return dbMan.ExecuteTableQuery(query);
        }
        public String GetPopularity(string itemName)
        {//Display Popularity of an item given its name. Popularity is defined as : Total number of times the item was ordered/Total number of orders (i.e. can be greater than one)
         //Waleed

            String query = "Select Popularity From Item_Name_Popularity Where Name Like '%" + itemName + "%';";
            return dbMan.ExecuteScalarQuery(query).ToString();

        }
        public DataTable GetOID()
        {
            string query = "SELECT MAX(OrderID) AS OrderID FROM Cust_Order";
            return dbMan.ExecuteTableQuery(query);
        }

        public int AddOrder_Item(String OrderID, String ItemID, String Number, String BID)
        {
            /*Adds an item ItemID to the order of OrderID Number  of times. Should be used in parallel with AddOrder.*/
            //Shahd 
            String query0 = "SELECT COUNT(*) FROM OrderItems WHERE OrderID = " + OrderID +
                " AND ItemID = " + ItemID + ";";
            int OrderItemExists = Int32.Parse(dbMan.ExecuteScalarQuery(query0).ToString());

            string query;
            if (OrderItemExists == 0)
            {
                query = "INSERT INTO OrderItems " +
                                           "Values (" + OrderID + ", " + ItemID + ", " + Number + ");";
                dbMan.UpdateData(query);

            }
            else
            {
                query = "UPDATE OrderItems SET Number = Number +" + Number + " WHERE OrderID =" + OrderID + " AND ItemID=" + ItemID + " ;";
                dbMan.UpdateData(query);

            }
            string queryF = "Select Qty from BranchHas Where SupplyID=" + ItemID + "And BranchID=" + BID;
            double ExistingQuantity = Convert.ToDouble(dbMan.ExecuteScalarQuery(queryF).ToString());
            double currentQty = ExistingQuantity - Convert.ToDouble(Number);
            string queryF2 = "UPDATE BranchHas SET Qty=" + currentQty + "Where SupplyID=" + ItemID + "And BranchID=" + BID;
            return dbMan.UpdateData(queryF2);

        }

        public DataTable GetItemIDbyName(string Name)
        {
            string query = "SELECT ID FROM Item WHERE Name =" + "'" + Name + "'";
            return dbMan.ExecuteTableQuery(query);
        }

        public int EditOrderStatus(String Status, int OrderID)
        { //Aya
            int statusID = 0;
            if (Status == "Pending")
                statusID = 2;
            if (Status == "Cancelled")
                statusID = 3;
            if (Status == "Served")
                statusID = 1;
            string query = "update Cust_Order set OStatusID= " + statusID + " where OrderID= " + OrderID;
            return dbMan.UpdateData(query);
        }
        public DataTable ShowWareHouse_SupplierTransaction(String WHID, String SupplyID, String SupplierID, String ArrivalDate, String ExpiryDate)
        {
            //Shows a WareHouse_Supplier Transaction given their info.
            //Waleed
            String query = "Select * From WarehouseGets Where ";
            bool ANDflg = false;

            if (WHID != "0")
            {

                query += ("WarehouseID=" + WHID);
                ANDflg = true;

            }

            if (SupplyID != "0")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("SupplyID=" + SupplyID);
                ANDflg = true;
            }


            if (SupplierID != "0")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("SupplierID=" + SupplierID);
                ANDflg = true;
            }



            if (ArrivalDate != "")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("ArrivalDate='" + ArrivalDate + "'");
                ANDflg = true;
            }


            if (ExpiryDate != "")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("ExpiryDate='" + ExpiryDate + "'");
                ANDflg = true;
            }

            return dbMan.ExecuteTableQuery(query);


        }
        public DataTable GetSupplyName()
        {
            string query = "SELECT Name FROM Supply";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable GetSupplierName()
        {
            string query = "SELECT Name FROM Supplier";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable ShowBranch_WarehouseTransaction(String BID, String WHID, String SupplyID, String Date1)
        {
            //Show All Branch_Warehouse Transactions given certain constraints. Can, for example show all transactions for a Warehouse,or show all transactions for a Branch (separately).
            //Waleed

            String query = "Select * From BranchGets Where ";
            bool ANDflg = false;


            if (BID != "0")
            {
                query += ("BranchID=" + BID);
                ANDflg = true;
            }

            if (WHID != "0")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("WarehouseID=" + WHID);
                ANDflg = true;

            }

            if (SupplyID != "0")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("SupplyID=" + SupplyID);
                ANDflg = true;
            }

            if (Date1 != "")
            {
                query += (ANDflg) ? " AND " : " ";
                query += ("ArrivalDate='" + Date1 + "'");
                ANDflg = true;
            }

            return dbMan.ExecuteTableQuery(query);


        }
        public int AddWareHouse_SupplierTransaction(String WHID, String SupplyID, String SupplierID, String Qty, String Unit, String ArrivalDate, String ExpiryDate, String UnitPrice)
        {   //Gets Unit_ID from Unit
            //Generates TransactionID from last Transaction's ID+1

            //Get Unit_ID
            String Unit_ID;
            string query1 = "SELECT ID FROM MeasurementUnit  WHERE Descr like '%" + Unit + "%' ;"; //First query to get Unit_ID.

            Unit_ID = dbMan.ExecuteScalarQuery(query1).ToString();

            //Get Previous Transaction_ID and Add 1

            string query2 = "Select MAX(TransactionID) from WarehouseGets";
            int new_transaction_id = Int32.Parse(dbMan.ExecuteScalarQuery(query2).ToString()) + 1;


            //Insert now
            string query3 = "INSERT INTO WarehouseGets Values(" + new_transaction_id + ","
                + WHID + ","
                + SupplyID + ","
                + SupplierID + ","
                + Qty + ","
                + Unit_ID + ",'"
                + ArrivalDate + "','"
                + ExpiryDate + "',"
                + UnitPrice + ")";

            Console.Write(query3);

            return dbMan.UpdateData(query3);


        }
        public DataTable GetUnits()
        {
            string query = "SELECT Descr FROM MeasurementUnit";
            return dbMan.ExecuteTableQuery(query);
        }

        public int AddMenu_Item(int IID, String Name, int Price, int IType, bool Availability)
        { //Aya
            int av = 0;
            if (Availability == true) av = 1;
            if (Availability == false) av = 0;

            string query = "Insert into Item (ID, Name, Price, ItemCategoryID, IAvailability) " +
                            "Values ('" + IID + "','" + Name + "','" + Price + "',' " + IType + " ', " + av + " );";

            return dbMan.UpdateData(query);

        }
        public DataTable GetItemCategory()
        {
            string query = "SELECT Descr FROM ItemCategory";
            return dbMan.ExecuteTableQuery(query);
        }
        public DataTable GetMaxIID()
        {
            string query = "SELECT Max(ID) AS ID FROM Item";
            return dbMan.ExecuteTableQuery(query);
        }
        public object GetAv(string Name)
        {
            string query = "SELECT IAvailability FROM Item Where Name ='" + Name + "'";
            return dbMan.ExecuteScalarQuery(query);
            
        }
        public int Edit_ItemAvailability(int IID)
        { //Complements (i.e. reverses) the state of the item Availability given ItemID.
          //Aya

            string query = "update Item Set IAvailability= ~ Item.IAvailability Where ID= " + IID;
            return dbMan.UpdateData(query);
        }
        public int Add_Item_Ingredient(int IID, int SpyID, double Qty)
        { //Aya
            string queryAya1 = "Select UnitID from Supply Where ID= " + SpyID;
            int UnitID = Int32.Parse(dbMan.ExecuteScalarQuery(queryAya1).ToString());

            string queryAya2 = "Insert into ItemContains (ItemID, SupplyID, Qty, UnitID) " +
                                "Values ('" + IID + "','" + SpyID + "','" + Qty + " ', " + UnitID + " );";
            dbMan.UpdateData(queryAya2); //Added to ItemContains



            //Get SupplyPrice
            string queryWaleed1 = "Select UnitPrice From Supply Where ID=" + SpyID;
            double SupplyUnitPrice = double.Parse(dbMan.ExecuteScalarQuery(queryWaleed1).ToString());

            //Add SupplyPrice*Quantity to Original Price
            string queryWaleed2 = "Update Item Set Price= Price +" + SupplyUnitPrice + "*" + Qty + " Where ID=" + IID;

            return dbMan.UpdateData(queryWaleed2);

        }
        public DataTable View_ItemContents(int IID) //View ingredients of an item given its ID.
        { //Aya

            string query = "Select Name from Supply where ID IN" + " (Select SupplyID from ItemContains Where ItemID= " + IID + " group by SupplyID)";
            Console.Write(query);

            return dbMan.ExecuteTableQuery(query);

        }


    }


}

;