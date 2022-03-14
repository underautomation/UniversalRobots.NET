import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import MasterboardDigitalIO as masterboard_digital_io

class MasterboardDigitalIO:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = masterboard_digital_io()
		else:
			self._instance = _internal
	@property
	def value(self) -> int:
		return self._instance.Value
	@property
	def bit_array(self) -> typing.Any:
		return self._instance.BitArray
	@property
	def digital0(self) -> bool:
		return self._instance.Digital0
	@property
	def digital1(self) -> bool:
		return self._instance.Digital1
	@property
	def digital2(self) -> bool:
		return self._instance.Digital2
	@property
	def digital3(self) -> bool:
		return self._instance.Digital3
	@property
	def digital4(self) -> bool:
		return self._instance.Digital4
	@property
	def digital5(self) -> bool:
		return self._instance.Digital5
	@property
	def digital6(self) -> bool:
		return self._instance.Digital6
	@property
	def digital7(self) -> bool:
		return self._instance.Digital7
	@property
	def configurable0(self) -> bool:
		return self._instance.Configurable0
	@property
	def configurable1(self) -> bool:
		return self._instance.Configurable1
	@property
	def configurable2(self) -> bool:
		return self._instance.Configurable2
	@property
	def configurable3(self) -> bool:
		return self._instance.Configurable3
	@property
	def configurable4(self) -> bool:
		return self._instance.Configurable4
	@property
	def configurable5(self) -> bool:
		return self._instance.Configurable5
	@property
	def configurable6(self) -> bool:
		return self._instance.Configurable6
	@property
	def configurable7(self) -> bool:
		return self._instance.Configurable7
	@property
	def tool_digital0(self) -> bool:
		return self._instance.ToolDigital0
	@property
	def tool_digital1(self) -> bool:
		return self._instance.ToolDigital1
