import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import ExceptionEventArgs as exception_event_args

class ExceptionEventArgs:
	def __init__(self, exception: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = exception_event_args(exception)
		else:
			self._instance = _internal
	@property
	def exception(self) -> typing.Any:
		return self._instance.Exception
