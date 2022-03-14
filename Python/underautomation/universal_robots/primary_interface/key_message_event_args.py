import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import KeyMessageEventArgs as key_message_event_args

class KeyMessageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = key_message_event_args()
		else:
			self._instance = _internal
	@property
	def robot_message_code(self) -> int:
		return self._instance.RobotMessageCode
	@robot_message_code.setter
	def robot_message_code(self, value: int):
		self._instance.RobotMessageCode = value
	@property
	def robot_message_argument(self) -> int:
		return self._instance.RobotMessageArgument
	@robot_message_argument.setter
	def robot_message_argument(self, value: int):
		self._instance.RobotMessageArgument = value
	@property
	def robot_message_title(self) -> str:
		return self._instance.RobotMessageTitle
	@robot_message_title.setter
	def robot_message_title(self, value: str):
		self._instance.RobotMessageTitle = value
	@property
	def key_text_message(self) -> str:
		return self._instance.KeyTextMessage
	@key_text_message.setter
	def key_text_message(self, value: str):
		self._instance.KeyTextMessage = value
