using FirebirdSql.Data.FirebirdClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;

namespace TCC_GestaoFinanceira.Mapeador
{
    public class daoFireBird
    {
        private static readonly daoFireBird instanciaFireBird = new daoFireBird();

        public daoFireBird() { }

        public static daoFireBird getInstancia()
        {
            return instanciaFireBird;
        }

        public FbConnection getConexao()
        {
            string conn = ConfigurationManager.ConnectionStrings["FireBirdConnectionString"].ToString();
            return new FbConnection(conn);
        }

        public void acessoFBSingleton()
        {
            using (FbConnection conexaoFireBird = daoFireBird.getInstancia().getConexao())
            {
                try
                {
                    conexaoFireBird.Open();

                    string mSQL = "Select * from TBDADOS";

                    FbCommand cmd = new FbCommand(mSQL, conexaoFireBird);
                    FbDataAdapter da = new FbDataAdapter(cmd);

                    DataTable dtEmployee = new DataTable();
                    da.Fill(dtEmployee);
                }
                catch (FbException fbex)
                {
                    MessageBox.Show("Erro de acesso ao MySQL : " + fbex.Message, "Erro");
                }
                finally
                {
                    conexaoFireBird.Close();
                }
            }
        }
    }
}
}
