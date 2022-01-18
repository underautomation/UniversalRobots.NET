import typing
from underautomation.universal_robots.ssh.tools.authentication_result import AuthenticationResult
from underautomation.universal_robots.ssh.tools.session import Session
from underautomation.universal_robots.ssh.tools.authentication_method import AuthenticationMethod
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import NoneAuthenticationMethod as none_authentication_method

class NoneAuthenticationMethod(AuthenticationMethod):
	def __init__(self, username: str, _internal = 0):
		if(_internal == 0):
			self._instance = none_authentication_method(username)
		else:
			self._instance = _internal
	def authenticate(self, session: Session) -> AuthenticationResult:
		return AuthenticationResult(self._instance.Authenticate(session._instance))
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def name(self) -> str:
		return self._instance.Name
