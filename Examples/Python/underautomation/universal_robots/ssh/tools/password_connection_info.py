import typing
from underautomation.universal_robots.ssh.tools.proxy_types import ProxyTypes
from underautomation.universal_robots.ssh.tools.common.authentication_password_change_event_args import AuthenticationPasswordChangeEventArgs
from underautomation.universal_robots.ssh.tools.connection_info import ConnectionInfo
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import PasswordConnectionInfo as password_connection_info

class PasswordConnectionInfo(ConnectionInfo):
	def __init__(self, host: str, port: int, username: str, password: typing.List[int], proxyType: ProxyTypes, proxyHost: str, proxyPort: int, proxyUsername: str, proxyPassword: str, _internal = 0):
		if(_internal == 0):
			self._instance = password_connection_info(host, port, username, password, proxyType, proxyHost, proxyPort, proxyUsername, proxyPassword)
		else:
			self._instance = _internal
	def password_expired(self, handler):
		self._instance.PasswordExpired+= lambda sender, e : handler(sender, AuthenticationPasswordChangeEventArgs(None, e))
	def add__password_expired(self, value: typing.Any) -> None:
		self._instance.add_PasswordExpired(value)
	def remove__password_expired(self, value: typing.Any) -> None:
		self._instance.remove_PasswordExpired(value)
	def dispose(self) -> None:
		self._instance.Dispose()
