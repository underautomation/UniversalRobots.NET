import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..",  'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Sftp import SftpFileStream as sftp_file_stream

class SftpFileStream:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = sftp_file_stream()
		else:
			self._instance = _internal
	def flush(self) -> None:
		self._instance.Flush()
	def read(self, buffer: typing.List[int], offset: int, count: int) -> int:
		return self._instance.Read(buffer, offset, count)
	def read_byte(self) -> int:
		return self._instance.ReadByte()
	def seek(self, offset: int, origin: typing.Any) -> int:
		return self._instance.Seek(offset, origin)
	def set_length(self, value: int) -> None:
		self._instance.SetLength(value)
	def write(self, buffer: typing.List[int], offset: int, count: int) -> None:
		self._instance.Write(buffer, offset, count)
	def write_byte(self, value: int) -> None:
		self._instance.WriteByte(value)
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
	def can_timeout(self) -> bool:
		return self._instance.CanTimeout
	@property
	def length(self) -> int:
		return self._instance.Length
	@property
	def position(self) -> int:
		return self._instance.Position
	@position.setter
	def position(self, value: int):
		self._instance.Position = value
	@property
	def name(self) -> str:
		return self._instance.Name
	@property
	def handle(self) -> typing.List[int]:
		return self._instance.Handle
	@property
	def timeout(self) -> typing.Any:
		return self._instance.Timeout
	@timeout.setter
	def timeout(self, value: typing.Any):
		self._instance.Timeout = value
