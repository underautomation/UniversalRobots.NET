import typing
from underautomation.universal_robots.ssh.tools.proxy_types import ProxyTypes
from underautomation.universal_robots.ssh.tools.authentication_method import AuthenticationMethod
from underautomation.universal_robots.ssh.tools.common.authentication_banner_event_args import AuthenticationBannerEventArgs
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools import ConnectionInfo as connection_info

class ConnectionInfo:
	def __init__(self, host: str, port: int, username: str, proxyType: ProxyTypes, proxyHost: str, proxyPort: int, proxyUsername: str, proxyPassword: str, authenticationMethods: typing.List[AuthenticationMethod], _internal = 0):
		if(_internal == 0):
			self._instance = connection_info(host, port, username, proxyType, proxyHost, proxyPort, proxyUsername, proxyPassword, authenticationMethods)
		else:
			self._instance = _internal
	def authentication_banner(self, handler):
		self._instance.AuthenticationBanner+= lambda sender, e : handler(sender, AuthenticationBannerEventArgs(None, None, None, e))
	def add__authentication_banner(self, value: typing.Any) -> None:
		self._instance.add_AuthenticationBanner(value)
	def remove__authentication_banner(self, value: typing.Any) -> None:
		self._instance.remove_AuthenticationBanner(value)
	@property
	def key_exchange_algorithms(self) -> typing.Any:
		return self._instance.KeyExchangeAlgorithms
	@property
	def encryptions(self) -> typing.Any:
		return self._instance.Encryptions
	@property
	def hmac_algorithms(self) -> typing.Any:
		return self._instance.HmacAlgorithms
	@property
	def host_key_algorithms(self) -> typing.Any:
		return self._instance.HostKeyAlgorithms
	@property
	def authentication_methods(self) -> typing.Any:
		return self._instance.AuthenticationMethods
	@property
	def compression_algorithms(self) -> typing.Any:
		return self._instance.CompressionAlgorithms
	@property
	def channel_requests(self) -> typing.Any:
		return self._instance.ChannelRequests
	@property
	def is_authenticated(self) -> bool:
		return self._instance.IsAuthenticated
	@property
	def host(self) -> str:
		return self._instance.Host
	@property
	def port(self) -> int:
		return self._instance.Port
	@property
	def username(self) -> str:
		return self._instance.Username
	@property
	def proxy_type(self) -> ProxyTypes:
		return ProxyTypes(self._instance.ProxyType)
	@property
	def proxy_host(self) -> str:
		return self._instance.ProxyHost
	@property
	def proxy_port(self) -> int:
		return self._instance.ProxyPort
	@property
	def proxy_username(self) -> str:
		return self._instance.ProxyUsername
	@property
	def proxy_password(self) -> str:
		return self._instance.ProxyPassword
	@property
	def timeout(self) -> typing.Any:
		return self._instance.Timeout
	@timeout.setter
	def timeout(self, value: typing.Any):
		self._instance.Timeout = value
	@property
	def channel_close_timeout(self) -> typing.Any:
		return self._instance.ChannelCloseTimeout
	@channel_close_timeout.setter
	def channel_close_timeout(self, value: typing.Any):
		self._instance.ChannelCloseTimeout = value
	@property
	def encoding(self) -> typing.Any:
		return self._instance.Encoding
	@encoding.setter
	def encoding(self, value: typing.Any):
		self._instance.Encoding = value
	@property
	def retry_attempts(self) -> int:
		return self._instance.RetryAttempts
	@retry_attempts.setter
	def retry_attempts(self, value: int):
		self._instance.RetryAttempts = value
	@property
	def max_sessions(self) -> int:
		return self._instance.MaxSessions
	@max_sessions.setter
	def max_sessions(self, value: int):
		self._instance.MaxSessions = value
	@property
	def current_key_exchange_algorithm(self) -> str:
		return self._instance.CurrentKeyExchangeAlgorithm
	@property
	def current_server_encryption(self) -> str:
		return self._instance.CurrentServerEncryption
	@property
	def current_client_encryption(self) -> str:
		return self._instance.CurrentClientEncryption
	@property
	def current_server_hmac_algorithm(self) -> str:
		return self._instance.CurrentServerHmacAlgorithm
	@property
	def current_client_hmac_algorithm(self) -> str:
		return self._instance.CurrentClientHmacAlgorithm
	@property
	def current_host_key_algorithm(self) -> str:
		return self._instance.CurrentHostKeyAlgorithm
	@property
	def current_server_compression_algorithm(self) -> str:
		return self._instance.CurrentServerCompressionAlgorithm
	@property
	def server_version(self) -> str:
		return self._instance.ServerVersion
	@property
	def client_version(self) -> str:
		return self._instance.ClientVersion
	@property
	def current_client_compression_algorithm(self) -> str:
		return self._instance.CurrentClientCompressionAlgorithm
