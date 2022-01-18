import typing
from underautomation.universal_robots.ssh.tools.security.host_algorithm import HostAlgorithm
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import PrivateKeyFile as private_key_file

class PrivateKeyFile:
	def __init__(self, fileName: str, passPhrase: str, _internal = 0):
		if(_internal == 0):
			self._instance = private_key_file(fileName, passPhrase)
		else:
			self._instance = _internal
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def host_key(self) -> HostAlgorithm:
		return HostAlgorithm(self._instance.HostKey)
