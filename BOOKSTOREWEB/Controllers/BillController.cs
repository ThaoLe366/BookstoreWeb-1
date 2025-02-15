﻿using BOOKSTOREWEB.DAO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BOOKSTOREWEB.Controllers
{
    [RoutePrefix("api/bill")]
    public class BillController : ApiController
    {
        [HttpGet]
        [Route("list-transport")]
        public DataTable Get()
        {
            return BillDAO.Instance.GetListTransport();
        }

        [HttpGet]
        [Route("list-transport/{state}")]
        public DataTable GetListTransportByState(string state)
        {
            return BillDAO.Instance.GetListTransportByState(state);
        }

        [HttpGet]
        [Route("list-transport-detail/{idBill}")]
        public DataTable GetTransportDetailByIDBill(int idBill)
        {
            return BillDAO.Instance.GetTransportDetailByIDBill(idBill);
        }

        [HttpGet]
        [Route("list-transport/{idBill}/{state}")]
        public DataTable GetTransportByIDBillAndState(int idBill, string state)
        {
            return BillDAO.Instance.GetTransportByIDBillAndState(idBill, state);
        }

        [HttpGet]
        [Route("list-order")]
        public DataTable GetOrderFullState()
        {
            return BillDAO.Instance.GetOrderFullState();
        }


        [HttpGet]
        [Route("list-order/{idBill}")]
        public DataTable GetOrderByIDBill(int idBill)
        {
            return BillDAO.Instance.GetOrderByIDBill(idBill);
        }

        [HttpGet]
        [Route("info-customer/{idBill}")]
        public DataTable GetInfoCustomerByIDBill(int idBill)
        {
            return BillDAO.Instance.GetCustomerByIDBill(idBill);
        }

        [HttpGet]
        [Route("info-bill/{idBill}")]
        public DataTable GetInfoBillByIDBill(int idBill)
        {
            return BillDAO.Instance.GetInfoBillByIDBill(idBill);
        }

        // POST: api/Bill
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Bill/5
        [HttpPut]
        [Route("update-transport/{idBill}/{state}")]
        public bool Put(int idBill, string state)
        {
            return BillDAO.Instance.UpdateOrderStateByIdBill(idBill, state);
        }

        // DELETE: api/Bill/5
        public void Delete(int id)
        {
        }
    }
}
