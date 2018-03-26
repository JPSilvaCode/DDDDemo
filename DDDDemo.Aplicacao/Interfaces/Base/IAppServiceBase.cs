using DomainValidation.Validation;
using System.Collections.Generic;

namespace DDDDemo.Aplicacao.Interfaces.Base
{
    public interface IAppServiceBase<TEntity> where TEntity : class
    {
        ValidationResult Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        ValidationResult Update(TEntity obj);
        ValidationResult Remove(TEntity obj);
    }
}
