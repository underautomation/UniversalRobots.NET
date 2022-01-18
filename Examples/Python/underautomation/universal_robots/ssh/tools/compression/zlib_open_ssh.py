import typing
from underautomation.universal_robots.ssh.tools.session import Session
from underautomation.universal_robots.ssh.tools.compression.compressor import Compressor
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Compression import ZlibOpenSsh as zlib_open_ssh

class ZlibOpenSsh(Compressor):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = zlib_open_ssh()
		else:
			self._instance = _internal
	def init(self, session: Session) -> None:
		self._instance.Init(session._instance)
	@property
	def name(self) -> str:
		return self._instance.Name
