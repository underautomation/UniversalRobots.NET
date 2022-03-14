import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Dashboard import ProgramSaveState as program_save_state

class ProgramSaveState:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = program_save_state()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def is_saved(self) -> bool:
		return self._instance.IsSaved
	@is_saved.setter
	def is_saved(self, value: bool):
		self._instance.IsSaved = value
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
