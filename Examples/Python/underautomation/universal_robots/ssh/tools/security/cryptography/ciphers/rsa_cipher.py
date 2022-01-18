import typing
from underautomation.universal_robots.ssh.tools.security.rsa_key import RsaKey
from underautomation.universal_robots.ssh.tools.security.cryptography.asymmetric_cipher import AsymmetricCipher
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography.Ciphers import RsaCipher as rsa_cipher

class RsaCipher(AsymmetricCipher):
	def __init__(self, key: RsaKey, _internal = 0):
		if(_internal == 0):
			self._instance = rsa_cipher(key)
		else:
			self._instance = _internal
	def encrypt(self, data: int, offset: int, length: int) -> int:
		return self._instance.Encrypt(data, offset, length)
	def decrypt(self, data: int) -> int:
		return self._instance.Decrypt(data)
	def decrypt(self, data: int, offset: int, length: int) -> int:
		return self._instance.Decrypt(data, offset, length)
