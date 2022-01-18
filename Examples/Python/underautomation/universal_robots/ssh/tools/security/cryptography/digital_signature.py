import typing
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography import DigitalSignature as digital_signature

class DigitalSignature:
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = digital_signature()
		else:
			self._instance = _internal
	def verify(self, input: int, signature: int) -> bool:
		return self._instance.Verify(input, signature)
	def sign(self, input: int) -> int:
		return self._instance.Sign(input)
