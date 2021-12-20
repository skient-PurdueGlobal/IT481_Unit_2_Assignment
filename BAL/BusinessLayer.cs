using System;
using System.Data;

namespace IT481_Unit_2_Assignment.BAL
{
    class BusinessLayer
    {
        //Class Initialization
        DAL.DBAccessLayer dbAccess = new DAL.DBAccessLayer();

        //Data Objects
        DataTable customerData = new DataTable();

        //Variables
        string connString = @"Data Source=dellG3;Initial Catalog=Northwind;Integrated Security=true;TrustServerCertificate=true";

        //Methods
        public string Load_Customer_Data()
        {
            string status = "";

            try
            {
                customerData = dbAccess.Get_Customers(connString);
                status = "Connection Established Successfully..." + Environment.NewLine + "Customer Data Loaded Successfully...";
            }
            catch (Exception ex)
            {
                status = "Error:  " + ex.Message;
            }

            return status;
        }
        public string Save_Customer_Data()
        {
            string status = "";

            try
            {
                dbAccess.Save_Customers(customerData, connString);
                status = "Database Successfully Updated...";
            }
            catch (Exception ex)
            {
                status = "Error" + ex.Message;
            }

            return status;
        }
        public DataTable Populate_DataGrid()
        {
            return customerData;
        }
        public int Count_Customer_Records()
        {
            return customerData.Rows.Count;
        }
        public void Add_Customer_Record(string id, string company)
        {
            DataRow row = customerData.NewRow();
            row["CustomerID"] = id;
            row["CompanyName"] = company;

            customerData.Rows.Add(row);
        }
    }
}
