using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Daycare.Application.Contract;
using Daycare.Application.Core;
using Daycare.Application.Dtos;
using Daycare.Domain.Entities;
using Daycare.Infrastructure.Interfaces;

namespace Daycare.Application.Services
{
    public class InfanteService : BaseService, IInfanteService
    {
        private readonly IInfanteRepository _infanteRepository;

        public InfanteService(IInfanteRepository infanteRepository)
        {
            _infanteRepository = infanteRepository;
        }

        private InfanteDto MapToDto(Infante entity)
        {
            return new InfanteDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Phone = entity.Phone,
                Email = entity.Email,
                BirthDate = entity.BirthDate,
                GroupName = entity.GroupName,
                TutorId = entity.TutorId
            };
        }

        private Infante MapToEntity(InfanteDto dto)
        {
            return new Infante
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                Email = dto.Email,
                BirthDate = dto.BirthDate,
                GroupName = dto.GroupName,
                TutorId = dto.TutorId
            };
        }

        private void ValidateInfante(InfanteDto dto)
        {
            _errors.Clear();

            ValidateRequired(dto.FirstName, "Nombre");
            ValidateRequired(dto.LastName, "Apellido");
            ValidateRequired(dto.Phone, "Teléfono");
            ValidateRequired(dto.Email, "Email");
            ValidateRequired(dto.GroupName, "Grupo");
            ValidateIdGreaterThanZero(dto.TutorId, "TutorId");
        }

        public async Task<ServiceResult<List<InfanteDto>>> GetAllAsync()
        {
            var list = await _infanteRepository.GetAllAsync();
            var dtos = list.Select(MapToDto).ToList();
            return ServiceResult<List<InfanteDto>>.Ok(dtos);
        }

        public async Task<ServiceResult<InfanteDto>> GetByIdAsync(int id)
        {
            var entity = await _infanteRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return ServiceResult<InfanteDto>.Fail(
                    new List<string> { "Infante no encontrado." },
                    "No existe el registro."
                );
            }

            return ServiceResult<InfanteDto>.Ok(MapToDto(entity));
        }

        public async Task<ServiceResult<InfanteDto>> CreateAsync(InfanteDto dto)
        {
            ValidateInfante(dto);
            if (_errors.Any())
            {
                return BuildErrorResult<InfanteDto>();
            }

            var entity = MapToEntity(dto);
            var created = await _infanteRepository.AddAsync(entity);
            return ServiceResult<InfanteDto>.Ok(MapToDto(created), "Infante creado correctamente.");
        }

        public async Task<ServiceResult<InfanteDto>> UpdateAsync(InfanteDto dto)
        {
            ValidateIdGreaterThanZero(dto.Id, "Id");
            ValidateInfante(dto);
            if (_errors.Any())
            {
                return BuildErrorResult<InfanteDto>();
            }

            var entity = MapToEntity(dto);
            await _infanteRepository.UpdateAsync(entity);
            return ServiceResult<InfanteDto>.Ok(dto, "Infante actualizado correctamente.");
        }

        public async Task<ServiceResult<bool>> DeleteAsync(int id)
        {
            ValidateIdGreaterThanZero(id, "Id");
            if (_errors.Any())
            {
                return BuildErrorResult<bool>();
            }

            var entity = await _infanteRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return ServiceResult<bool>.Fail(
                    new List<string> { "Infante no encontrado." },
                    "No existe el registro."
                );
            }

            await _infanteRepository.DeleteAsync(entity);
            return ServiceResult<bool>.Ok(true, "Infante eliminado correctamente.");
        }
    }
}
