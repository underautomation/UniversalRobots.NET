## Improved Connection Error Messages

Connection errors now include a clear indication of **which protocol** failed to connect. Each protocol's internal connect method is wrapped with a specific `ConnectException` that identifies the service name, IP, and port.

### Affected Protocols

| Protocol             | Service Name             |
| -------------------- | ------------------------ |
| Primary Interface    | `"Primary Interface"`    |
| RTDE                 | `"RTDE"`                 |
| SSH                  | `"SSH"`                  |
| SFTP                 | `"SFTP"`                 |
| Interpreter Mode     | `"Interpreter Mode"`     |
| XML-RPC              | `"XML-RPC"`              |
| Socket Communication | `"Socket Communication"` |

### Example

When a connection to a specific protocol fails, the exception message now clearly states which one:

```
Failed to connect to RTDE of Universal Robots cobot "192.168.0.1:30004" : No connection could be made because the target machine actively refused it.
```
