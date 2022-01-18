import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import AuthenticationEventArgs as authentication_event_args

class AuthenticationEventArgs:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = authentication_event_args()
		else:
			self._instance = _internal
	@property
	def username(self) -> str:
		return self._instance.Username
