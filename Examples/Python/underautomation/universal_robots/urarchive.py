import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots import URArchive as urarchive

class URArchive:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = urarchive()
		else:
			self._instance = _internal
	def save(self, stream: typing.Any) -> None:
		self._instance.Save(stream)
	def save(self, directory: str) -> str:
		return self._instance.Save(directory)
	@staticmethod
	def load(filePath: str) -> typing.Any:
		return urarchive.Load(filePath)
	@staticmethod
	def load(fileStream: typing.Any) -> typing.Any:
		return urarchive.Load(fileStream)
	@property
	def xml(self) -> typing.Any:
		return self._instance.XML
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
	@property
	def file_name(self) -> str:
		return self._instance.FileName
