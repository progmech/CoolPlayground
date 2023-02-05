namespace PatternsAndConventions.Patterns;

public class DisposablePattern : IDisposable
{
    private bool _disposed = false;
    private void Dispose(bool disposing)
    {
        if (_disposed) return;
        if (disposing)
        {
            // TODO free managed resources 
        }
        _disposed = true;
        // TODO release unmanaged resources here        
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    ~DisposablePattern()
    {
        Dispose(false);
    }
}