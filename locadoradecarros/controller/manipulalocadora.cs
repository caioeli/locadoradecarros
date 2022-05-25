using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using locadoradecarros.View;
using locadoradecarros.Model;
using System.Windows.Forms;

namespace locadoradecarros.controller
{
    class manipulalocadora
    {
        public void cadastrolocadora()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pINserircarro", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("modelo", locadora.Modelo);
                cmd.Parameters.AddWithValue("ano", locadora.Ano);
                cmd.Parameters.AddWithValue("imagem", locadora.Imagem);
                cmd.Parameters.AddWithValue("preco", locadora.Preco);
                cmd.Parameters.AddWithValue("marca", locadora.Marca);
                cmd.Parameters.AddWithValue("disponivel", locadora.Disponivel);

                SqlParameter nv = cmd.Parameters.Add("@idcarro", SqlDbType.Int);
                nv.Direction = ParameterDirection.Output;

                cn.Open();
                cmd.ExecuteNonQuery();

                var resposta = MessageBox.Show("Carro cadastrado com Sucesso, deseja, Deseja fazer cadastro novamente ?  ",
                    "Parabéns", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

                if (resposta == DialogResult.Yes)
                {
                    locadora.Retorno = "Sim";
                    return;
                }
                else
                {
                    locadora.Retorno = "Não";
                    return;

                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void deletarcarro()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pDeletar", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idcarro", locadora.Idcarro);
                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Carro Excluído com sucesso",
                    "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("O carro não pode ser Excluido",
                    "atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }
        public void alterarlocadora()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pAlterar", cn);
            cmd.CommandType = CommandType.StoredProcedure;



            try
            {
                cmd.Parameters.AddWithValue("@Idcarro", locadora.Idcarro);
                cmd.Parameters.AddWithValue("@modelo", locadora.Modelo);
                cmd.Parameters.AddWithValue("@ano", locadora.Ano);
                cmd.Parameters.AddWithValue("@imagem", locadora.Imagem);
                cmd.Parameters.AddWithValue("@preco", locadora.Preco);
                cmd.Parameters.AddWithValue("@marca", locadora.Marca);
                cmd.Parameters.AddWithValue("@disponivel", locadora.Disponivel);



                cn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Carro alterado com sucesso", "Atenção",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception)
            {
                MessageBox.Show("O Carro não foi Alterado",
                "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }

        }
    }
}
