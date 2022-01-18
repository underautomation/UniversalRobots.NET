import typing
from underautomation.universal_robots.ssh.tools.security.ed25519_key import ED25519Key
from underautomation.universal_robots.ssh.tools.security.cryptography.digital_signature import DigitalSignature
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import ED25519DigitalSignature as ed25519_digital_signature

class ED25519DigitalSignature(DigitalSignature):
	def __init__(self, key: ED25519Key, _internal = 0):
		if(_internal == 0):
			self._instance = ed25519_digital_signature(key)
		else:
			self._instance = _internal
	def verify(self, input: int, signature: int) -> bool:
		return self._instance.Verify(input, signature)
	def sign(self, input: int) -> int:
		return self._instance.Sign(input)
	def dispose(self) -> None:
		self._instance.Dispose()
