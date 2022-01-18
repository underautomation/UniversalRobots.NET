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
	def sign(self, data: int) -> int:
		return self._instance.Sign(data)
	def verify_signature(self, data: int, signature: int) -> bool:
		return self._instance.VerifySignature(data, signature)
	@property
	def public(self) -> BigInteger:
		return BigInteger(None, self._instance.Public)
	@public.setter
	def public(self, value: BigInteger):
		self._instance.Public = value
	@property
	def key_length(self) -> int:
		return self._instance.KeyLength
