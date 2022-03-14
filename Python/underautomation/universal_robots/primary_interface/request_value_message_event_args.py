import typing
from underautomation.universal_robots.primary_interface.requested_types import RequestedTypes
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import RequestValueMessageEventArgs as request_value_message_event_args

class RequestValueMessageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = request_value_message_event_args()
		else:
			self._instance = _internal
	@property
	def request_id(self) -> int:
		return self._instance.RequestId
	@request_id.setter
	def request_id(self, value: int):
		self._instance.RequestId = value
	@property
	def requested_type(self) -> RequestedTypes:
		return RequestedTypes(self._instance.RequestedType)
	@requested_type.setter
	def requested_type(self, value: RequestedTypes):
		self._instance.RequestedType = value
	@property
	def request_text_message(self) -> str:
		return self._instance.RequestTextMessage
	@request_text_message.setter
	def request_text_message(self, value: str):
		self._instance.RequestTextMessage = value
