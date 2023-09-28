using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class ClassificacaoProduto : Entidade
    {
        public const string ATRIBUTO_ID_CLASSE = "id_classe";
        public const string ATRIBUTO_NOME_CLASSE = "nome_classe";


        public int id_classe { get; set; }
        public string nome_classe { get; set; }


        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CLASSE].Value = id_classe;
            comando.Parameters[ATRIBUTO_NOME_CLASSE].Value = nome_classe;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CLASSE].Value = id_classe;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_classe = int.Parse(leitorDados[ATRIBUTO_ID_CLASSE].ToString());
            nome_classe = leitorDados[ATRIBUTO_NOME_CLASSE].ToString();
        }
    }
}
