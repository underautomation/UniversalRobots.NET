import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import SshException as ssh_exception

class SshException:
	def __init__(self, message: str, inner: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_exception(message, inner)
		else:
			self._instance = _internal
