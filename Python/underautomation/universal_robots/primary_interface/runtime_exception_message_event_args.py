import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import RuntimeExceptionMessageEventArgs as runtime_exception_message_event_args

class RuntimeExceptionMessageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = runtime_exception_message_event_args()
		else:
			self._instance = _internal
	@property
	def script_line_number(self) -> int:
		return self._instance.ScriptLineNumber
	@script_line_number.setter
	def script_line_number(self, value: int):
		self._instance.ScriptLineNumber = value
	@property
	def script_column_number(self) -> int:
		return self._instance.ScriptColumnNumber
	@script_column_number.setter
	def script_column_number(self, value: int):
		self._instance.ScriptColumnNumber = value
	@property
	def runtime_exception_text_message(self) -> str:
		return self._instance.RuntimeExceptionTextMessage
	@runtime_exception_text_message.setter
	def runtime_exception_text_message(self, value: str):
		self._instance.RuntimeExceptionTextMessage = value
