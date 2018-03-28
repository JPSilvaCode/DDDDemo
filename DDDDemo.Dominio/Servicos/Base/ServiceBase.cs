using DDDDemo.Dominio.Entidades;
using DDDDemo.Dominio.Interfaces.Repositorio.Base;
using DDDDemo.Dominio.Interfaces.Servico.Base;
using DDDDemo.Dominio.Interfaces.Validation;
using DDDDemo.Dominio.Validations.CategoriaValid;
using DomainValidation.Validation;
using System;
using System.Collections.Generic;

namespace DDDDemo.Dominio.Servicos.Base
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private readonly ValidationResult _validationResult;

        protected ValidationResult ValidationResult
        {
            get { return _validationResult; }
        }

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
            _validationResult = new ValidationResult();
        }

        public virtual ValidationResult Add(TEntity obj)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            if (obj is ISelfValidation selfValidationEntity && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;            

            _repository.Add(obj);
            return _validationResult;
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public ValidationResult Remove(TEntity obj)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            _repository.Remove(obj);
            return _validationResult;
        }

        public ValidationResult Update(TEntity obj)
        {
            if (!ValidationResult.IsValid)
                return ValidationResult;

            if (obj is ISelfValidation selfValidationEntity && !selfValidationEntity.IsValid)
                return selfValidationEntity.ValidationResult;

            _repository.Update(obj);
            return _validationResult;
        }
    }
}
