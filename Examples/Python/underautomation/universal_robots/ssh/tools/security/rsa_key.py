import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
from underautomation.universal_robots.ssh.tools.security.key import Key
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import RsaKey as rsa_key

class RsaKey(Key):
	def __init__(self, modulus: BigInteger, exponent: BigInteger, d: BigInteger, p: BigInteger, q: BigInteger, inverseQ: BigInteger, _internal = 0):
		if(_internal == 0):
			self._instance = rsa_key(modulus, exponent, d, p, q, inverseQ)
		else:
			self._instance = _internal
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def modulus(self) -> BigInteger:
		return BigInteger(None, self._instance.Modulus)
	@property
	def exponent(self) -> BigInteger:
		return BigInteger(None, self._instance.Exponent)
	@property
	def d(self) -> BigInteger:
		return BigInteger(None, self._instance.D)
	@property
	def p(self) -> BigInteger:
		return BigInteger(None, self._instance.P)
	@property
	def q(self) -> BigInteger:
		return BigInteger(None, self._instance.Q)
	@property
	def dp(self) -> BigInteger:
		return BigInteger(None, self._instance.DP)
	@property
	def dq(self) -> BigInteger:
		return BigInteger(None, self._instance.DQ)
	@property
	def inverse_q(self) -> BigInteger:
		return BigInteger(None, self._instance.InverseQ)
	@property
	def key_length(self) -> int:
		return self._instance.KeyLength
	@property
	def public(self) -> typing.List[BigInteger]:
		return [BigInteger(x) for x in self._instance.Public]
	@public.setter
	def public(self, value: typing.List[BigInteger]):
		self._instance.Public = value
