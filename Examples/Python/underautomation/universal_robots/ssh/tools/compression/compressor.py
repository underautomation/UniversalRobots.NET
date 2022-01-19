import typing
from underautomation.universal_robots.ssh.tools.session import Session
from underautomation.universal_robots.ssh.tools.security.algorithm import Algorithm
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Compression import Compressor as compressor

class Compressor(Algorithm):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = compressor()
		else:
			self._instance = _internal
	def init(self, session: Session) -> None:
		self._instance.Init(session._instance)
	def compress(self, data: typing.List[int]) -> typing.List[int]:
		return self._instance.Compress(data)
	def compress(self, data: typing.List[int], offset: int, length: int) -> typing.List[int]:
		return self._instance.Compress(data, offset, length)
	def decompress(self, data: typing.List[int]) -> typing.List[int]:
		return self._instance.Decompress(data)
	def decompress(self, data: typing.List[int], offset: int, length: int) -> typing.List[int]:
		return self._instance.Decompress(data, offset, length)
	def dispose(self) -> None:
		self._instance.Dispose()
