import typing
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import TextMessageEventArgs as text_message_event_args

class TextMessageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = text_message_event_args()
		else:
			self._instance = _internal
	@property
	def text_message(self) -> str:
		return self._instance.TextMessage
	@text_message.setter
	def text_message(self, value: str):
		self._instance.TextMessage = value
