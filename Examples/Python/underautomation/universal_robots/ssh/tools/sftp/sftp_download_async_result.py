import typing
from underautomation.universal_robots.ssh.tools.common.async_result import AsyncResult
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Sftp import SftpDownloadAsyncResult as sftp_download_async_result

class SftpDownloadAsyncResult(AsyncResult):
	def __init__(self, asyncCallback: typing.Any, state: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = sftp_download_async_result(asyncCallback, state)
		else:
			self._instance = _internal
	@property
	def is_download_canceled(self) -> bool:
		return self._instance.IsDownloadCanceled
	@is_download_canceled.setter
	def is_download_canceled(self, value: bool):
		self._instance.IsDownloadCanceled = value
	@property
	def downloaded_bytes(self) -> int:
		return self._instance.DownloadedBytes
