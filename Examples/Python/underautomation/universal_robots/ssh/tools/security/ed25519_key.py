import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
from underautomation.universal_robots.ssh.tools.security.key import Key
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import ED25519Key as ed25519_key

class ED25519Key(Key):
	def __init__(self, pk: typing.List[int], sk: typing.List[int], _internal = 0):
		if(_internal == 0):
			self._instance = ed25519_key(pk, sk)
		else:
			self._instance = _internal
	def __repr__(self):
		return self._instance.ToString()
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def public(self) -> typing.List[BigInteger]:
		return [BigInteger(x) for x in self._instance.Public]
	@public.setter
	def public(self, value: typing.List[BigInteger]):
		self._instance.Public = value
	@property
	def key_length(self) -> int:
		return self._instance.KeyLength
	@property
	def public_key(self) -> typing.List[int]:
		return self._instance.PublicKey
	@property
	def private_key(self) -> typing.List[int]:
		return self._instance.PrivateKey
