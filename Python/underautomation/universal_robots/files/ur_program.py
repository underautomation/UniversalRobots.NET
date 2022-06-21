import typing
from underautomation.universal_robots.files.ur_archive import URArchive
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Files import URProgram as ur_program

class URProgram(URArchive):
	def __init__(self, xml: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = ur_program(xml)
		else:
			self._instance = _internal
	@staticmethod
	def load(urpFile: str) -> 'URProgram':
		return URProgram(None, ur_program.Load(urpFile))
	@property
	def extension(self) -> str:
		return self._instance.EXTENSION
	@extension.setter
	def extension(self, value: str):
		self._instance.EXTENSION = value
