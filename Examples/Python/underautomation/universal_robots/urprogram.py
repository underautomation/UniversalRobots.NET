import typing
from underautomation.universal_robots.urarchive import URArchive
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots import URProgram as urprogram

class URProgram(URArchive):
	def __init__(self, xml: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = urprogram(xml)
		else:
			self._instance = _internal
	@staticmethod
	def load(urpStream: typing.Any) -> 'URProgram':
		return urprogram.Load(urpStream)
	@staticmethod
	def load(urpFile: str) -> 'URProgram':
		return urprogram.Load(urpFile)
	@property
	def extension(self) -> str:
		return self._instance.EXTENSION
	@extension.setter
	def extension(self, value: str):
		self._instance.EXTENSION = value
