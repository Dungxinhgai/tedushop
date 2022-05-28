using System;

namespace TeduShop.Data.Infrastructure
{
    public class Dispossable : IDisposable
    {
        private bool isDisposed;

        ~Dispossable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);// thu hoach bo nho
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        protected virtual void DisposeCore()
        {
        }
    }
}