using DDDDemo.Aplicacao.Interfaces.Base;
using DDDDemo.Dominio.Interfaces.Servico.Base;
using DomainValidation.Validation;
using System;
using System.Collections.Generic;

namespace DDDDemo.Aplicacao.Base
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;

        protected ValidationResult ValidationResult { get; private set; }

        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
            ValidationResult = new ValidationResult();
        }

        public ValidationResult Add(TEntity obj)
        {
            ValidationResult.Add(_serviceBase.Add(obj));
            return ValidationResult;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public ValidationResult Remove(TEntity obj)
        {
            ValidationResult.Add(_serviceBase.Remove(obj));
            return ValidationResult;
        }

        public ValidationResult Update(TEntity obj)
        {
            ValidationResult.Add(_serviceBase.Update(obj));
            return ValidationResult;
        }
    }
}
