using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;

namespace OteoModel.Classes
{
    public class Tutba001001
    {

        public int tua001001Id { get; set; }
        public String tua001001TipoUsuario { get; set; }
        public String tua001001Situacao { get; set; }


        public List<Tutba001001> buscarLista()
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = "SELECT * " +
                                   "  FROM TUTBA001001 ";
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();
            var lTua001001 = new List<Tutba001001>();
            while (reader.Read())
            {

                lTua001001.Add(new Tutba001001
                {
                    tua001001Id = reader.GetInt("TUA001001_ID"),
                    tua001001TipoUsuario = reader.GetString("TUA001001_TIPO_USUARIO"),
                    tua001001Situacao = reader.GetString("TUA001001_SITUACAO")
                });

            }

            oComando.Connection.Close();

            return lTua001001;

        }


        public Tutba001001 buscar(int tua001001Id)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");



            oComando.CommandText = "SELECT *                             " +
                                   "  FROM TUTBA001001                   " +
                                   " WHERE TUA001001_ID = :TUA001001_ID  ";
            oComando.Parameters.Add("TUA001001_ID", tua001001Id);
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();

            reader.Read();

            var tua001001 = new Tutba001001()
            {
                tua001001Id = reader.GetInt("TUA001001_ID"),
                tua001001TipoUsuario = reader.GetString("TUA001001_TIPO_USUARIO"),
                tua001001Situacao = reader.GetString("TUA001001_SITUACAO")
            };

            oComando.Connection.Close();

            return tua001001;

        }


        public void inserir(Tutba001001 tua001001)
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");

            oComando.CommandText = " INSERT                          " +
                                   "   INTO TUTBA001001              " +
                                   " VALUES(:TUA001001_ID,           " +
                                   "        :TUA001001_TIPO_USUARIO, " +
                                   "        :TUA001001_SITUACAO)     ";
            oComando.Parameters.Add("TUA001001_ID", tua001001.tua001001Id);
            oComando.Parameters.Add("TUA001001_TIPO_USUARIO", tua001001.tua001001TipoUsuario);
            oComando.Parameters.Add("TUA001001_SITUACAO", tua001001.tua001001Situacao);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();


        }


        public void deletar(int tua001001Id)
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = "DELETE TUTBA001001 " +
                                   " WHERE TUA001001_ID = :TUA001001_ID";
            oComando.Parameters.Add("TUA001001_ID", tua001001Id);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();

            oComando.ExecuteNonQuery();
            oComando.Connection.Close();

        }


        public void alterar(Tutba001001 tua001001)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = " UPDATE TUTBA001001                                       " +
                                   "    SET TUA001001_TIPO_USUARIO = :FTUA001001_TIPO_USUARIO " +
                                   "        TUA001001_SITUACAO     = :TUA001001_SITUACAO      " +
                                   "  WHERE TUA001001_ID = :TUA001001_ID ";
            oComando.Parameters.Add("TUA001001_ID", tua001001.tua001001Id);
            oComando.Parameters.Add("TUA001001_TIPO_USUARIO", tua001001.tua001001TipoUsuario);
            oComando.Parameters.Add("TUA001001_SITUACAO", tua001001.tua001001Situacao);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();


        }


    }
}