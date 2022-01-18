import typing
from underautomation.universal_robots.ssh.tools.authentication_result import AuthenticationResult
from underautomation.universal_robots.ssh.tools.session import Session
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import AuthenticationMethod as authentication_method

class AuthenticationMethod:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = authentication_method()
		else:
			self._instance = _internal
	def authenticate(self, session: Session) -> AuthenticationResult:
		return AuthenticationResult(self._instance.Authenticate(session._instance))
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def username(self) -> str:
		return self._instance.Username
	@property
	def allowed_authentications(self) -> str:
		return self._instance.AllowedAuthentications
