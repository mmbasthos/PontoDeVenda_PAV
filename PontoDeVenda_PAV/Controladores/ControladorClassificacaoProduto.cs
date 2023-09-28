using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PontoDeVenda_PAV.Persistencia;


namespace PontoDeVenda_PAV.Controladores
{
    public class ControladorClassificacaoProduto : ControladorCadastro
    {
        protected override string criarComandoSelecao()
        {
            return "SELECT * FROM classe_produto WHERE id_classe = @id_classe";
        }

        protected override string criarComandoInclusao()
        {
            return "INSERT INTO classe_produto VALUES (@id_classe, @nome_classe)";
        }
        protected override string criarComandoAtualizacao()
        {
            return "UPDATE classe_produto" +
                " SET nome_classe = @nome_classe" +
                " WHERE id_classe = @id_classe";
        }
        protected override string criarComandoExclusao()
        {
            return "DELETE FROM classe_produto WHERE id_classe = @id_classe";
        }
        protected override void criarParametros(MySqlCommand comando)
        {
            comando.Parameters.Add(ClassificacaoProduto.ATRIBUTO_ID_CLASSE, MySqlDbType.Int32);
            comando.Parameters.Add(ClassificacaoProduto.ATRIBUTO_NOME_CLASSE, MySqlDbType.VarChar);
        }

        protected override void criarParametrosChavePrimaria(MySqlCommand comando)
        {
            comando.Parameters.Add(ClassificacaoProduto.ATRIBUTO_ID_CLASSE, MySqlDbType.Int32);
        }




    }
}
