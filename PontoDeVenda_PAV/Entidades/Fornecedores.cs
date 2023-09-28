using MySql.Data.MySqlClient;
using PontoDeVenda_PAV.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PontoDeVenda_PAV.Entidades
{
    public class Fornecedor : Entidade
    {
        public const string ATRIBUTO_ID_FORNECEDOR = "id_fornecedor";
        public const string ATRIBUTO_NOME_FORNECEDOR = "nome_fornecedor";
        public const string ATRIBUTO_CPF_CNPJ_FORNECEDOR = "cpf_cnpj_fornecedor";
        public const string ATRIBUTO_LOGRADOURO_FORNECEDOR = "logradouro_fornecedor";
        public const string ATRIBUTO_NUM_LOGRADOURO_FORNECEDOR = "numero_logradouro_fornecedor";
        public const string ATRIBUTO_COMPLEMENTO_FORNECEDOR = "complemento_fornecedor";
        public const string ATRIBUTO_BAIRRO_FORNECEDOR = "bairro_fornecedor";
        public const string ATRIBUTO_CIDADE_FORNECEDOR = "cidade_fornecedor";
        public const string ATRIBUTO_ESTADO_FORNECEDOR = "estado_fornecedor";
        public const string ATRIBUTO_CEP_FORNECEDOR = "cep_fornecedor";
        public const string ATRIBUTO_TELEFONE_FORNECEDOR = "telefone_fornecedor";
        public const string ATRIBUTO_EMAIL_FORNECEDOR = "email_fornecedor";

        public int id_fornecedor { get; set; }
        public string nome_fornecedor { get; set; }
        public string cpf_cnpj_fornecedor { get; set; }
        public string logradouro_fornecedor { get; set; }
        public string numero_logradouro_fornecedor { get; set; }
        public string complemento_fornecedor { get; set; }
        public string bairro_fornecedor { get; set; }
        public string cidade_fornecedor { get; set; }
        public string estado_fornecedor { get; set; }
        public string cep_fornecedor { get; set; }
        public string telefone_fornecedor { get; set; }
        public string email_fornecedor { get; set; }

        public override void transferirDados(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = id_fornecedor;
            comando.Parameters[ATRIBUTO_NOME_FORNECEDOR].Value = nome_fornecedor;
            comando.Parameters[ATRIBUTO_CPF_CNPJ_FORNECEDOR].Value = cpf_cnpj_fornecedor;
            comando.Parameters[ATRIBUTO_LOGRADOURO_FORNECEDOR].Value = logradouro_fornecedor;
            comando.Parameters[ATRIBUTO_NUM_LOGRADOURO_FORNECEDOR].Value = numero_logradouro_fornecedor;
            comando.Parameters[ATRIBUTO_COMPLEMENTO_FORNECEDOR].Value = complemento_fornecedor;
            comando.Parameters[ATRIBUTO_BAIRRO_FORNECEDOR].Value = bairro_fornecedor;
            comando.Parameters[ATRIBUTO_CIDADE_FORNECEDOR].Value = cidade_fornecedor;
            comando.Parameters[ATRIBUTO_ESTADO_FORNECEDOR].Value = estado_fornecedor;
            comando.Parameters[ATRIBUTO_CEP_FORNECEDOR].Value = cep_fornecedor;
            comando.Parameters[ATRIBUTO_TELEFONE_FORNECEDOR].Value = telefone_fornecedor;
            comando.Parameters[ATRIBUTO_EMAIL_FORNECEDOR].Value = email_fornecedor;
        }
        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_FORNECEDOR].Value = id_fornecedor;
        }
        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_fornecedor = int.Parse(leitorDados[ATRIBUTO_ID_FORNECEDOR].ToString());
            nome_fornecedor = leitorDados[ATRIBUTO_NOME_FORNECEDOR].ToString();
            cpf_cnpj_fornecedor = leitorDados[ATRIBUTO_CPF_CNPJ_FORNECEDOR].ToString();
            logradouro_fornecedor = leitorDados[ATRIBUTO_LOGRADOURO_FORNECEDOR].ToString();
            numero_logradouro_fornecedor = leitorDados[ATRIBUTO_NUM_LOGRADOURO_FORNECEDOR].ToString();
            complemento_fornecedor = leitorDados[ATRIBUTO_COMPLEMENTO_FORNECEDOR].ToString();
            bairro_fornecedor = leitorDados[ATRIBUTO_BAIRRO_FORNECEDOR].ToString();
            cidade_fornecedor = leitorDados[ATRIBUTO_CIDADE_FORNECEDOR].ToString();
            estado_fornecedor = leitorDados[ATRIBUTO_ESTADO_FORNECEDOR].ToString();
            cep_fornecedor = leitorDados[ATRIBUTO_CEP_FORNECEDOR].ToString();
            telefone_fornecedor = leitorDados[ATRIBUTO_TELEFONE_FORNECEDOR].ToString();
            email_fornecedor = leitorDados[ATRIBUTO_EMAIL_FORNECEDOR].ToString();
        }

    }
}