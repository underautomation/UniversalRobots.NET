import typing
from underautomation.universal_robots.ssh.tools.compression.compression_mode import CompressionMode
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Compression import ZlibStream as zlib_stream

class ZlibStream:
	def __init__(self, stream: typing.Any, mode: CompressionMode, _internal = 0):
		if(_internal == 0):
			self._instance = zlib_stream(stream, mode)
		else:
			self._instance = _internal
	def write(self, buffer: int, offset: int, count: int) -> None:
		self._instance.Write(buffer, offset, count)
