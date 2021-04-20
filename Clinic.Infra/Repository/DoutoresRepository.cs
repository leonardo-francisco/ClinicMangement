using Clinic.Dominio.Entities;
using Clinic.Dominio.Repository.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Infra.Repository
{
    public class DoutoresRepository : DBConnection, IDoutoresRepository
    {
        public DoutoresRepository(IConfiguration configuration) : base(configuration)
        {

        }

        public async Task<int> CreateAsync(Doutores entity)
        {
            try
            {
                var query = "INSERT INTO Doutores VALUES(@Nome, @Sobrenome, @DataNascimento, @Sexo, @Telefone, @Email, @Especialidade, @Endereco, @Cidade, @Pais, @Escola, @Curso, @DataInicio, @DataFim, @Grau, @Empresa, @Posicao, @PeriodoDe, @PeriodoAte, @CidadeEmpresa, @UrlFoto)";

                var parameters = new DynamicParameters();
                parameters.Add("Nome", entity.Nome, DbType.String);
                parameters.Add("Sobrenome", entity.Sobrenome, DbType.String);
                parameters.Add("DataNascimento", entity.DataNascimento, DbType.DateTime);
                parameters.Add("Sexo", entity.Sexo, DbType.String);
                parameters.Add("Telefone", entity.Telefone, DbType.Int32);
                parameters.Add("Email", entity.Email, DbType.String);
                parameters.Add("Especialidade", entity.Especialidade, DbType.String);
                parameters.Add("Endereco", entity.Endereco, DbType.String);
                parameters.Add("Cidade", entity.Cidade, DbType.String);
                parameters.Add("Pais", entity.Pais, DbType.String);
                parameters.Add("Escola", entity.Escola, DbType.String);
                parameters.Add("Curso", entity.Curso, DbType.String);
                parameters.Add("DataInicio", entity.DataInicio, DbType.DateTime);
                parameters.Add("DataFim", entity.DataFim, DbType.DateTime);
                parameters.Add("Grau", entity.Grau, DbType.String);
                parameters.Add("Empresa", entity.Empresa, DbType.String);
                parameters.Add("Posicao", entity.Posicao, DbType.String);
                parameters.Add("PeriodoDe", entity.PeriodoDe, DbType.DateTime);
                parameters.Add("PeriodoAte", entity.PeriodoAte, DbType.DateTime);
                parameters.Add("CidadeEmpresa", entity.CidadeEmpresa, DbType.String);
                parameters.Add("UrlFoto", entity.UrlFoto, DbType.String);

                using (var connection = CreateConnection())
                {
                    return (await connection.ExecuteAsync(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<int> DeleteAsync(Doutores entity)
        {
            try
            {
                var query = "DELETE FROM Doutores WHERE Id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("Id", entity.Id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.ExecuteAsync(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<List<Doutores>> GetAllAsync()
        {
            try
            {
                var query = "SELECT * FROM Doutores";
                using (var connection = CreateConnection())
                {
                    return (await connection.QueryAsync<Doutores>(query)).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<Doutores> GetByIdAsync(int id)
        {
            try
            {
                var query = "SELECT * FROM Doutores WHERE Id = @Id";

                var parameters = new DynamicParameters();
                parameters.Add("Id", id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.QueryFirstOrDefaultAsync<Doutores>(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }

        public async Task<int> UpdateAsync(Doutores entity)
        {
            try
            {
                var query = "UPDATE Doutores SET @Nome = Nome, @Sobrenome = Sobrenome, @DataNascimento = DataNascimento, @Sexo = Sexo, @Telefone = Telefone, @Email = Email,  @Especialidade = Especialidade, @Endereco = Endereco, @Cidade = Cidade, @Pais = Pais, @Escola = Escola, @Curso = Curso, @DataInicio = DataInicio, @DataFim = DataFim, @Grau = Grau, @Empresa = Empresa, @Posicao = Posicao, @PeriodoDe = PeriodoDe, @PeriodoAte = PeriodoAte, @CidadeEmpresa = CidadeEmpresa, @UrlFoto = UrlFoto WHERE Id = @Id";
                var parameters = new DynamicParameters();
                parameters.Add("Nome", entity.Nome, DbType.String);
                parameters.Add("Sobrenome", entity.Sobrenome, DbType.String);
                parameters.Add("DataNascimento", entity.DataNascimento, DbType.DateTime);
                parameters.Add("Sexo", entity.Sexo, DbType.String);
                parameters.Add("Telefone", entity.Telefone, DbType.Int32);
                parameters.Add("Email", entity.Email, DbType.String);
                parameters.Add("Especialidade", entity.Especialidade, DbType.String);
                parameters.Add("Endereco", entity.Endereco, DbType.String);
                parameters.Add("Cidade", entity.Cidade, DbType.String);
                parameters.Add("Pais", entity.Pais, DbType.String);
                parameters.Add("Escola", entity.Escola, DbType.String);
                parameters.Add("Curso", entity.Curso, DbType.String);
                parameters.Add("DataInicio", entity.DataInicio, DbType.DateTime);
                parameters.Add("DataFim", entity.DataFim, DbType.DateTime);
                parameters.Add("Grau", entity.Grau, DbType.String);
                parameters.Add("Empresa", entity.Empresa, DbType.String);
                parameters.Add("Posicao", entity.Posicao, DbType.String);
                parameters.Add("PeriodoDe", entity.PeriodoDe, DbType.DateTime);
                parameters.Add("PeriodoAte", entity.PeriodoAte, DbType.DateTime);
                parameters.Add("CidadeEmpresa", entity.CidadeEmpresa, DbType.String);
                parameters.Add("UrlFoto", entity.UrlFoto, DbType.String);
                parameters.Add("Id", entity.Id, DbType.Int32);

                using (var connection = CreateConnection())
                {
                    return (await connection.ExecuteAsync(query, parameters));
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex);
            }
        }
    }
}

