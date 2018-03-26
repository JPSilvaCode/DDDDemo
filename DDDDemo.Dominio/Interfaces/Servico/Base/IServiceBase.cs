using DomainValidation.Validation;
using System.Collections.Generic;

namespace DDDDemo.Dominio.Interfaces.Servico.Base
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        ValidationResult Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        ValidationResult Update(TEntity obj);
        ValidationResult Remove(TEntity obj);
    }
}
