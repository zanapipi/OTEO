using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace OteoModel.Classes
{
    public class Emtba001001
    {

        public int ema001001Id { get; set; }
        public String ema001001RazaoSocial { get; set; }
        public String ema001001Fantasia { get; set; }
        public int ema001001Cnpj { get; set; }
        public String ema001001Situacao { get; set; }


        public List<Emtba001001> buscarLista()
        {
            
            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = "SELECT * " +
                                   "  FROM EMTBA001001 ";
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();
            var lEma001001 = new List<Emtba001001>();
            while (reader.Read())
            {

                lEma001001.Add(new Emtba001001
                {
                    ema001001Id = reader.GetInt("EMA001001_ID"),
                    ema001001RazaoSocial = reader.GetString("EMA001001_RAZAO_SOCIAL"),
                    ema001001Fantasia = reader.GetString("EMA001001_FANTASIA"),
                    ema001001Cnpj = reader.GetInt("EMA001001_CNPJ"),
                    ema001001Situacao = reader.GetString("EMA001001_SITUACAO")
                });

            }

            oComando.Connection.Close();

            return lEma001001;

        }


        public Emtba001001 buscar(int ema001001Id)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");



            oComando.CommandText = "SELECT *                             " +
                                   "  FROM EMTBA001001                   " +
                                   " WHERE EMA001001_ID = :EMA001001_ID  ";
            oComando.Parameters.Add("EMA001001_ID", ema001001Id);
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();

            reader.Read();

            var ema001001 = new Emtba001001()
            {
                ema001001Id = reader.GetInt("EMA001001_ID"),
                ema001001RazaoSocial = reader.GetString("EMA001001_RAZAO_SOCIAL"),
                ema001001Fantasia = reader.GetString("EMA001001_FANTASIA"),
                ema001001Cnpj = reader.GetInt("EMA001001_CNPJ"),
                ema001001Situacao = reader.GetString("EMA001001_SITUACAO")
            };

            oComando.Connection.Close();

            return ema001001;

        }
        

        public void inserir(Emtba001001 ema001001)
        {
            
            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");

            oComando.CommandText = " INSERT                          " +
                                   "   INTO EMTBA001001              " +
                                   " VALUES(:EMA001001_ID,           " +
                                   "        :EMA001001_RAZAO_SOCIAL, " +
                                   "        :EMA001001_FANTASIA,     " +
                                   "        :EMA001001_CNPJ,         " +
                                   "        :EMA001001_SITUACAO)     "; 
            oComando.Parameters.Add("EMA001001_ID", ema001001.ema001001Id);
            oComando.Parameters.Add("EMA001001_RAZAO_SOCIAL", ema001001.ema001001RazaoSocial);
            oComando.Parameters.Add("EMA001001_FANTASIA", ema001001.ema001001Fantasia);
            oComando.Parameters.Add("EMA001001_CNPJ", ema001001.ema001001Cnpj);
            oComando.Parameters.Add("EMA001001_SITUACAO", ema001001.ema001001Situacao);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();
            

        }
        

        public void deletar(int ema001001Id)
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = "DELETE EMTBA001001 " +
                                   " WHERE EMA001001_ID = :EMA001001_ID";
            oComando.Parameters.Add("EMA001001_ID", ema001001Id);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();

            oComando.ExecuteNonQuery();
            oComando.Connection.Close();

        }


        public void alterar(Emtba001001 ema001001)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = " UPDATE EMTBA001001                                      " +
                                   "    SET EMA001001_RAZAO_SOCIAL = :EMA001001_RAZAO_SOCIAL " +
                                   "        EMA001001_FANTASIA     = :EMA001001_FANTASIA     " +
                                   "        EMA001001_CNPJ         = :EMA001001_CNPJ         " +
                                   "        EMA001001_SITUACAO     = :EMA001001_SITUACAO     " + 
                                   "  WHERE EMA001001_ID = :EMA001001_ID ";
            oComando.Parameters.Add("EMA001001_ID", ema001001.ema001001Id);
            oComando.Parameters.Add("EMA001001_RAZAO_SOCIAL", ema001001.ema001001RazaoSocial);
            oComando.Parameters.Add("EMA001001_FANTASIA", ema001001.ema001001Fantasia);
            oComando.Parameters.Add("EMA001001_CNPJ", ema001001.ema001001Cnpj);
            oComando.Parameters.Add("EMA001001_SITUACAO", ema001001.ema001001Situacao);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();


        }
        

    }


}