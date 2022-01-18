import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import Algorithm as algorithm

class Algorithm:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = algorithm()
		else:
			self._instance = _internal
	@property
	def name(self) -> str:
		return self._instance.Name
