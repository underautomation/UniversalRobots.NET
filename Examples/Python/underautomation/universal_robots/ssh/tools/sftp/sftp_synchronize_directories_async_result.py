import typing
from underautomation.universal_robots.ssh.tools.common.async_result_1 import AsyncResult1
import clr
import os
clr.AddReference(os.path.realpath(os.path.join(os.path.dirname(__file__), "..", "..", "..", "..", "..", 'lib', 'UnderAutomation.UniversalRobots.dll')))
from UnderAutomation.UniversalRobots.Ssh.Tools.Sftp import SftpSynchronizeDirectoriesAsyncResult as sftp_synchronize_directories_async_result

class SftpSynchronizeDirectoriesAsyncResult(AsyncResult1):
	def __init__(self, asyncCallback: typing.Any, state: typing.Any, _internal = 0):
		if(_internal == 0):
			self._instance = sftp_synchronize_directories_async_result(asyncCallback, state)
		else:
			self._instance = _internal
	@property
	def files_read(self) -> int:
		return self._instance.FilesRead
