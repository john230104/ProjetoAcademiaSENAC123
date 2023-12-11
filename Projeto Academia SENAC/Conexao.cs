using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Projeto_Academia_SENAC
{
	public static class Conexao
	{
		public static SqlConnection conn;
		public static string conexao =
			@"Data Source=SJC0562942W10-1;
				Initial Catalog = Goldfit;
				User Id = sa;
				Password = Senac123";
		public static void Conectar()
		{
			conn = new SqlConnection(conexao);
			conn.Open();
		}

		public static void Fechar()
		{
			conn.Close();
		}
	}
}
