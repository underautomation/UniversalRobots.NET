import typing
from underautomation.universal_robots.ssh.tools.common.big_integer import BigInteger
from underautomation.universal_robots.ssh.tools.security.key import Key
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security import DsaKey as dsa_key

class DsaKey(Key):
	def __init__(self, p: BigInteger, q: BigInteger, g: BigInteger, y: BigInteger, x: BigInteger, _internal = 0):
		if(_internal == 0):
			self._instance = dsa_key(p, q, g, y, x)
		else:
			self._instance = _internal
	def dispose(self) -> None:
		self._instance.Dispose()
	@property
	def p(self) -> BigInteger:
		return BigInteger(None, self._instance.P)
	@property
	def q(self) -> BigInteger:
		return BigInteger(None, self._instance.Q)
	@property
	def g(self) -> BigInteger:
		return BigInteger(None, self._instance.G)
	@property
	def y(self) -> BigInteger:
		return BigInteger(None, self._instance.Y)
	@property
	def x(self) -> BigInteger:
		return BigInteger(None, self._instance.X)
	@property
	def key_length(self) -> int:
		return self._instance.KeyLength
	@property
	def public(self) -> BigInteger:
		return BigInteger(None, self._instance.Public)
	@public.setter
	def public(self, value: BigInteger):
		self._instance.Public = value
