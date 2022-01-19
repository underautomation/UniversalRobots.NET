import typing
from underautomation.universal_robots.ssh.tools.proxy_types import ProxyTypes
from underautomation.universal_robots.ssh.tools.common.authentication_prompt_event_args import AuthenticationPromptEventArgs
from underautomation.universal_robots.ssh.tools.connection_info import ConnectionInfo
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import KeyboardInteractiveConnectionInfo as keyboard_interactive_connection_info

class KeyboardInteractiveConnectionInfo(ConnectionInfo):
	def __init__(self, host: str, port: int, username: str, proxyType: ProxyTypes, proxyHost: str, proxyPort: int, proxyUsername: str, proxyPassword: str, _internal = 0):
		if(_internal == 0):
			self._instance = keyboard_interactive_connection_info(host, port, username, proxyType, proxyHost, proxyPort, proxyUsername, proxyPassword)
		else:
			self._instance = _internal
	def authentication_prompt(self, handler):
		self._instance.AuthenticationPrompt+= lambda sender, e : handler(sender, AuthenticationPromptEventArgs(None, None, None, None, e))
	def add__authentication_prompt(self, value: typing.Any) -> None:
		self._instance.add_AuthenticationPrompt(value)
	def remove__authentication_prompt(self, value: typing.Any) -> None:
		self._instance.remove_AuthenticationPrompt(value)
	def dispose(self) -> None:
		self._instance.Dispose()
