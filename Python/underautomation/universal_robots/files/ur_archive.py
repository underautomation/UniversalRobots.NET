import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Files import URArchive as ur_archive

class URArchive:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = ur_archive()
		else:
			self._instance = _internal
	def save(self, directory: str) -> str:
		return self._instance.Save(directory)
	@staticmethod
	def load(fileStream: typing.Any) -> typing.Any:
		return ur_archive.Load(fileStream)
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
