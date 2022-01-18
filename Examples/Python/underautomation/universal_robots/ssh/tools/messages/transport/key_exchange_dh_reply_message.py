import typing
from underautomation.universal_robots.ssh.tools.messages.message import Message
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Messages.Transport import KeyExchangeDhReplyMessage as key_exchange_dh_reply_message

class KeyExchangeDhReplyMessage(Message):
	def __init__(self, _internal = 0):
		if(_internal == 0):
			self._instance = key_exchange_dh_reply_message()
		else:
			self._instance = _internal
	@property
	def host_key(self) -> int:
		return self._instance.HostKey
	@property
	def f(self) -> int:
		return self._instance.F
	@property
	def signature(self) -> int:
		return self._instance.Signature
