using Models;
using System;
using System.Data.OleDb;

namespace Repository
{
    public class UserRepository
    {
        private OleDbConnection _dbContext;

        //public UserRepository(OleDbConnection dbContext)
        public UserRepository()
        {
            _dbContext = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Memory.mdb;"); ;
        }

        public void UpdateDB(User user)
        {
            try
            {
                _dbContext.Open();
                var sql = new OleDbCommand("UPDATE Users SET Tries=@tries,TimeInSec=@time WHERE Username=@name;", _dbContext);
                sql.Parameters.AddWithValue("@tries", user.Tries);
                sql.Parameters.AddWithValue("@time", user.Time);
                sql.Parameters.AddWithValue("@name", user.UserName);

                sql.Connection = _dbContext;
                sql.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                //throw OleDbException;
            }
            finally
            {
                _dbContext.Close();
            }

        }
    }
}
