import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
from underautomation.universal_robots.ssh.tools.common.object_identifier import ObjectIdentifier
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Common import DerData as der_data

class DerData:
	def __init__(self, data: int, construct: bool, _internal = 0):
		if(_internal == 0):
			self._instance = der_data(data, construct)
		else:
			self._instance = _internal
	def encode(self) -> int:
		return self._instance.Encode()
	def read_big_integer(self) -> BigInteger:
		return BigInteger(None, self._instance.ReadBigInteger())
	def read_integer(self) -> int:
		return self._instance.ReadInteger()
	def read_octet_string(self) -> int:
		return self._instance.ReadOctetString()
	def read_bit_string(self) -> int:
		return self._instance.ReadBitString()
	def read_object(self) -> int:
		return self._instance.ReadObject()
	def write(self, data: bool) -> None:
		self._instance.Write(data)
	def write(self, data: int) -> None:
		self._instance.Write(data)
	def write(self, data: BigInteger) -> None:
		self._instance.Write(data._instance)
	def write(self, data: int) -> None:
		self._instance.Write(data)
	def write_bitstring(self, data: int) -> None:
		self._instance.WriteBitstring(data)
	def write(self, identifier: ObjectIdentifier) -> None:
		self._instance.Write(identifier._instance)
	def write_object_identifier(self, bytes: int) -> None:
		self._instance.WriteObjectIdentifier(bytes)
	def write_null(self) -> None:
		self._instance.WriteNull()
	def write(self, data: 'DerData') -> None:
		self._instance.Write(data._instance)
	def read_length(self) -> int:
		return self._instance.ReadLength()
	def write_bytes(self, data: typing.Any) -> None:
		self._instance.WriteBytes(data)
	def read_byte(self) -> int:
		return self._instance.ReadByte()
	def read_bytes(self, length: int) -> int:
		return self._instance.ReadBytes(length)
	@property
	def is_end_of_data(self) -> bool:
		return self._instance.IsEndOfData
