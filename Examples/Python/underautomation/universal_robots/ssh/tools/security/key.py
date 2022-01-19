import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import Key as key

class Key:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = key()
		else:
			self._instance = _internal
	def sign(self, data: typing.List[int]) -> typing.List[int]:
		return self._instance.Sign(data)
	def verify_signature(self, data: typing.List[int], signature: typing.List[int]) -> bool:
		return self._instance.VerifySignature(data, signature)
	@property
	def public(self) -> typing.List[BigInteger]:
		return [BigInteger(x) for x in self._instance.Public]
	@public.setter
	def public(self, value: typing.List[BigInteger]):
		self._instance.Public = value
	@property
	def key_length(self) -> int:
		return self._instance.KeyLength
