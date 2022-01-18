import typing
from underautomation.universal_robots.ssh.tools.security.rsa_key import RsaKey
from underautomation.universal_robots.ssh.tools.security.cryptography.cipher_digital_signature import CipherDigitalSignature
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import RsaDigitalSignature as rsa_digital_signature

class RsaDigitalSignature(CipherDigitalSignature):
	def __init__(self, rsaKey: RsaKey, _internal = 0):
		if(_internal == 0):
			self._instance = rsa_digital_signature(rsaKey)
		else:
			self._instance = _internal
	def dispose(self) -> None:
		self._instance.Dispose()
