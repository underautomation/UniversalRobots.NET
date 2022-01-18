import typing
from underautomation.universal_robots.ssh.tools.private_key_file import PrivateKeyFile
from underautomation.universal_robots.ssh.tools.authentication_result import AuthenticationResult
from underautomation.universal_robots.ssh.tools.session import Session
from underautomation.universal_robots.ssh.tools.authentication_method import AuthenticationMethod
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import PrivateKeyAuthenticationMethod as private_key_authentication_method

class PrivateKeyAuthenticationMethod(AuthenticationMethod):
	def __init__(self, username: str, keyFiles: PrivateKeyFile, _internal = 0):
		if(_internal == 0):
			self._instance = private_key_authentication_method(username, keyFiles)
		else:
			self._instance = _internal
	def authenticate(self, session: Session) -> AuthenticationResult:
		return AuthenticationResult(self._instance.Authenticate(session._instance))
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def key_files(self) -> typing.Any:
		return self._instance.KeyFiles
