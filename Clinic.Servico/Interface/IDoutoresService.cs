using Clinic.Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Servico.Interface
{
    public interface IDoutoresService
    {
        public Task<List<Doutores>> GetAllDoctors();
        public Task<Doutores> GetDoctorsById(int id);
        public Task<int> CreateDoctorsAsync(Doutores doutores);
        public Task<int> UpdateDoctorsAsync(Doutores doutores);
        public Task<int> DeleteDoctorsAsync(Doutores doutores);
    }
}
