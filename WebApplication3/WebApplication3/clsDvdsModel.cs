using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication3
{
    public class clsDvdsModel
    {

        private SqlConnection oConn;
        private void openConn()
        {
            String strConn;
            strConn = "Data Source=.\\SQLEXPRESS; initial catalog = DbSisDist; user id = userSisDist; Password = 'user@01'";
        try
            {
                oConn = new SqlConnection(strConn);
                oConn.Open();
            }
            catch { }
        }
        private void closeConn()
        {
            oConn.Close();
            oConn = null;
        }
        public DataSet getDvdsDataSet(String strSQL, String strName)
        {
            SqlDataAdapter da;
            DataSet ds;
            try
            {
                openConn();
                da = new SqlDataAdapter(strSQL, oConn);
                ds = new DataSet();
                da.Fill(ds, strName);
                return ds;
            }
            finally
            {
                closeConn();
            }
        }

    }
}