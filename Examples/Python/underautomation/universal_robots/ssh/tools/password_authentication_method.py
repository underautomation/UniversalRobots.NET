import typing
from underautomation.universal_robots.ssh.tools.authentication_result import AuthenticationResult
from underautomation.universal_robots.ssh.tools.session import Session
from underautomation.universal_robots.ssh.tools.common.authentication_password_change_event_args import AuthenticationPasswordChangeEventArgs
from underautomation.universal_robots.ssh.tools.authentication_method import AuthenticationMethod
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import PasswordAuthenticationMethod as password_authentication_method

class PasswordAuthenticationMethod(AuthenticationMethod):
	def __init__(self, username: str, password: str, _internal = 0):
		if(_internal == 0):
			self._instance = password_authentication_method(username, password)
		else:
			self._instance = _internal
	def password_expired(self, handler):
		self._instance.PasswordExpired+= lambda sender, e : handler(sender, AuthenticationPasswordChangeEventArgs(None, e))
	def add__password_expired(self, value: typing.Any) -> None:
		self._instance.add_PasswordExpired(value)
	def remove__password_expired(self, value: typing.Any) -> None:
		self._instance.remove_PasswordExpired(value)
	def authenticate(self, session: Session) -> AuthenticationResult:
		return AuthenticationResult(self._instance.Authenticate(session._instance))
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def name(self) -> str:
		return self._instance.Name
