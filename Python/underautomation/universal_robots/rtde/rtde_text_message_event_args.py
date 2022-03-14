import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Rtde import RtdeTextMessageEventArgs as rtde_text_message_event_args

class RtdeTextMessageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = rtde_text_message_event_args()
		else:
			self._instance = _internal
	@property
	def message(self) -> str:
		return self._instance.Message
	@message.setter
	def message(self, value: str):
		self._instance.Message = value
	@property
	def source(self) -> str:
		return self._instance.Source
	@source.setter
	def source(self, value: str):
		self._instance.Source = value
	@property
	def warning_level(self) -> int:
		return self._instance.WarningLevel
	@warning_level.setter
	def warning_level(self, value: int):
		self._instance.WarningLevel = value
