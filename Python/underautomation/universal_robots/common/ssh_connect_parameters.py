import typing
from underautomation.universal_robots.ssh.internal.ssh_parameters_base import SshParametersBase
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import SshConnectParameters as ssh_connect_parameters

class SshConnectParameters(SshParametersBase):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_connect_parameters()
		else:
			self._instance = _internal
	@property
	def enable_ssh(self) -> bool:
		return self._instance.EnableSsh
	@enable_ssh.setter
	def enable_ssh(self, value: bool):
		self._instance.EnableSsh = value
	@property
	def enable_sftp(self) -> bool:
		return self._instance.EnableSftp
	@enable_sftp.setter
	def enable_sftp(self, value: bool):
		self._instance.EnableSftp = value
