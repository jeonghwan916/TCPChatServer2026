namespace TCPChatServer;

using System.Net.Sockets;

public class ConnectedClient : IDisposable
{
    // TCP 클라이언트 객체
    private readonly TcpClient _client;
    // 네트워크 스트림
    private readonly NetworkStream _stream;
    // 클라이언트 ID
    private readonly string _clientId;
    // 연결 종료 여부
    private bool _isDisposed;
    
    // 클라이언트 ID 프로퍼티
    public string ClientId => _clientId;
    // 클라이언트 연결 여부
    public bool IsConnected => !_isDisposed && _client.Connected;

    public void Dispose()
    {
        if (_isDisposed) return;
        _isDisposed = true;
        _client.Dispose();
        _stream.Dispose();
    }
}
