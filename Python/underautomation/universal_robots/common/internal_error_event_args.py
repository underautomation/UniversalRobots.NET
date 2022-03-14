import typing
from underautomation.universal_robots.common.status_code import StatusCode
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import InternalErrorEventArgs as internal_error_event_args

class InternalErrorEventArgs:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = internal_error_event_args()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def exception(self) -> typing.Any:
		return self._instance.Exception
	@property
	def message(self) -> str:
		return self._instance.Message
	@property
	def status(self) -> StatusCode:
		return StatusCode(self._instance.Status)
