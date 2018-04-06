using DDDDemo.Infraestrutura.Dados.Contexto.Contexto;
using DDDDemo.Infraestrutura.Dados.Contexto.UOW.Interface;
using System;

namespace DDDDemo.Infraestrutura.Dados.Contexto.UOW
{
    public class UnitOfWork : IUnitOfWork
    {
        private DDDDemoContext _context;

        public UnitOfWork(DDDDemoContext context)
        {
            _context = context;
        }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_context != null)
                {
                    _context.Dispose();
                    _context = null;
                }
            }
        }
    }
}
