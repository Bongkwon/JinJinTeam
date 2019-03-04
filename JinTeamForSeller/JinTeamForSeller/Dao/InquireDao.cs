using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JinTeamForSeller.Vo;

namespace JinTeamForSeller.Dao
{
    class InquireDao
    {
        DBConnection conn = new DBConnection();

        public List<InquireVO> SelectInquireForSeller(int sellerNo)
        {
            List<object> lstobj = new List<object>();
            List<InquireVO> lstinq = new List<InquireVO>();

            string query = "SelectInquireForSeller";
            SqlParameter[] sqlp = { new SqlParameter("sellerNo", sellerNo) };
            try
            {
                lstobj = conn.SendReadQuery(query, sqlp);
            }
            catch
            {
                throw;
            }
            foreach (var item in lstobj)
            {
                lstinq.Add((InquireVO)item);
            }
            return lstinq;
        }

        public bool UpdateInquire_Seller(int inquire_no, string re_body)
        {
            string query = "UpdateInquire_Seller";
            SqlParameter[] sqlp = { new SqlParameter("inquire_no", inquire_no), new SqlParameter("re_body", re_body) };
            try
            {
                return conn.SendExqueteQuery(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<InquireVO> SelectInquireAdminForSeller(int Inquire_Id, string cus_or_sell)
        {
            List<object> lstobj = new List<object>();
            List<InquireVO> lstinq = new List<InquireVO>();

            string query = "SelectInquireAdminForSeller";
            SqlParameter[] sqlp = { new SqlParameter("Inquire_Id", Inquire_Id), new SqlParameter("cus_or_sell", cus_or_sell) };
            try
            {
                lstobj = conn.SendReadQuery(query, sqlp);
            }
            catch
            {
                throw;
            }
            foreach (var item in lstobj)
            {
                lstinq.Add((InquireVO)item);
            }
            return lstinq;
        }

        public bool InsertInquire_Seller(InquireVO iVO)
        {
            string query = "InsertInquire_Seller";
            SqlParameter[] sqlp = { new SqlParameter("Inquire_type",iVO.Inquire_type), new SqlParameter("Inquire_Id",iVO.InquireID),
                new SqlParameter("Inquire_title",iVO.InquireTitle), new SqlParameter("Inquire_body",iVO.InquireBody),
                new SqlParameter("Inquire_image",iVO.InquireImage)};
            try
            {
                return conn.SendExqueteQuery(query, sqlp);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
