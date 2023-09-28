using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace PontoDeVenda_PAV.Entidades
{
    public class Cliente : Entidade
    {
        public const string ATRIBUTO_ID_CLIENTE                    = "id_cliente";
        public const string ATRIBUTO_NOME_CLIENTE                   = "nome_cliente";
        public const string ATRIBUTO_CPF_CNPJ_CLIENTE               = "cpf_cnpj_cliente";
        public const string ATRIBUTO_LOGRADOURO_CLIENTE             = "logradouro_cliente";
        public const string ATRIBUTO_NUM_LOGRADOURO_CLIENTE         = "numero_logradouro_cliente";
        public const string ATRIBUTO_COMPLEMENTO_LOGRADOURO_CLIENTE = "complemento_cliente";
        public const string ATRIBUTO_BAIRRO_CLIENTE                 = "bairro_cliente";
        public const string ATRIBUTO_CIDADE_CLIENTE                 = "cidade_cliente";
        public const string ATRIBUTO_ESTADO_CLIENTE                 = "estado_cliente";
        public const string ATRIBUTO_CEP_CLIENTE                    = "cep_cliente";
        public const string ATRIBUTO_TELEFONE_CLIENTE               = "telefone_cliente";
        public const string ATRIBUTO_EMAIL_CLIENTE                  = "email_cliente";

        public int id_cliente { get; set; }
        public string nome_cliente { get; set; }
        public string cpf_cnpj_cliente { get; set; }
        public string logradouro_cliente { get; set; }
        public string numero_logradouro_cliente { get; set; }
        public string complemento_cliente { get; set; }
        public string bairro_cliente { get; set; }
        public string cidade_cliente { get; set; }
        public string estado_cliente  { get; set; }
        public string cep_cliente { get; set; }
        public string telefone_cliente { get; set; }
        public string email_cliente { get; set; }

        public override void transferirDados(MySqlCommand comando)
        { 
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = id_cliente;
            comando.Parameters[ATRIBUTO_NOME_CLIENTE].Value = nome_cliente;
            comando.Parameters[ATRIBUTO_CPF_CNPJ_CLIENTE].Value = cpf_cnpj_cliente;
            comando.Parameters[ATRIBUTO_LOGRADOURO_CLIENTE].Value = logradouro_cliente;

            comando.Parameters[ATRIBUTO_NUM_LOGRADOURO_CLIENTE].Value = numero_logradouro_cliente;
            comando.Parameters[ATRIBUTO_COMPLEMENTO_LOGRADOURO_CLIENTE].Value = complemento_cliente;
            comando.Parameters[ATRIBUTO_BAIRRO_CLIENTE].Value = bairro_cliente;
            comando.Parameters[ATRIBUTO_CIDADE_CLIENTE].Value = cidade_cliente;

            comando.Parameters[ATRIBUTO_ESTADO_CLIENTE].Value = estado_cliente;
            comando.Parameters[ATRIBUTO_CEP_CLIENTE].Value = cep_cliente;
            comando.Parameters[ATRIBUTO_TELEFONE_CLIENTE].Value = telefone_cliente;
            comando.Parameters[ATRIBUTO_EMAIL_CLIENTE].Value = email_cliente;
        }

        public override void transferirDadosIdentificador(MySqlCommand comando)
        {
            comando.Parameters[ATRIBUTO_ID_CLIENTE].Value = id_cliente;
        }

        public override void lerDados(MySqlDataReader leitorDados)
        {
            id_cliente = int.Parse(leitorDados[ATRIBUTO_ID_CLIENTE].ToString());
            nome_cliente = leitorDados[ATRIBUTO_NOME_CLIENTE].ToString();
            cpf_cnpj_cliente = leitorDados[ATRIBUTO_CPF_CNPJ_CLIENTE].ToString();
            logradouro_cliente = leitorDados[ATRIBUTO_LOGRADOURO_CLIENTE].ToString();

            numero_logradouro_cliente = leitorDados[ATRIBUTO_NUM_LOGRADOURO_CLIENTE].ToString();
            complemento_cliente = leitorDados[ATRIBUTO_COMPLEMENTO_LOGRADOURO_CLIENTE].ToString();
            bairro_cliente = leitorDados[ATRIBUTO_BAIRRO_CLIENTE].ToString();
            cidade_cliente = leitorDados[ATRIBUTO_CIDADE_CLIENTE].ToString();

            estado_cliente = leitorDados[ATRIBUTO_ESTADO_CLIENTE].ToString();
            cep_cliente = leitorDados[ATRIBUTO_CEP_CLIENTE].ToString();
            telefone_cliente = leitorDados[ATRIBUTO_TELEFONE_CLIENTE].ToString();
            email_cliente = leitorDados[ATRIBUTO_EMAIL_CLIENTE].ToString();

        }








    }
}
