import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import SshDataStream as ssh_data_stream

class SshDataStream:
	def __init__(self, buffer: typing.List[int], offset: int, count: int, _internal = 0):
		if(_internal == 0):
			self._instance = ssh_data_stream(buffer, offset, count)
		else:
			self._instance = _internal
	def write(self, value: int) -> None:
		self._instance.Write(value)
	def write(self, value: int) -> None:
		self._instance.Write(value)
	def write(self, data: BigInteger) -> None:
		self._instance.Write(data._instance)
	def write(self, data: typing.List[int]) -> None:
		self._instance.Write(data)
	def read_binary(self) -> typing.List[int]:
		return self._instance.ReadBinary()
	def write_binary(self, buffer: typing.List[int]) -> None:
		self._instance.WriteBinary(buffer)
	def write_binary(self, buffer: typing.List[int], offset: int, count: int) -> None:
		self._instance.WriteBinary(buffer, offset, count)
	def write(self, s: str, encoding: typing.Any) -> None:
		self._instance.Write(s, encoding)
	def read_big_int(self) -> BigInteger:
		return BigInteger(None, self._instance.ReadBigInt())
	def read_uint32(self) -> int:
		return self._instance.ReadUInt32()
	def read_uint64(self) -> int:
		return self._instance.ReadUInt64()
	def read_string(self, encoding: typing.Any) -> str:
		return self._instance.ReadString(encoding)
	def to_array(self) -> typing.List[int]:
		return self._instance.ToArray()
	@property
	def is_end_of_data(self) -> bool:
		return self._instance.IsEndOfData
