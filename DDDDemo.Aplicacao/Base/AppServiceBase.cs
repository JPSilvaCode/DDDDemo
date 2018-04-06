using DDDDemo.Aplicacao.Interfaces.Base;
using DDDDemo.Dominio.Interfaces.Servico.Base;
using DDDDemo.Infraestrutura.Dados.Contexto.UOW.Interface;
using DomainValidation.Validation;
using System;
using System.Collections.Generic;

namespace DDDDemo.Aplicacao.Base
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IServiceBase<TEntity> _serviceBase;

        protected ValidationResult ValidationResult { get; private set; }

        public AppServiceBase(IUnitOfWork unitOfWork, IServiceBase<TEntity> serviceBase)
        {
            _unitOfWork = unitOfWork;
            _serviceBase = serviceBase;
            ValidationResult = new ValidationResult();
        }

        public ValidationResult Add(TEntity obj)
        {
            ValidationResult.Add(_serviceBase.Add(obj));
            if (ValidationResult.IsValid)            
                _unitOfWork.Commit();            
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
            if (ValidationResult.IsValid)
                _unitOfWork.Commit();
            return ValidationResult;
        }

        public ValidationResult Update(TEntity obj)
        {
            ValidationResult.Add(_serviceBase.Update(obj));
            if (ValidationResult.IsValid)
                _unitOfWork.Commit();
            return ValidationResult;
        }
    }
}
