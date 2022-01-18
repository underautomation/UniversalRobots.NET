import typing
from underautomation.universal_robots.ssh.tools.common.ssh_data import SshData
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages import Message as message

class Message(SshData):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = message()
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
