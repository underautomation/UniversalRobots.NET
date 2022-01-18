import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Internal import SshParametersBase as ssh_parameters_base

class SshParametersBase:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_parameters_base()
		else:
			self._instance = _internal
	@property
	def username(self) -> str:
		return self._instance.Username
	@username.setter
	def username(self, value: str):
		self._instance.Username = value
	@property
	def password(self) -> str:
		return self._instance.Password
	@password.setter
	def password(self, value: str):
		self._instance.Password = value
