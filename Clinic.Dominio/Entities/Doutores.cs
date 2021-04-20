using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clinic.Dominio.Entities
{
    public class Doutores
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int Telefone { get; set; }
        public string Email { get; set; }
        public string Especialidade { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Pais { get; set; }
        public string Escola { get; set; }
        public string Curso { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public string Grau { get; set; }
        public string Empresa { get; set; }
        public string Posicao { get; set; }
        public DateTime PeriodoDe { get; set; }
        public DateTime PeriodoAte { get; set; }
        public string CidadeEmpresa { get; set; }
        public string UrlFoto { get; set; }
        public IFormFile FotoPerfil { get; set; }

    }
}
