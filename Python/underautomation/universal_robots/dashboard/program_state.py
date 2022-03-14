import typing
from underautomation.universal_robots.dashboard.program_states import ProgramStates
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Dashboard import ProgramState as program_state

class ProgramState:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = program_state()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	@property
	def state(self) -> ProgramStates:
		return ProgramStates(self._instance.State)
	@state.setter
	def state(self, value: ProgramStates):
		self._instance.State = value
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
