using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using PontoDeVenda_PAV.Persistencia;

namespace PontoDeVenda_PAV.Controladores
{
    public abstract class ControladorCadastro
    {

        private MySqlCommand comandoInclusao;
        private MySqlCommand comandoAtualizacao;
        private MySqlCommand comandoExclusao;
        public MySqlCommand comandoSelecao;

        protected abstract string criarComandoSelecao();
        protected abstract string criarComandoInclusao();
        protected abstract string criarComandoAtualizacao();
        protected abstract string criarComandoExclusao();

        protected abstract void criarParametros(MySqlCommand comando);
        protected abstract void criarParametrosChavePrimaria(MySqlCommand comandoExclusao);

        protected virtual void criarParametrosInclusao(MySqlCommand comandoInclusao)
        {
            criarParametros(comandoInclusao);
        }
        
        protected virtual void criarParametrosAtualizacao(MySqlCommand comandoAtualizacao)
        {
            criarParametros(comandoAtualizacao);
        }

        public ControladorCadastro()
        {
            comandoInclusao = new MySqlCommand(criarComandoInclusao(), BancodeDados.obterInstancia().obterConexao());

            comandoAtualizacao = new MySqlCommand(criarComandoAtualizacao(), BancodeDados.obterInstancia().obterConexao());

            comandoExclusao = new MySqlCommand(criarComandoExclusao(), BancodeDados.obterInstancia().obterConexao());

            comandoSelecao = new MySqlCommand(criarComandoSelecao(), BancodeDados.obterInstancia().obterConexao());

            criarParametrosInclusao(comandoInclusao);
            criarParametrosAtualizacao(comandoAtualizacao);
            criarParametrosChavePrimaria(comandoExclusao);
            criarParametrosChavePrimaria(comandoSelecao);
        }

        public void selecionar (Entidade entidade)
        {
            BancodeDados.obterInstancia().iniciarTransacao();

            try
            {
                entidade.transferirDadosIdentificador(comandoSelecao);
                MySqlDataReader leitorDados = comandoSelecao.ExecuteReader();
                while (leitorDados.Read())
                {
                    entidade.lerDados(leitorDados);
                }
                leitorDados.Close();
                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void incluir(Entidade entidade)
        {
            BancodeDados.obterInstancia().iniciarTransacao();
            try
            {
                entidade.transferirDados(comandoInclusao);
                comandoInclusao.ExecuteNonQuery();
                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);

            }
        }

        public void atualizar(Entidade entidade)
        {
            BancodeDados.obterInstancia().iniciarTransacao();
            try
            {
                entidade.transferirDados(comandoAtualizacao);
                comandoAtualizacao.ExecuteNonQuery();
                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
            {
                BancodeDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

        public void excluir(Entidade entidade)
        {
            BancodeDados.obterInstancia().iniciarTransacao();
            try
            {
                entidade.transferirDadosIdentificador(comandoExclusao);
                comandoExclusao.ExecuteNonQuery();
                BancodeDados.obterInstancia().confirmarTransacao();
            }
            catch (Exception ex)
           {
                BancodeDados.obterInstancia().cancelarTransacao();
                throw new Exception(ex.Message);
            }
        }

    }
}
