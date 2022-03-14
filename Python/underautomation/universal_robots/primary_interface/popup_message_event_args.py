import typing
from underautomation.universal_robots.primary_interface.requested_types import RequestedTypes
from underautomation.universal_robots.common.package_event_args import PackageEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.PrimaryInterface import PopupMessageEventArgs as popup_message_event_args

class PopupMessageEventArgs(PackageEventArgs):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = popup_message_event_args()
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
	def warning(self) -> bool:
		return self._instance.Warning
	@warning.setter
	def warning(self, value: bool):
		self._instance.Warning = value
	@property
	def error(self) -> bool:
		return self._instance.Error
	@error.setter
	def error(self, value: bool):
		self._instance.Error = value
	@property
	def blocking(self) -> bool:
		return self._instance.Blocking
	@blocking.setter
	def blocking(self, value: bool):
		self._instance.Blocking = value
	@property
	def popup_message_title(self) -> str:
		return self._instance.PopupMessageTitle
	@popup_message_title.setter
	def popup_message_title(self, value: str):
		self._instance.PopupMessageTitle = value
	@property
	def popup_text_message(self) -> str:
		return self._instance.PopupTextMessage
	@popup_text_message.setter
	def popup_text_message(self, value: str):
		self._instance.PopupTextMessage = value
