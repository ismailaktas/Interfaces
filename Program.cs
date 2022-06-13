using System;
namespace InterfaceSample
{
    public interface IDatabaseLogin
    {
        public void Db_Login(string connectionString);
        public void Db_Open();
        public void Db_Close();
    }

    public interface IDatabaseProcess : IDatabaseLogin
    {
        public void Db_Insert();
        public void Db_Update();
        public void Db_Delete();
        public void Db_Select();
    }

    public class MSSQL_Operations : IDatabaseProcess
    {
        //MSSQL baglanti islemleri
        public void Db_Login(string connectionString) { }
        public void Db_Open() { }
        public void Db_Close() { }
        //MSSQL database kayit islemleri
        public void Db_Insert() {
            // Database e kaydet
        }
        public void Db_Update() { }
        public void Db_Delete() { }
        public void Db_Select() { }
    }

    public class ORACLE_Operations : IDatabaseProcess
    {
        //ORACLE baglanti islemleri
        public void Db_Login(string connectionString) { }
        public void Db_Open() { }
        public void Db_Close() { }
        //ORACLE database kayit islemleri
        public void Db_Insert() { }
        public void Db_Update() { }
        public void Db_Delete() { }
        public void Db_Select() { }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //MSSQL
            MSSQL_Operations objSQL = new MSSQL_Operations();
            objSQL.Db_Login("Mssql connectionstring cumlesi");
            objSQL.Db_Open();
            objSQL.Db_Insert();
            objSQL.Db_Close();

            //ORACLE 
            ORACLE_Operations objOracle = new ORACLE_Operations();
            objOracle.Db_Login("Oracle connectionstring cumlesi");
            objOracle.Db_Open();
            objOracle.Db_Insert();
            objOracle.Db_Close();
        }
    }
}
