using System.Data.SqlClient;
using System.Text;

namespace GMS.Models
{
    public class DBContext
    {
        private SqlConnection con;

        public DBContext()
        {
            con = new SqlConnection(GlobalData.ConnectionString);
        }


        #region MemberMaster

        public List<MemberMaster> GetMembersList()
        {
            List<MemberMaster> obj = new List<MemberMaster>();

            StringBuilder sb = new StringBuilder();

            sb.Append(" SELECT [ID] ,[FirstName] ,[LastName] ,[Email] ,[TelephoneNo] ,[FingerPrintID] FROM [dbo].[MemberMaster] ");

            string query = sb.ToString();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.Clear();
            con.Open();
            SqlDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                MemberMaster result = new MemberMaster();

                if (!(rdr["ID"] is DBNull))
                    result.ID = Convert.ToInt32(rdr["ID"]);
                if (!(rdr["FirstName"] is DBNull))
                    result.FirstName = Convert.ToString(rdr["FirstName"]);
                if (!(rdr["LastName"] is DBNull))
                    result.LastName = Convert.ToString(rdr["LastName"]);
                if (!(rdr["Email"] is DBNull))
                    result.Email = Convert.ToString(rdr["Email"]);
                if (!(rdr["TelephoneNo"] is DBNull))
                    result.TelephoneNo = Convert.ToString(rdr["TelephoneNo"]);

                obj.Add(result);
            }
            rdr.Close();
            con.Close();

            return obj;
        }

        #endregion MemberMaster
    }
}
