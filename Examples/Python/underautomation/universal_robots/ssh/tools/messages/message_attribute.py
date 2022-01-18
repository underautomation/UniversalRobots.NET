import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages import MessageAttribute as message_attribute

class MessageAttribute:
	def __init__(self, name: str, number: int, _internal = 0):
		if(_internal == 0):
			self._instance = message_attribute(name, number)
		else:
			self._instance = _internal
	@property
	def name(self) -> str:
		return self._instance.Name
	@name.setter
	def name(self, value: str):
		self._instance.Name = value
	@property
	def number(self) -> int:
		return self._instance.Number
	@number.setter
	def number(self, value: int):
		self._instance.Number = value
