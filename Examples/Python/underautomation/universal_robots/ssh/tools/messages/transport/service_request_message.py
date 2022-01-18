import typing
from underautomation.universal_robots.ssh.tools.messages.service_name import ServiceName
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Transport import ServiceRequestMessage as service_request_message

class ServiceRequestMessage(Message):
	def __init__(self, serviceName: ServiceName, _internal = 0):
		if(_internal == 0):
			self._instance = service_request_message(serviceName)
		else:
			self._instance = _internal
	@property
	def service_name(self) -> ServiceName:
		return ServiceName(self._instance.ServiceName)
