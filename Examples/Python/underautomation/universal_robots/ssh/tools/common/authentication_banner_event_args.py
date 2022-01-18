import typing
from underautomation.universal_robots.ssh.tools.common.authentication_event_args import AuthenticationEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import AuthenticationBannerEventArgs as authentication_banner_event_args

class AuthenticationBannerEventArgs(AuthenticationEventArgs):
	def __init__(self, username: str, message: str, language: str, _internal = 0):
		if(_internal == 0):
			self._instance = authentication_banner_event_args(username, message, language)
		else:
			self._instance = _internal
	@property
	def banner_message(self) -> str:
		return self._instance.BannerMessage
	@property
	def language(self) -> str:
		return self._instance.Language
