using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fakturacefiller
{
    public class SqlRepository
    {
        private string connString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Fakturace;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public List<Faktura> GetFaktura()
        {
            List<Faktura> faktury = new List<Faktura>();
            try
            {
                using (SqlConnection sqlConnection = new SqlConnection(connString))
                {
                    sqlConnection.Open();
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.Connection = sqlConnection;
                        sqlCommand.CommandText = "select * from Fakturace";
                        using (SqlDataReader sqlDataReader = sqlCommand.ExecuteReader())
                        {
                            while (sqlDataReader.Read())
                            {
                                var faktura = new Faktura()
                                {
                                    id = Convert.ToInt32(sqlDataReader["id"]),
                                    datum = Convert.ToDateTime(sqlDataReader["datum"]),
                                    cislo = Convert.ToInt32(sqlDataReader["cislo"]),
                                    odberatel = Convert.ToString(sqlDataReader["Odberatel"]),
                                    nazev = Convert.ToString(sqlDataReader["nazev"]),
                                    pocet = Convert.ToInt32(sqlDataReader["pocet"]),
                                    cena1 = Convert.ToSingle(sqlDataReader["cena1"]),
                                };
                                faktury.Add(faktura);
                            }
                        }
                    }
                    sqlConnection.Close();
                }
            }
            catch (Exception ex)
            {
                  throw new Exception($"Some error happend (Exception: {ex.Message})");
            }

            return faktury;
        }
    }

}

