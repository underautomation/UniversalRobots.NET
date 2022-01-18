import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Transport import UnimplementedMessage as unimplemented_message

class UnimplementedMessage(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = unimplemented_message()
		else:
			self._instance = _internal
