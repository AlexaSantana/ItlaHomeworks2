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
    public class TutorService : BaseService, ITutorService
    {
        private readonly ITutorRepository _tutorRepository;

        public TutorService(ITutorRepository tutorRepository)
        {
            _tutorRepository = tutorRepository;
        }

        private TutorDto MapToDto(Tutor entity)
        {
            return new TutorDto
            {
                Id = entity.Id,
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                Phone = entity.Phone,
                Email = entity.Email,
                Relation = entity.Relation
            };
        }

        private Tutor MapToEntity(TutorDto dto)
        {
            return new Tutor
            {
                Id = dto.Id,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Phone = dto.Phone,
                Email = dto.Email,
                Relation = dto.Relation
            };
        }

        private void ValidateTutor(TutorDto dto)
        {
            _errors.Clear();

            ValidateRequired(dto.FirstName, "Nombre");
            ValidateRequired(dto.LastName, "Apellido");
            ValidateRequired(dto.Phone, "Teléfono");
            ValidateRequired(dto.Email, "Email");
            ValidateRequired(dto.Relation, "Relación");
        }

        public async Task<ServiceResult<List<TutorDto>>> GetAllAsync()
        {
            var list = await _tutorRepository.GetAllAsync();
            var dtos = list.Select(MapToDto).ToList();
            return ServiceResult<List<TutorDto>>.Ok(dtos);
        }

        public async Task<ServiceResult<TutorDto>> GetByIdAsync(int id)
        {
            var entity = await _tutorRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return ServiceResult<TutorDto>.Fail(
                    new List<string> { "Tutor no encontrado." },
                    "No existe el registro."
                );
            }

            return ServiceResult<TutorDto>.Ok(MapToDto(entity));
        }

        public async Task<ServiceResult<TutorDto>> CreateAsync(TutorDto dto)
        {
            ValidateTutor(dto);
            if (_errors.Any())
            {
                return BuildErrorResult<TutorDto>();
            }

            var entity = MapToEntity(dto);
            var created = await _tutorRepository.AddAsync(entity);
            return ServiceResult<TutorDto>.Ok(MapToDto(created), "Tutor creado correctamente.");
        }

        public async Task<ServiceResult<TutorDto>> UpdateAsync(TutorDto dto)
        {
            ValidateIdGreaterThanZero(dto.Id, "Id");
            ValidateTutor(dto);
            if (_errors.Any())
            {
                return BuildErrorResult<TutorDto>();
            }

            var entity = MapToEntity(dto);
            await _tutorRepository.UpdateAsync(entity);
            return ServiceResult<TutorDto>.Ok(dto, "Tutor actualizado correctamente.");
        }

        public async Task<ServiceResult<bool>> DeleteAsync(int id)
        {
            ValidateIdGreaterThanZero(id, "Id");
            if (_errors.Any())
            {
                return BuildErrorResult<bool>();
            }

            var entity = await _tutorRepository.GetByIdAsync(id);
            if (entity == null)
            {
                return ServiceResult<bool>.Fail(
                    new List<string> { "Tutor no encontrado." },
                    "No existe el registro."
                );
            }

            await _tutorRepository.DeleteAsync(entity);
            return ServiceResult<bool>.Ok(true, "Tutor eliminado correctamente.");
        }
    }
}
