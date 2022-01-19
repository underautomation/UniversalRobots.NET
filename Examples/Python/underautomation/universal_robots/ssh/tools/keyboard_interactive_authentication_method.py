import typing
from underautomation.universal_robots.ssh.tools.authentication_result import AuthenticationResult
from underautomation.universal_robots.ssh.tools.session import Session
from underautomation.universal_robots.ssh.tools.common.authentication_prompt_event_args import AuthenticationPromptEventArgs
from underautomation.universal_robots.ssh.tools.authentication_method import AuthenticationMethod
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import KeyboardInteractiveAuthenticationMethod as keyboard_interactive_authentication_method

class KeyboardInteractiveAuthenticationMethod(AuthenticationMethod):
	def __init__(self, username: str, _internal = 0):
		if(_internal == 0):
			self._instance = keyboard_interactive_authentication_method(username)
		else:
			self._instance = _internal
	def authentication_prompt(self, handler):
		self._instance.AuthenticationPrompt+= lambda sender, e : handler(sender, AuthenticationPromptEventArgs(None, None, None, None, e))
	def add__authentication_prompt(self, value: typing.Any) -> None:
		self._instance.add_AuthenticationPrompt(value)
	def remove__authentication_prompt(self, value: typing.Any) -> None:
		self._instance.remove_AuthenticationPrompt(value)
	def authenticate(self, session: Session) -> AuthenticationResult:
		return AuthenticationResult(self._instance.Authenticate(session._instance))
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def name(self) -> str:
		return self._instance.Name
