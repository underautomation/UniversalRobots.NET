import typing
from underautomation.universal_robots.ssh.tools.security.cryptography.ciphers.cipher_padding import CipherPadding
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Security.Cryptography.Ciphers.Paddings import PKCS7Padding as pkcs7_padding

class PKCS7Padding(CipherPadding):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = pkcs7_padding()
		else:
			self._instance = _internal
	def pad(self, blockSize: int, input: typing.List[int], offset: int, length: int) -> typing.List[int]:
		return self._instance.Pad(blockSize, input, offset, length)
	def pad(self, input: typing.List[int], offset: int, length: int, paddinglength: int) -> typing.List[int]:
		return self._instance.Pad(input, offset, length, paddinglength)
