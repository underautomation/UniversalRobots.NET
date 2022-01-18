import typing
from underautomation.universal_robots.ssh.tools.security.cryptography.cipher import Cipher
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import AsymmetricCipher as asymmetric_cipher

class AsymmetricCipher(Cipher):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = asymmetric_cipher()
		else:
			self._instance = _internal
	@property
	def minimum_size(self) -> int:
		return self._instance.MinimumSize
