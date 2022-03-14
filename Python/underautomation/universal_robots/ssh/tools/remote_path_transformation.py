import typing
from underautomation.universal_robots.ssh.tools.i_remote_path_transformation import IRemotePathTransformation
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import RemotePathTransformation as remote_path_transformation

class RemotePathTransformation:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = remote_path_transformation()
		else:
			self._instance = _internal
	@property
	def shell_quote(self) -> IRemotePathTransformation:
		return IRemotePathTransformation(self._instance.ShellQuote)
	@property
	def none(self) -> IRemotePathTransformation:
		return IRemotePathTransformation(self._instance.None)
	@property
	def double_quote(self) -> IRemotePathTransformation:
		return IRemotePathTransformation(self._instance.DoubleQuote)
