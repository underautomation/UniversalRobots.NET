import typing
from underautomation.universal_robots.ssh.tools.messages.transport.disconnect_reason import DisconnectReason
from underautomation.universal_robots.ssh.tools.common.ssh_exception import SshException
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import SshConnectionException as ssh_connection_exception

class SshConnectionException(SshException):
	def __init__(self, message: str, disconnectReasonCode: DisconnectReason, inner: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_connection_exception(message, disconnectReasonCode, inner)
		else:
			self._instance = _internal
	@property
	def disconnect_reason(self) -> DisconnectReason:
		return DisconnectReason(self._instance.DisconnectReason)
