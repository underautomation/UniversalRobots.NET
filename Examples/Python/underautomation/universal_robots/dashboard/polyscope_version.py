import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Dashboard import PolyscopeVersion as polyscope_version

class PolyscopeVersion:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = polyscope_version()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
