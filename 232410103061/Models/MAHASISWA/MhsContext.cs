using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace _232410103061.Models.MAHASISWA
{
    public class MhsContext
    {
        #region Properties
        Models.MAHASISWA.MhsContext mhsContext;
        public List<Mhs> ListMahasiswa = new List<Mhs>();
        #endregion

        public bool Insert(Mhs mhs)
        {
            bool isSucces = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=zakhaaditya;Database=UTS_PBO;";
            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {

                string sql = "INSERT INTO mahasiswa(nama, nim, email, nohp, pass)VALUES(:nama, :nim, :email, :nohp, :pass);";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.Add(new NpgsqlParameter(":nama", mhs.nama));
                    cmd.Parameters.Add(new NpgsqlParameter(":nim", mhs.nim));
                    cmd.Parameters.Add(new NpgsqlParameter(":email", mhs.email));
                    cmd.Parameters.Add(new NpgsqlParameter(":nohp", mhs.no_HP));
                    cmd.Parameters.Add(new NpgsqlParameter(":pass", mhs.password));

                    cmd.CommandType = System.Data.CommandType.Text;
                    int jmlDataBaru = cmd.ExecuteNonQuery();
                    if (jmlDataBaru > 0)
                    {
                        isSucces = true;
                        this.ListMahasiswa.Add(mhs);
                    }
                }
            }
            return isSucces;
        }

        public bool Read()
        {
            bool isSuccess = false;
            string conStr = "Server=localhost;Port=5432;User Id=postgres;Password=zakhaaditya;Database=UTS_PBO;";

            using (NpgsqlConnection conn = new NpgsqlConnection(conStr))
            {
                string sql = @"SELECT nama, nim, email, nohp, pass FROM mahasiswa;";

                conn.Open();
                using (NpgsqlCommand cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.CommandText = sql;
                    NpgsqlDataReader reader = cmd.ExecuteReader();

                    ListMahasiswa.Clear();
                    while (reader.Read())
                    {
                        Mhs newRole = new Mhs();

                        newRole.nama = (string)reader["nama"];
                        newRole.nim = (string)reader["nim"];
                        newRole.email = (string)reader["email"];
                        newRole.no_HP = (int)reader["nohp"];
                        newRole.password = (string)reader["pass"];

                        ListMahasiswa.Add(newRole);
                    }

                }
            }
            return isSuccess;
        }
    }


}
