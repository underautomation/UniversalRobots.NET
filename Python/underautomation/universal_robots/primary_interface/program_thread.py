import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import ProgramThread as program_thread

class ProgramThread:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = program_thread()
		else:
			self._instance = _internal
	@property
	def line_number(self) -> int:
		return self._instance.LineNumber
	@line_number.setter
	def line_number(self, value: int):
		self._instance.LineNumber = value
	@property
	def line_name(self) -> str:
		return self._instance.LineName
	@line_name.setter
	def line_name(self, value: str):
		self._instance.LineName = value
	@property
	def thread_name(self) -> str:
		return self._instance.ThreadName
	@thread_name.setter
	def thread_name(self, value: str):
		self._instance.ThreadName = value
