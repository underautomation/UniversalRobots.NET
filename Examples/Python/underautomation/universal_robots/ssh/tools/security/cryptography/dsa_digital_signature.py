import typing
from underautomation.universal_robots.ssh.tools.security.dsa_key import DsaKey
from underautomation.universal_robots.ssh.tools.security.cryptography.digital_signature import DigitalSignature
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import DsaDigitalSignature as dsa_digital_signature

class DsaDigitalSignature(DigitalSignature):
	def __init__(self, key: DsaKey, _internal = 0):
		if(_internal == 0):
			self._instance = dsa_digital_signature(key)
		else:
			self._instance = _internal
	def verify(self, input: int, signature: int) -> bool:
		return self._instance.Verify(input, signature)
	def sign(self, input: int) -> int:
		return self._instance.Sign(input)
	def dispose(self) -> None:
		self._instance.Dispose()
