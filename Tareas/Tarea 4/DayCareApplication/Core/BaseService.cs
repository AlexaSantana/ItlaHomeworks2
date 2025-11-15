using System.Collections.Generic;

namespace Daycare.Application.Core
{
    public abstract class BaseService
    {
        protected readonly List<string> _errors = new();

        protected void ValidateRequired(string? value, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                _errors.Add($"El campo '{fieldName}' es obligatorio.");
            }
        }

        protected void ValidateIdGreaterThanZero(int id, string fieldName)
        {
            if (id <= 0)
            {
                _errors.Add($"El campo '{fieldName}' debe ser mayor que cero.");
            }
        }

        protected ServiceResult<T> BuildErrorResult<T>()
        {
            return ServiceResult<T>.Fail(new List<string>(_errors), "Errores de validación.");
        }
    }
}
