using Microsoft.Data.SqlClient;
using System.Data;

namespace MyCourse.Models.Services.Infrastructure
{
    public class SqlDatabaseAccessor : IDatabaseAccessor
    {
        public DataSet Query(string query)
        {
            // https://connectionstrings.com
            using (var conn = new SqlConnection("Server=DELLMICHELE\\SQLEXPRESS;Database=MyCourse;Trusted_Connection=True;Encrypt=False"))
            { 
                conn.Open();
                using (var cmd = new SqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        var dataSet = new DataSet();
                        do
                        {
                            var dataTable = new DataTable();
                            dataSet.Tables.Add(dataTable);
                            dataTable.Load(reader);
                        } while (!reader.IsClosed);

                        return dataSet;
                    }
                }
            }
        }
    }
}
