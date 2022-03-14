import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Common import PackageEventArgs as package_event_args

class PackageEventArgs:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = package_event_args()
		else:
			self._instance = _internal
	@property
	def receive_date(self) -> typing.Any:
		return self._instance.ReceiveDate
	@receive_date.setter
	def receive_date(self, value: typing.Any):
		self._instance.ReceiveDate = value
