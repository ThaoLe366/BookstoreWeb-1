﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace BOOKSTOREWEB.DAO
{
    public class BillDAO
    {
        private static BillDAO instance;
        public static BillDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new BillDAO();
                return instance;
            }
            private set { instance = value; }
        }

        private BillDAO()
        {

        }

        public DataTable GetListTransport()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListTransport");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetListTransportByState(string state)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetListTransportByState @state", new object[] { state });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetOrderByIDBill(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetOrderByIDBill @idBill", new object[] { idBill });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public bool UpdateOrderStateByIdBill(int idBill, string state)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("USP_UpdateOrderStateByIdBill @idBill , @state", new object[] { idBill, state });
            return result > 0;
        }

        public DataTable GetTransportDetailByIDBill(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTransportDetailByIDBill @idBill", new object[] { idBill });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetTransportByIDBillAndState(int idBill, string state)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetTransportByIDBillAndState @idBill , @state", new object[] { idBill, state });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetOrderFullState()
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetOrderFullState");
            if (data.Rows.Count > 0)
                return data;
            return null;
        }

        public DataTable GetCustomerByIDBill(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetInfoCustomerByIDBill @idBill", new object[] { idBill });
            if (data.Rows.Count > 0)
                return data;
            return null;    
        }

        public DataTable GetInfoBillByIDBill(int idBill)
        {
            DataTable data = DataProvider.Instance.ExecuteQuery("USP_GetInfoBillByIDBill @idBill", new object[] { idBill });
            if (data.Rows.Count > 0)
                return data;
            return null;
        }
    }
}