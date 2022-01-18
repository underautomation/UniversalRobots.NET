import typing
from underautomation.universal_robots.ssh.tools.common.authentication_event_args import AuthenticationEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import AuthenticationPasswordChangeEventArgs as authentication_password_change_event_args

class AuthenticationPasswordChangeEventArgs(AuthenticationEventArgs):
	def __init__(self, username: str, _internal = 0):
		if(_internal == 0):
			self._instance = authentication_password_change_event_args(username)
		else:
			self._instance = _internal
	@property
	def new_password(self) -> int:
		return self._instance.NewPassword
	@new_password.setter
	def new_password(self, value: int):
		self._instance.NewPassword = value
