using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace OteoModel.Classes
{
    public class Futba001001
    {

        public int fua001001Id { get; set; }
        public String fua001001Funcao { get; set; }
        public String fua001001Situacao { get; set; }


        public List<Futba001001> buscarLista()
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = "SELECT * " +
                                   "  FROM FUTBA001001 ";
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();
            var lFua001001 = new List<Futba001001>();
            while (reader.Read())
            {

                lFua001001.Add(new Futba001001
                {
                    fua001001Id = reader.GetInt("FUA001001_ID"),
                    fua001001Funcao = reader.GetString("FUA001001_FUNCAO"),
                    fua001001Situacao = reader.GetString("FUA001001_SITUACAO")
                });

            }

            oComando.Connection.Close();

            return lFua001001;

        }


        public Futba001001 buscar(int fua001001Id)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");



            oComando.CommandText = "SELECT *                             " +
                                   "  FROM FUTBA001001                   " +
                                   " WHERE FUA001001_ID = :FUA001001_ID  ";
            oComando.Parameters.Add("FUA001001_ID", fua001001Id);
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();

            reader.Read();

            var fua001001 = new Futba001001()
            {
                fua001001Id = reader.GetInt("FUA001001_ID"),
                fua001001Funcao = reader.GetString("FUA001001_FUNCAO"),
                fua001001Situacao = reader.GetString("FUA001001_SITUACAO")
            };

            oComando.Connection.Close();

            return fua001001;

        }


        public void inserir(Futba001001 fua001001)
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");

            oComando.CommandText = " INSERT                          " +
                                   "   INTO FUTBA001001              " +
                                   " VALUES(:FUA001001_ID,           " +
                                   "        :FUA001001_FUNCAO,       " +
                                   "        :FUA001001_SITUACAO)     ";
            oComando.Parameters.Add("FUA001001_ID", fua001001.fua001001Id);
            oComando.Parameters.Add("FUA001001_FUNCAO", fua001001.fua001001Funcao);
            oComando.Parameters.Add("FUA001001_SITUACAO", fua001001.fua001001Situacao);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();


        }


        public void deletar(int fua001001Id)
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = "DELETE FUTBA001001 " +
                                   " WHERE FUA001001_ID = :FUA001001_ID";
            oComando.Parameters.Add("FUA001001_ID", fua001001Id);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();

            oComando.ExecuteNonQuery();
            oComando.Connection.Close();

        }


        public void alterar(Futba001001 fua001001)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = " UPDATE FUTBA001001                                      " +
                                   "    SET FUA001001_FUNCAO = :FFUA001001_FUNCAO            " +
                                   "        FUA001001_SITUACAO     = :FUA001001_SITUACAO     " +
                                   "  WHERE FUA001001_ID = :FUA001001_ID ";
            oComando.Parameters.Add("FUA001001_ID", fua001001.fua001001Id);
            oComando.Parameters.Add("FUA001001_FUNCAO", fua001001.fua001001Funcao);
            oComando.Parameters.Add("FUA001001_SITUACAO", fua001001.fua001001Situacao);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();


        }


    }
}