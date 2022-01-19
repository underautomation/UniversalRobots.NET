import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import PipeStream as pipe_stream

class PipeStream:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = pipe_stream()
		else:
			self._instance = _internal
	def flush(self) -> None:
		self._instance.Flush()
	def seek(self, offset: int, origin: typing.Any) -> int:
		return self._instance.Seek(offset, origin)
	def set_length(self, value: int) -> None:
		self._instance.SetLength(value)
	def read(self, buffer: typing.List[int], offset: int, count: int) -> int:
		return self._instance.Read(buffer, offset, count)
	def write(self, buffer: typing.List[int], offset: int, count: int) -> None:
		self._instance.Write(buffer, offset, count)
	@property
	def max_buffer_length(self) -> int:
		return self._instance.MaxBufferLength
	@max_buffer_length.setter
	def max_buffer_length(self, value: int):
		self._instance.MaxBufferLength = value
	@property
	def block_last_read_buffer(self) -> bool:
		return self._instance.BlockLastReadBuffer
	@block_last_read_buffer.setter
	def block_last_read_buffer(self, value: bool):
		self._instance.BlockLastReadBuffer = value
	@property
	def can_read(self) -> bool:
		return self._instance.CanRead
	@property
	def can_seek(self) -> bool:
		return self._instance.CanSeek
	@property
	def can_write(self) -> bool:
		return self._instance.CanWrite
	@property
	def length(self) -> int:
		return self._instance.Length
	@property
	def position(self) -> int:
		return self._instance.Position
	@position.setter
	def position(self, value: int):
		self._instance.Position = value
