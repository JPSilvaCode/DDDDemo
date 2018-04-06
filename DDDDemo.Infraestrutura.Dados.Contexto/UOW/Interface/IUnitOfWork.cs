using System;

namespace DDDDemo.Infraestrutura.Dados.Contexto.UOW.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}
