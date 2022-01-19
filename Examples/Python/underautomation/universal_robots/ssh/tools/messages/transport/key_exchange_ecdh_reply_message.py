import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Transport import KeyExchangeEcdhReplyMessage as key_exchange_ecdh_reply_message

class KeyExchangeEcdhReplyMessage(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = key_exchange_ecdh_reply_message()
		else:
			self._instance = _internal
	@property
	def ks(self) -> typing.List[int]:
		return self._instance.KS
	@property
	def qs(self) -> typing.List[int]:
		return self._instance.QS
	@property
	def signature(self) -> typing.List[int]:
		return self._instance.Signature
