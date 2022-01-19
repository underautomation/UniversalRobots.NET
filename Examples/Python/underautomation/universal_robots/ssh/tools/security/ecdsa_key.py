import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
from underautomation.universal_robots.ssh.tools.security.key import Key
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import EcdsaKey as ecdsa_key

class EcdsaKey(Key):
	def __init__(self, curve: str, publickey: typing.List[int], privatekey: typing.List[int], _internal = 0):
		if(_internal == 0):
			self._instance = ecdsa_key(curve, publickey, privatekey)
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def hash_algorithm(self) -> typing.Any:
		return self._instance.HashAlgorithm
	@property
	def key_length(self) -> int:
		return self._instance.KeyLength
	@property
	def public(self) -> typing.List[BigInteger]:
		return [BigInteger(x) for x in self._instance.Public]
	@public.setter
	def public(self, value: typing.List[BigInteger]):
		self._instance.Public = value
	@property
	def ecdsa(self) -> typing.Any:
		return self._instance.Ecdsa
