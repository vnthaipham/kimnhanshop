using System;

namespace KimNhanShop.Data.Infrastructure
{
    public class Disposable : IDisposable // cài đặt các phương thức để tự động hủy
    {
        private bool isDisposed;

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!isDisposed && disposing)
            {
                DisposeCore();
            }
            isDisposed = true;
        }

        // Override this to dispose custom objects
        protected virtual void DisposeCore()
        {
        }
    }
}