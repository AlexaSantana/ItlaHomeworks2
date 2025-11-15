using System.Collections.Generic;
using System.Threading.Tasks;

namespace Daycare.Application.Core
{
    public interface IBaseService<TDto>
    {
        Task<ServiceResult<List<TDto>>> GetAllAsync();
        Task<ServiceResult<TDto>> GetByIdAsync(int id);
        Task<ServiceResult<TDto>> CreateAsync(TDto dto);
        Task<ServiceResult<TDto>> UpdateAsync(TDto dto);
        Task<ServiceResult<bool>> DeleteAsync(int id);
    }
}
