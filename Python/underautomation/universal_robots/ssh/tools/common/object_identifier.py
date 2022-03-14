import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import ObjectIdentifier as object_identifier

class ObjectIdentifier:
	def __init__(self, identifiers: typing.List[int], _internal = 0):
		if(_internal == 0):
			self._instance = object_identifier(identifiers)
		else:
			self._instance = _internal
	@property
	def identifiers(self) -> typing.List[int]:
		return self._instance.Identifiers
