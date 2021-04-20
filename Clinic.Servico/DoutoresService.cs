using Clinic.Dominio.Entities;
using Clinic.Dominio.Repository.Interface;
using Clinic.Servico.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Clinic.Servico
{
    public class DoutoresService : IDoutoresService
    {
        private readonly IDoutoresRepository _doutoresRepository;
        public DoutoresService(IDoutoresRepository doutoresRepository)
        {
            _doutoresRepository = doutoresRepository;
        }

        public async Task<int> CreateDoctorsAsync(Doutores doutores)
        {
            return await _doutoresRepository.CreateAsync(doutores);
        }

        public async Task<int> DeleteDoctorsAsync(Doutores doutores)
        {
            return await _doutoresRepository.DeleteAsync(doutores);
        }

        public async Task<List<Doutores>> GetAllDoctors()
        {
            return await _doutoresRepository.GetAllAsync();
        }

        public async Task<Doutores> GetDoctorsById(int id)
        {
            return await _doutoresRepository.GetByIdAsync(id);
        }

        public async Task<int> UpdateDoctorsAsync(Doutores doutores)
        {
            return await _doutoresRepository.UpdateAsync(doutores);
        }
    }
}
