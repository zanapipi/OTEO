using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Data.Common;


namespace OteoModel.Classes
{
    public class Ustba001001
    {

        public int usa001001Id { get; set; }
        public String usa001001Usuario { get; set; }
        public String usa001001Senha { get; set; }
        public String usa001001Nome { get; set; }
        public String usa001001Sobrenome { get; set; }
        public String usa001001Email { get; set; }
        public String usa001001Situacao { get; set; }
        public Tutba001001 tutba001001 { get; set; }
        public Emtba001001 emtba001001 { get; set; }
        public Futba001001 futba001001 { get; set; }


        public List<Ustba001001> buscarLista()
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = " SELECT *           " +
                                   "   FROM USTBA001001 ";
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();
            var lUsa001001 = new List<Ustba001001>();
            while (reader.Read())
            {

                lUsa001001.Add(new Ustba001001
                {
                    usa001001Id = reader.GetInt("USA001001_ID"),
                    usa001001Usuario = reader.GetString("USA001001_USUARIO"),
                    usa001001Senha = reader.GetString("USA001001_SENHA"),
                    usa001001Nome = reader.GetString("USA001001_NOME"),
                    usa001001Sobrenome = reader.GetString("USA001001_SOBRENOME"),
                    usa001001Email = reader.GetString("USA001001_EMAIL"),
                    usa001001Situacao = reader.GetString("USA001001_SITUACAO"),
                    tutba001001 = new Tutba001001().buscar(reader.GetInt("USA001001_TUA001001_ID")),
                    emtba001001 = new Emtba001001().buscar(reader.GetInt("USA001001_EMA001001_ID")),
                    futba001001 = new Futba001001().buscar(reader.GetInt("USA001001_FUA001001_ID"))

                });

            }

            oComando.Connection.Close();

            return lUsa001001;

        }


        public Ustba001001 buscar(int usa001001Id)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");



            oComando.CommandText = "SELECT *                             " +
                                   "  FROM USTBA001001                   " +
                                   " WHERE USA001001_ID = :USA001001_ID  ";
            oComando.Parameters.Add("USA001001_ID", usa001001Id);
            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();


            DbDataReader reader = oComando.ExecuteReader();

            reader.Read();

            var usa001001 = new Ustba001001()
            {
                usa001001Id = reader.GetInt("USA001001_ID"),
                usa001001Usuario = reader.GetString("USA001001_USUARIO"),
                usa001001Senha = reader.GetString("USA001001_SENHA"),
                usa001001Nome = reader.GetString("USA001001_NOME"),
                usa001001Sobrenome = reader.GetString("USA001001_SOBRENOME"),
                usa001001Email = reader.GetString("USA001001_EMAIL"),
                usa001001Situacao = reader.GetString("USA001001_SITUACAO"),
                tutba001001 = new Tutba001001().buscar(reader.GetInt("USA001001_TUA001001_ID")),
                emtba001001 = new Emtba001001().buscar(reader.GetInt("USA001001_EMA001001_ID")),
                futba001001 = new Futba001001().buscar(reader.GetInt("USA001001_FUA001001_ID"))
            };

            oComando.Connection.Close();

            return usa001001;

        }


        public void inserir(Ustba001001 usa001001)
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");

            oComando.CommandText = " INSERT                 " +
                                   "   INTO USTBA001001     " +
                                   " VALUES(:USA001001_ID,            " +
                                   "        :USA001001_USUARIO,       " +
                                   "        :USA001001_SENHA,         " +
                                   "        :USA001001_NOME,          " +
                                   "        :USA001001_SOBRENOME,     " +
                                   "        :USA001001_EMAIL,         " +
                                   "        :USA001001_SITUACAO,      " +
                                   "        :USA001001_TUA001001_ID,  " +
                                   "        :USA001001_EMA001001_ID,  " +
                                   "        :USA001001_FUA001001_ID)  ";

            oComando.Parameters.Add("USA001001_ID", usa001001Id);
            oComando.Parameters.Add("USA001001_USUARIO", usa001001Usuario);
            oComando.Parameters.Add("USA001001_SENHA", usa001001Senha);
            oComando.Parameters.Add("USA001001_NOME", usa001001Nome);
            oComando.Parameters.Add("USA001001_SOBRENOME", usa001001Sobrenome);
            oComando.Parameters.Add("USA001001_EMAIL", usa001001Email);
            oComando.Parameters.Add("USA001001_SITUACAO", usa001001Situacao);
            oComando.Parameters.Add("USA001001_TUA001001_ID", usa001001.tutba001001.tua001001Id);
            oComando.Parameters.Add("USA001001_EMA001001_ID", usa001001.emtba001001.ema001001Id);
            oComando.Parameters.Add("USA001001_FUA001001_ID", usa001001.futba001001.fua001001Id);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();


        }


        public void deletar(int usa001001Id)
        {

            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = "DELETE USTBA001001 " +
                                   " WHERE USA001001_ID = :USA001001_ID";
            oComando.Parameters.Add("USA001001_ID", usa001001Id);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();

            oComando.ExecuteNonQuery();
            oComando.Connection.Close();

        }


        public void alterar(Ustba001001 usa001001)
        {


            OracleCommand oComando = new OracleCommand();

            oComando.Connection = new OracleConnection("Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = DESKTOP-VVJBQE3)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = XE)));User Id=OTEO;Password=OTEO");


            oComando.CommandText = " UPDATE USTBA001001                                      " +
                                   "    SET USA001001_USUARIO      = :USA001001_USUARIO      " +
                                   "        USA001001_SENHA        = :USA001001_SENHA        " +
                                   "        USA001001_NOME         = :USA001001_NOME         " +
                                   "        USA001001_SOBRENOME    = :USA001001_SOBRENOME    " +
                                   "        USA001001_EMAIL        = :USA001001_EMAIL        " +
                                   "        USA001001_SITUACAO     = :USA001001_SITUACAO     " +
                                   "        USA001001_TUA001001_ID = :USA001001_TUA001001_ID " +
                                   "        USA001001_EMA001001_ID = :USA001001_EMA001001_ID " +
                                   "        USA001001_FUA001001_ID = :USA001001_FUA001001_ID " +
                                   "  WHERE USA001001_ID = :USA001001_ID ";
            oComando.Parameters.Add("USA001001_ID", usa001001Id);
            oComando.Parameters.Add("USA001001_USUARIO", usa001001Usuario);
            oComando.Parameters.Add("USA001001_SENHA", usa001001Senha);
            oComando.Parameters.Add("USA001001_NOME", usa001001Nome);
            oComando.Parameters.Add("USA001001_SOBRENOME", usa001001Sobrenome);
            oComando.Parameters.Add("USA001001_EMAIL", usa001001Email);
            oComando.Parameters.Add("USA001001_SITUACAO", usa001001Situacao);
            oComando.Parameters.Add("USA001001_TUA001001_ID", usa001001.tutba001001.tua001001Id);
            oComando.Parameters.Add("USA001001_EMA001001_ID", usa001001.emtba001001.ema001001Id);
            oComando.Parameters.Add("USA001001_FUA001001_ID", usa001001.futba001001.fua001001Id);

            oComando.CommandType = System.Data.CommandType.Text;

            oComando.Connection.Open();
            oComando.ExecuteNonQuery();
            oComando.Connection.Close();


        }


    }
}