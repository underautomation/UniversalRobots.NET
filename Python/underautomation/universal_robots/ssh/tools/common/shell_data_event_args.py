import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import ShellDataEventArgs as shell_data_event_args

class ShellDataEventArgs:
	def __init__(self, data: typing.List[int], _internal = 0):
		if(_internal == 0):
			self._instance = shell_data_event_args(data)
		else:
			self._instance = _internal
	@property
	def data(self) -> typing.List[int]:
		return self._instance.Data
	@property
	def line(self) -> str:
		return self._instance.Line
