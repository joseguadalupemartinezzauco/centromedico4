using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace bibliotecaCBD
{
    public class operacion
    {
        public bool insertcit(int idcita, string citfecha, string cithora, string citPaciente, string citMedico, string citConsultorio, string citestado, string citobservaciones) {
            conexion cn = new conexion();
            try
            {
                string sql = "insert into citas values ( 0,'"+citfecha+ "','" + cithora + "','" + citPaciente + "','" + citMedico + "','" + citConsultorio + "','" + citestado + "','" + citobservaciones + "')";
                SqlCommand cmd = new SqlCommand(sql, cn.getConnection());
                int n = cmd.ExecuteNonQuery();
                return n > 0;
            }
            catch (Exception)
            {
                return false;
            }


        }





    }
}
