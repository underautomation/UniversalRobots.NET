import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import SshData as ssh_data

class SshData:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_data()
		else:
			self._instance = _internal
	def get_bytes(self) -> typing.List[int]:
		return self._instance.GetBytes()
	def load(self, data: typing.List[int]) -> None:
		self._instance.Load(data)
	def load(self, data: typing.List[int], offset: int, count: int) -> None:
		self._instance.Load(data, offset, count)
