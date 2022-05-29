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
            catch(Exception)
            {
                throw;
            }
        }

        public void Deletarcarro()
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

        public static BindingSource pesquisaranocarro()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarano", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ano", locadora.Ano);
            cn.Open();
            cmd.ExecuteNonQuery();

            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);

            DataTable table = new DataTable();

            sqlData.Fill(table);

            BindingSource dados = new BindingSource();
            dados.DataSource = table;

            return dados;

        }

        public static BindingSource pesquisarmodelo()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarmodelo", cn);
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("@modelo", locadora.Modelo);
            cn.Open();
            cmd.ExecuteNonQuery();



            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);



            DataTable table = new DataTable();



            sqlData.Fill(table);



            BindingSource dados = new BindingSource();
            dados.DataSource = table;



            return dados;



        }

        public static BindingSource pesquisarmarcacarro()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarmarca", cn);
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("@marca", locadora.Marca);
            cn.Open();
            cmd.ExecuteNonQuery();



            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);



            DataTable table = new DataTable();



            sqlData.Fill(table);



            BindingSource dados = new BindingSource();
            dados.DataSource = table;



            return dados;
        }
        public static BindingSource pesquisarprecocarro()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarpreco", cn);
            cmd.CommandType = CommandType.StoredProcedure;



            cmd.Parameters.AddWithValue("@preco", locadora.Preco);
            cn.Open();
            cmd.ExecuteNonQuery();



            SqlDataAdapter sqlData = new SqlDataAdapter(cmd);



            DataTable table = new DataTable();



            sqlData.Fill(table);



            BindingSource dados = new BindingSource();
            dados.DataSource = table;



            return dados;
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
                MessageBox.Show("Carro excluido com sucesso", "Exclusção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch(Exception)
            {
                MessageBox.Show("O carro não pode ser excluido", "Atenção!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                if(cn.State != ConnectionState.Closed)
                {
                    cn.Close();
                }
            }
        }

        public void pesquisarlocadora()
        {
            SqlConnection cn = new SqlConnection(conexaoBD.conectar());
            SqlCommand cmd = new SqlCommand("pBuscarcarro", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            try
            {
                cmd.Parameters.AddWithValue("@idcarro", locadora.Idcarro);
                cn.Open();

                var arrayDados = cmd.ExecuteReader();

                if (arrayDados.Read())
                {
                    locadora.Idcarro = Convert.ToInt32(arrayDados["idcarro"]);
                    locadora.Modelo = arrayDados["modelo"].ToString();
                    locadora.Marca = arrayDados["marca"].ToString();
                    locadora.Ano = arrayDados["ano"].ToString();
                    locadora.Preco = arrayDados["preco"].ToString();
                    locadora.Disponivel = arrayDados["diponivel"].ToString();
                }else
                {
                    MessageBox.Show("carro nao localizado", "Atençao!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    locadora.Retorno = "nao";
                }

            }catch(Exception e)
            {
                MessageBox.Show(e.Message,"erro",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
